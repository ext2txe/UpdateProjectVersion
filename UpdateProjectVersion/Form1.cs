using ClFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UpdateProjectVersion
{
    public partial class Form1 : Form
    {
        private Project _project;
        private UpvSettings _settings;
        private bool _isStarting = true;
        string targetProject = "cvsettings";


        public Form1()
        {
            _project = new Project();
            InitializeComponent();
            string iniFile = MakeTargetSettingsFile();

            _settings = new UpvSettings(iniFile);

            Text = $"Update Project Version v({_project.Version}) Project [{targetProject}]";
            if (Directory.Exists(_settings.MyBaseFolder))
            {
                textBaseFolder.Text = _settings.MyBaseFolder;
                textTargetFileName.Text = _settings.MyTargetFile;
            }
        }

        private string MakeTargetSettingsFile()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                targetProject = args[1];
            }

            string fileName = $"{targetProject}.ini";
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(folder, "cvsettings", fileName);
            return path;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = textBaseFolder.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBaseFolder.Text = fbd.SelectedPath;
                textBaseFolder.Refresh();
            }
        }

        private void btnSelectTargetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = textTargetFileName.Text;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textTargetFileName.Text = ofd.FileName;
                textTargetFileName.Refresh();
            }

        }

        private string GetCurrentVersion(string text)
        {
            string[] lines = File.ReadAllLines(text);
            foreach (string line in lines)
            {
                if (line.StartsWith("[assembly: AssemblyVersion") || line.StartsWith("[assembly: AssemblyFileVersion"))
                {
                    int pos1 = line.IndexOf("(\"") + 2;
                    int pos2 = line.IndexOf("\")");
                    string version = line.Substring(pos1, pos2 - pos1);
                    return version;
                }
            }
            return "";
        }

        private void textBaseFolder_TextChanged(object sender, EventArgs e)
        {
            if (_isStarting)
            {
                return;
            }
            _settings.MyBaseFolder = textBaseFolder.Text;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBaseFolder.Text) == false)
            {
                MessageBox.Show($"No valid folder [{textBaseFolder.Text}]", "General unhappiness in the valleyh of UpdateProjectVersion");
                return;
            }

            lbVersionFiles.Items.Clear();
            string target = Path.GetFileName(textTargetFileName.Text);
            string[] files = Directory.GetFiles(textBaseFolder.Text, target,SearchOption.AllDirectories);
            foreach (string file in files)
            {
                lbVersionFiles.Items.Add(file);
            }
            lbVersionFiles.Refresh();

        }

        private void btnGetVersion_Click(object sender, EventArgs e)
        {
            if (File.Exists(textTargetFileName.Text))
            {
                textCurrentVersion.Text = GetCurrentVersion(textTargetFileName.Text);
            }
            else
            {
                MessageBox.Show($"No valid target file name [{textTargetFileName.Text}]", "General unhappiness in the valleyh of UpdateProjectVersion");
            }
        }

        private void btnFindTargets_Click(object sender, EventArgs e)
        {
            int step = 10;
            try
            {
                int UpdatedCount = 0;
                step = 20;
                if (string.IsNullOrEmpty(textNewVersion.Text))
                {
                    step = 30;
                    MessageBox.Show("First enter new version!");
                    return;
                }
                step = 40;
                for (int index = 0; index < lbVersionFiles.Items.Count; index++)
                {
                    step = 50;
                    if (lbVersionFiles.GetItemChecked(index))
                    {
                        step = 60;
                        string file = lbVersionFiles.Items[index].ToString();
                        step = 70;
                        if (UpdateVersion(file, textNewVersion, Text))
                        {
                            step = 80;
                            UpdatedCount++;
                        }
                    }
                    else
                    {
                        step = 90;

                    }
                }
                step = 100;
                MessageBox.Show($"Updated [{UpdatedCount}] files");
                step = 110;
                lbVersionFiles.ClearSelected();
            }
            catch (Exception ex)
            {
                string s = $"btnFindTargets_Click() @[{step}] [{ex.Message}]";
                throw new Exception(s);
            }
        }

        private bool UpdateVersion(string file, TextBox textNewVersion, string fileName)
        {
            int step = 10;
            try
            {
                if (rbMatchingVersion.Checked && textNewVersion.Text == "")
                {
                    MessageBox.Show("First enter new version!");
                    return false;
                }
                string backupCopy = file + ".bak";
                step = 20;
                if (File.Exists(backupCopy))
                {
                    File.Delete(backupCopy);
                }
                File.Copy(file, backupCopy);

                step = 30;
                string[] linesIn = File.ReadAllLines(file);
                step = 40;
                List<string> linesOut = new List<string>();
                step = 50;
                bool updated = false;
                foreach (string line in linesIn)
                {
                    step = 60;
                    if (line.StartsWith("[assembly: AssemblyVersion") || line.StartsWith("[assembly: AssemblyFileVersion"))
                    {
                        string lineUpdate = "";
                        step = 70;
                        if (rbMatchingVersion.Checked)
                        {
                            lineUpdate = line.Replace(textCurrentVersion.Text, textNewVersion.Text);
                            updated = true;
                        }
                        else
                        {
                            string currentVersion = GetCurrentVersionString(line);
                            lineUpdate = line.Replace(currentVersion, textNewVersion.Text);
                            updated = true;
                        }
                        linesOut.Add(lineUpdate);
                    }
                    else
                    {
                        step = 80;
                        linesOut.Add(line);
                    }
                }
                step = 90;
                File.WriteAllLines(file, linesOut.ToArray());
                return updated;
            }
            catch (Exception ex)
            {
                string s = $"UpdateVersion({file}) @[{step}] [{ex.Message}]";
                throw new Exception(s);
            }
        }

        private string GetCurrentVersionString(string line)
        {
            int pos1 = line.IndexOf("(\"");
            int pos2 = line.IndexOf("\")");
            string version = line.Substring(pos1+2, pos2 - pos1 - 2);
            return version;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGetVersion_Click(sender, e);
            btnScan_Click(sender, e);
            _isStarting = false;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lbVersionFiles.ClearSelected();
            lbVersionFiles.Refresh();
        }

        private void textTargetFileName_TextChanged(object sender, EventArgs e)
        {
            _settings.MyTargetFile = textTargetFileName.Text;
        }
    }
}

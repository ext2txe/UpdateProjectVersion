using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace UpdateProjectVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
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
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.FileName = textTargetFileName.Text;
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    textTargetFileName.Text = ofd.FileName; ;
            //    textTargetFileName.Refresh();
            if (File.Exists(textTargetFileName.Text))
            {
                textCurrentVersion.Text = GetCurrentVersion(textTargetFileName.Text);
            }
            //}
        }

        private void btnFindTargets_Click(object sender, EventArgs e)
        {
            int UpdatedCount = 0;
            for (int index=0; index < lbVersionFiles.CheckedItems.Count; index++)
            {
                if (lbVersionFiles.GetSelected(index))
                {
                    string file = lbVersionFiles.Items[index].ToString();
                    UpdateVersion(file, textNewVersion, Text);
                    UpdatedCount++;
                }
            }
            MessageBox.Show($"Updated [{UpdatedCount}] files");
            lbVersionFiles.ClearSelected();
        }

        private void UpdateVersion(string file, TextBox textNewVersion, string fileName)
        {
            int step = 10;
            try
            {
                if (rbMatchingVersion.Checked && textNewVersion.Text == "")
                {
                    MessageBox.Show("First enter new version!");
                    return;
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
                        }
                        else
                        {
                            string currentVersion = GetCurrentVersionString(line);
                            lineUpdate = line.Replace(textCurrentVersion.Text, textNewVersion.Text);
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
        }
    }
}

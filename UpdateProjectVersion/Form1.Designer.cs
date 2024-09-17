namespace UpdateProjectVersion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBaseFolder = new System.Windows.Forms.Label();
            this.textBaseFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnSelectTargetFile = new System.Windows.Forms.Button();
            this.textTargetFileName = new System.Windows.Forms.TextBox();
            this.lblTargetFileName = new System.Windows.Forms.Label();
            this.textCurrentVersion = new System.Windows.Forms.TextBox();
            this.textNewVersion = new System.Windows.Forms.TextBox();
            this.lblNewVersion = new System.Windows.Forms.Label();
            this.btnUpdateVersions = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnGetVersion = new System.Windows.Forms.Button();
            this.rbMatchingVersion = new System.Windows.Forms.RadioButton();
            this.rbAnyVersion = new System.Windows.Forms.RadioButton();
            this.lbVersionFiles = new System.Windows.Forms.CheckedListBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaseFolder
            // 
            this.lblBaseFolder.AutoSize = true;
            this.lblBaseFolder.Location = new System.Drawing.Point(41, 14);
            this.lblBaseFolder.Name = "lblBaseFolder";
            this.lblBaseFolder.Size = new System.Drawing.Size(63, 13);
            this.lblBaseFolder.TabIndex = 0;
            this.lblBaseFolder.Text = "Base Folder";
            // 
            // textBaseFolder
            // 
            this.textBaseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBaseFolder.Location = new System.Drawing.Point(106, 11);
            this.textBaseFolder.Name = "textBaseFolder";
            this.textBaseFolder.Size = new System.Drawing.Size(635, 20);
            this.textBaseFolder.TabIndex = 1;
            this.textBaseFolder.Text = "d:\\shared\\ABE\\src";
            this.textBaseFolder.TextChanged += new System.EventHandler(this.textBaseFolder_TextChanged);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Location = new System.Drawing.Point(747, 11);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(28, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "..";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnSelectTargetFile
            // 
            this.btnSelectTargetFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectTargetFile.Location = new System.Drawing.Point(747, 37);
            this.btnSelectTargetFile.Name = "btnSelectTargetFile";
            this.btnSelectTargetFile.Size = new System.Drawing.Size(28, 23);
            this.btnSelectTargetFile.TabIndex = 5;
            this.btnSelectTargetFile.Text = "..";
            this.btnSelectTargetFile.UseVisualStyleBackColor = true;
            this.btnSelectTargetFile.Click += new System.EventHandler(this.btnSelectTargetFile_Click);
            // 
            // textTargetFileName
            // 
            this.textTargetFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTargetFileName.Location = new System.Drawing.Point(106, 37);
            this.textTargetFileName.Name = "textTargetFileName";
            this.textTargetFileName.Size = new System.Drawing.Size(635, 20);
            this.textTargetFileName.TabIndex = 4;
            this.textTargetFileName.Text = "d:\\shared\\ABE\\src\\ABE\\Properties\\AssemblyInfo.cs";
            // 
            // lblTargetFileName
            // 
            this.lblTargetFileName.AutoSize = true;
            this.lblTargetFileName.Location = new System.Drawing.Point(16, 40);
            this.lblTargetFileName.Name = "lblTargetFileName";
            this.lblTargetFileName.Size = new System.Drawing.Size(88, 13);
            this.lblTargetFileName.TabIndex = 3;
            this.lblTargetFileName.Text = "Target File Name";
            // 
            // textCurrentVersion
            // 
            this.textCurrentVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCurrentVersion.Location = new System.Drawing.Point(122, 78);
            this.textCurrentVersion.Name = "textCurrentVersion";
            this.textCurrentVersion.Size = new System.Drawing.Size(43, 20);
            this.textCurrentVersion.TabIndex = 7;
            // 
            // textNewVersion
            // 
            this.textNewVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNewVersion.Location = new System.Drawing.Point(357, 81);
            this.textNewVersion.Name = "textNewVersion";
            this.textNewVersion.Size = new System.Drawing.Size(58, 20);
            this.textNewVersion.TabIndex = 9;
            // 
            // lblNewVersion
            // 
            this.lblNewVersion.AutoSize = true;
            this.lblNewVersion.Location = new System.Drawing.Point(284, 84);
            this.lblNewVersion.Name = "lblNewVersion";
            this.lblNewVersion.Size = new System.Drawing.Size(67, 13);
            this.lblNewVersion.TabIndex = 8;
            this.lblNewVersion.Text = "New Version";
            // 
            // btnUpdateVersions
            // 
            this.btnUpdateVersions.Location = new System.Drawing.Point(666, 363);
            this.btnUpdateVersions.Name = "btnUpdateVersions";
            this.btnUpdateVersions.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateVersions.TabIndex = 11;
            this.btnUpdateVersions.Text = "Update";
            this.btnUpdateVersions.UseVisualStyleBackColor = true;
            this.btnUpdateVersions.Click += new System.EventHandler(this.btnFindTargets_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(665, 84);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 12;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnGetVersion
            // 
            this.btnGetVersion.Location = new System.Drawing.Point(171, 78);
            this.btnGetVersion.Name = "btnGetVersion";
            this.btnGetVersion.Size = new System.Drawing.Size(75, 23);
            this.btnGetVersion.TabIndex = 13;
            this.btnGetVersion.Text = "GetVersion";
            this.btnGetVersion.UseVisualStyleBackColor = true;
            this.btnGetVersion.Click += new System.EventHandler(this.btnGetVersion_Click);
            // 
            // rbMatchingVersion
            // 
            this.rbMatchingVersion.AutoSize = true;
            this.rbMatchingVersion.Checked = true;
            this.rbMatchingVersion.Location = new System.Drawing.Point(19, 78);
            this.rbMatchingVersion.Name = "rbMatchingVersion";
            this.rbMatchingVersion.Size = new System.Drawing.Size(97, 17);
            this.rbMatchingVersion.TabIndex = 14;
            this.rbMatchingVersion.TabStop = true;
            this.rbMatchingVersion.Text = "Current Version";
            this.rbMatchingVersion.UseVisualStyleBackColor = true;
            // 
            // rbAnyVersion
            // 
            this.rbAnyVersion.AutoSize = true;
            this.rbAnyVersion.Location = new System.Drawing.Point(19, 101);
            this.rbAnyVersion.Name = "rbAnyVersion";
            this.rbAnyVersion.Size = new System.Drawing.Size(81, 17);
            this.rbAnyVersion.TabIndex = 15;
            this.rbAnyVersion.Text = "Any Version";
            this.rbAnyVersion.UseVisualStyleBackColor = true;
            // 
            // lbVersionFiles
            // 
            this.lbVersionFiles.FormattingEnabled = true;
            this.lbVersionFiles.Location = new System.Drawing.Point(109, 113);
            this.lbVersionFiles.Name = "lbVersionFiles";
            this.lbVersionFiles.Size = new System.Drawing.Size(632, 244);
            this.lbVersionFiles.TabIndex = 16;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(109, 363);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 17;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.rbAnyVersion);
            this.Controls.Add(this.rbMatchingVersion);
            this.Controls.Add(this.btnGetVersion);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnUpdateVersions);
            this.Controls.Add(this.textNewVersion);
            this.Controls.Add(this.lblNewVersion);
            this.Controls.Add(this.textCurrentVersion);
            this.Controls.Add(this.btnSelectTargetFile);
            this.Controls.Add(this.textTargetFileName);
            this.Controls.Add(this.lblTargetFileName);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.textBaseFolder);
            this.Controls.Add(this.lblBaseFolder);
            this.Controls.Add(this.lbVersionFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Update Project Version";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaseFolder;
        private System.Windows.Forms.TextBox textBaseFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnSelectTargetFile;
        private System.Windows.Forms.TextBox textTargetFileName;
        private System.Windows.Forms.Label lblTargetFileName;
        private System.Windows.Forms.TextBox textCurrentVersion;
        private System.Windows.Forms.TextBox textNewVersion;
        private System.Windows.Forms.Label lblNewVersion;
        private System.Windows.Forms.Button btnUpdateVersions;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnGetVersion;
        private System.Windows.Forms.RadioButton rbMatchingVersion;
        private System.Windows.Forms.RadioButton rbAnyVersion;
        private System.Windows.Forms.CheckedListBox lbVersionFiles;
        private System.Windows.Forms.Button btnClearAll;
    }
}


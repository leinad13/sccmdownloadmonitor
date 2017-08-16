namespace SCCM_Download_Monitor
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
            System.Security.SecureString secureString1 = new System.Security.SecureString();
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPrevDownloads = new System.Windows.Forms.TabPage();
            this.dgPreviousDownloads = new System.Windows.Forms.DataGridView();
            this.btnContentToApp = new System.Windows.Forms.Button();
            this.tbReboot = new System.Windows.Forms.TabPage();
            this.btnReboot = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.bgwWMI = new System.ComponentModel.BackgroundWorker();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new SecurePasswordTextBox.SecureTextBox();
            this.chkCBServicing = new System.Windows.Forms.CheckBox();
            this.chkWU = new System.Windows.Forms.CheckBox();
            this.chkCCM = new System.Windows.Forms.CheckBox();
            this.chkCompRen = new System.Windows.Forms.CheckBox();
            this.chkFileRen = new System.Windows.Forms.CheckBox();
            this.lbFileRenames = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPrevDownloads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPreviousDownloads)).BeginInit();
            this.tbReboot.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHostname
            // 
            this.tbHostname.Location = new System.Drawing.Point(82, 6);
            this.tbHostname.Name = "tbHostname";
            this.tbHostname.Size = new System.Drawing.Size(161, 20);
            this.tbHostname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hostname";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(6, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Previous CTM Downloads";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(15, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbLog);
            this.splitContainer1.Size = new System.Drawing.Size(586, 589);
            this.splitContainer1.SplitterDistance = 478;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbPrevDownloads);
            this.tabControl1.Controls.Add(this.tbReboot);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 472);
            this.tabControl1.TabIndex = 9;
            // 
            // tbPrevDownloads
            // 
            this.tbPrevDownloads.Controls.Add(this.dgPreviousDownloads);
            this.tbPrevDownloads.Controls.Add(this.btnContentToApp);
            this.tbPrevDownloads.Controls.Add(this.button1);
            this.tbPrevDownloads.Location = new System.Drawing.Point(4, 22);
            this.tbPrevDownloads.Name = "tbPrevDownloads";
            this.tbPrevDownloads.Padding = new System.Windows.Forms.Padding(3);
            this.tbPrevDownloads.Size = new System.Drawing.Size(572, 446);
            this.tbPrevDownloads.TabIndex = 0;
            this.tbPrevDownloads.Text = "Previous Downloads";
            this.tbPrevDownloads.UseVisualStyleBackColor = true;
            // 
            // dgPreviousDownloads
            // 
            this.dgPreviousDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPreviousDownloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPreviousDownloads.Location = new System.Drawing.Point(9, 6);
            this.dgPreviousDownloads.Name = "dgPreviousDownloads";
            this.dgPreviousDownloads.Size = new System.Drawing.Size(554, 408);
            this.dgPreviousDownloads.TabIndex = 3;
            // 
            // btnContentToApp
            // 
            this.btnContentToApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContentToApp.Enabled = false;
            this.btnContentToApp.Location = new System.Drawing.Point(184, 417);
            this.btnContentToApp.Name = "btnContentToApp";
            this.btnContentToApp.Size = new System.Drawing.Size(132, 23);
            this.btnContentToApp.TabIndex = 1;
            this.btnContentToApp.Text = "Find Application Names";
            this.btnContentToApp.UseVisualStyleBackColor = true;
            this.btnContentToApp.Click += new System.EventHandler(this.btnContentToApp_Click);
            // 
            // tbReboot
            // 
            this.tbReboot.Controls.Add(this.lbFileRenames);
            this.tbReboot.Controls.Add(this.chkFileRen);
            this.tbReboot.Controls.Add(this.chkCompRen);
            this.tbReboot.Controls.Add(this.chkCCM);
            this.tbReboot.Controls.Add(this.chkWU);
            this.tbReboot.Controls.Add(this.chkCBServicing);
            this.tbReboot.Controls.Add(this.btnReboot);
            this.tbReboot.Location = new System.Drawing.Point(4, 22);
            this.tbReboot.Name = "tbReboot";
            this.tbReboot.Padding = new System.Windows.Forms.Padding(3);
            this.tbReboot.Size = new System.Drawing.Size(572, 446);
            this.tbReboot.TabIndex = 1;
            this.tbReboot.Text = "Reboot?";
            this.tbReboot.UseVisualStyleBackColor = true;
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(6, 6);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(168, 23);
            this.btnReboot.TabIndex = 0;
            this.btnReboot.Text = "Check for Pending Reboot";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(3, 3);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(580, 95);
            this.lbLog.TabIndex = 0;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(82, 32);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(161, 20);
            this.tbUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(308, 32);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.SecureText = secureString1;
            this.tbPassword.Size = new System.Drawing.Size(161, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // chkCBServicing
            // 
            this.chkCBServicing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCBServicing.Enabled = false;
            this.chkCBServicing.Location = new System.Drawing.Point(7, 35);
            this.chkCBServicing.Name = "chkCBServicing";
            this.chkCBServicing.Size = new System.Drawing.Size(104, 24);
            this.chkCBServicing.TabIndex = 1;
            this.chkCBServicing.Text = "CBServicing";
            this.chkCBServicing.UseVisualStyleBackColor = true;
            // 
            // chkWU
            // 
            this.chkWU.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkWU.Enabled = false;
            this.chkWU.Location = new System.Drawing.Point(6, 65);
            this.chkWU.Name = "chkWU";
            this.chkWU.Size = new System.Drawing.Size(105, 22);
            this.chkWU.TabIndex = 2;
            this.chkWU.Text = "WindowsUpdate";
            this.chkWU.UseVisualStyleBackColor = true;
            // 
            // chkCCM
            // 
            this.chkCCM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCCM.Enabled = false;
            this.chkCCM.Location = new System.Drawing.Point(6, 93);
            this.chkCCM.Name = "chkCCM";
            this.chkCCM.Size = new System.Drawing.Size(105, 22);
            this.chkCCM.TabIndex = 3;
            this.chkCCM.Text = "CCMClientSDK";
            this.chkCCM.UseVisualStyleBackColor = true;
            // 
            // chkCompRen
            // 
            this.chkCompRen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCompRen.Enabled = false;
            this.chkCompRen.Location = new System.Drawing.Point(117, 35);
            this.chkCompRen.Name = "chkCompRen";
            this.chkCompRen.Size = new System.Drawing.Size(105, 22);
            this.chkCompRen.TabIndex = 4;
            this.chkCompRen.Text = "CompRename";
            this.chkCompRen.UseVisualStyleBackColor = true;
            // 
            // chkFileRen
            // 
            this.chkFileRen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFileRen.Enabled = false;
            this.chkFileRen.Location = new System.Drawing.Point(117, 63);
            this.chkFileRen.Name = "chkFileRen";
            this.chkFileRen.Size = new System.Drawing.Size(105, 22);
            this.chkFileRen.TabIndex = 5;
            this.chkFileRen.Text = "File Renames";
            this.chkFileRen.UseVisualStyleBackColor = true;
            // 
            // lbFileRenames
            // 
            this.lbFileRenames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFileRenames.FormattingEnabled = true;
            this.lbFileRenames.Location = new System.Drawing.Point(7, 121);
            this.lbFileRenames.Name = "lbFileRenames";
            this.lbFileRenames.Size = new System.Drawing.Size(559, 316);
            this.lbFileRenames.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 659);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHostname);
            this.Name = "Form1";
            this.Text = "SCCM Download Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbPrevDownloads.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPreviousDownloads)).EndInit();
            this.tbReboot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHostname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.ComponentModel.BackgroundWorker bgwWMI;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private SecurePasswordTextBox.SecureTextBox tbPassword;
        private System.Windows.Forms.Button btnContentToApp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPrevDownloads;
        private System.Windows.Forms.DataGridView dgPreviousDownloads;
        private System.Windows.Forms.TabPage tbReboot;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.CheckBox chkCBServicing;
        private System.Windows.Forms.CheckBox chkFileRen;
        private System.Windows.Forms.CheckBox chkCompRen;
        private System.Windows.Forms.CheckBox chkCCM;
        private System.Windows.Forms.CheckBox chkWU;
        private System.Windows.Forms.ListBox lbFileRenames;
    }
}


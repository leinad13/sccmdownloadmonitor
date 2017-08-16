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
            System.Security.SecureString secureString2 = new System.Security.SecureString();
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnContentToApp = new System.Windows.Forms.Button();
            this.bgwWMI = new System.ComponentModel.BackgroundWorker();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new SecurePasswordTextBox.SecureTextBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPrevDownloads = new System.Windows.Forms.TabPage();
            this.tbReboot = new System.Windows.Forms.TabPage();
            this.dgPreviousDownloads = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPrevDownloads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPreviousDownloads)).BeginInit();
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
            this.tbPassword.SecureText = secureString2;
            this.tbPassword.Size = new System.Drawing.Size(161, 20);
            this.tbPassword.TabIndex = 8;
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
            // tbReboot
            // 
            this.tbReboot.Location = new System.Drawing.Point(4, 22);
            this.tbReboot.Name = "tbReboot";
            this.tbReboot.Padding = new System.Windows.Forms.Padding(3);
            this.tbReboot.Size = new System.Drawing.Size(572, 446);
            this.tbReboot.TabIndex = 1;
            this.tbReboot.Text = "Reboot?";
            this.tbReboot.UseVisualStyleBackColor = true;
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
    }
}


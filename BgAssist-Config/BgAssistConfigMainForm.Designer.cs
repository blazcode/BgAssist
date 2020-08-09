﻿namespace BgAssist_Config
{
    partial class BgAssistConfigMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BgAssistConfigMainForm));
            this.lblTimer = new System.Windows.Forms.Label();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSetConfigPath = new System.Windows.Forms.Button();
            this.txtBgInfoConfigPath = new System.Windows.Forms.TextBox();
            this.lblBgInfoPath = new System.Windows.Forms.Label();
            this.txtBgInfoPath = new System.Windows.Forms.TextBox();
            this.btnSetBgInfoPath = new System.Windows.Forms.Button();
            this.checkBoxPopup = new System.Windows.Forms.CheckBox();
            this.checkBoxSilent = new System.Windows.Forms.CheckBox();
            this.checkBoxTaskbar = new System.Windows.Forms.CheckBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.checkBoxRTF = new System.Windows.Forms.CheckBox();
            this.groupBoxBgInfoOptions = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.groupBoxBgInfoOptions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(6, 52);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(33, 13);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Timer";
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.AccessibleDescription = "";
            this.numericUpDownTimer.Location = new System.Drawing.Point(45, 50);
            this.numericUpDownTimer.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownTimer.TabIndex = 1;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 26);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(62, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Config Path";
            // 
            // btnSetConfigPath
            // 
            this.btnSetConfigPath.Location = new System.Drawing.Point(378, 21);
            this.btnSetConfigPath.Name = "btnSetConfigPath";
            this.btnSetConfigPath.Size = new System.Drawing.Size(75, 23);
            this.btnSetConfigPath.TabIndex = 3;
            this.btnSetConfigPath.Text = "Browse";
            this.btnSetConfigPath.UseVisualStyleBackColor = true;
            this.btnSetConfigPath.Click += new System.EventHandler(this.btnSetConfigPath_Click);
            // 
            // txtBgInfoConfigPath
            // 
            this.txtBgInfoConfigPath.Enabled = false;
            this.txtBgInfoConfigPath.Location = new System.Drawing.Point(74, 23);
            this.txtBgInfoConfigPath.Name = "txtBgInfoConfigPath";
            this.txtBgInfoConfigPath.Size = new System.Drawing.Size(298, 20);
            this.txtBgInfoConfigPath.TabIndex = 4;
            // 
            // lblBgInfoPath
            // 
            this.lblBgInfoPath.AutoSize = true;
            this.lblBgInfoPath.Location = new System.Drawing.Point(12, 38);
            this.lblBgInfoPath.Name = "lblBgInfoPath";
            this.lblBgInfoPath.Size = new System.Drawing.Size(63, 13);
            this.lblBgInfoPath.TabIndex = 5;
            this.lblBgInfoPath.Text = "BgInfo Path";
            // 
            // txtBgInfoPath
            // 
            this.txtBgInfoPath.Enabled = false;
            this.txtBgInfoPath.Location = new System.Drawing.Point(81, 35);
            this.txtBgInfoPath.Name = "txtBgInfoPath";
            this.txtBgInfoPath.Size = new System.Drawing.Size(296, 20);
            this.txtBgInfoPath.TabIndex = 6;
            // 
            // btnSetBgInfoPath
            // 
            this.btnSetBgInfoPath.Location = new System.Drawing.Point(384, 33);
            this.btnSetBgInfoPath.Name = "btnSetBgInfoPath";
            this.btnSetBgInfoPath.Size = new System.Drawing.Size(75, 23);
            this.btnSetBgInfoPath.TabIndex = 7;
            this.btnSetBgInfoPath.Text = "Browse";
            this.btnSetBgInfoPath.UseVisualStyleBackColor = true;
            this.btnSetBgInfoPath.Click += new System.EventHandler(this.btnSetBgInfoPath_Click);
            // 
            // checkBoxPopup
            // 
            this.checkBoxPopup.AutoSize = true;
            this.checkBoxPopup.Location = new System.Drawing.Point(9, 76);
            this.checkBoxPopup.Name = "checkBoxPopup";
            this.checkBoxPopup.Size = new System.Drawing.Size(57, 17);
            this.checkBoxPopup.TabIndex = 9;
            this.checkBoxPopup.Text = "Popup";
            this.checkBoxPopup.UseVisualStyleBackColor = true;
            // 
            // checkBoxSilent
            // 
            this.checkBoxSilent.AutoSize = true;
            this.checkBoxSilent.Location = new System.Drawing.Point(8, 100);
            this.checkBoxSilent.Name = "checkBoxSilent";
            this.checkBoxSilent.Size = new System.Drawing.Size(52, 17);
            this.checkBoxSilent.TabIndex = 10;
            this.checkBoxSilent.Text = "Silent";
            this.checkBoxSilent.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaskbar
            // 
            this.checkBoxTaskbar.AutoSize = true;
            this.checkBoxTaskbar.Location = new System.Drawing.Point(8, 124);
            this.checkBoxTaskbar.Name = "checkBoxTaskbar";
            this.checkBoxTaskbar.Size = new System.Drawing.Size(65, 17);
            this.checkBoxTaskbar.TabIndex = 11;
            this.checkBoxTaskbar.Text = "Taskbar";
            this.checkBoxTaskbar.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(9, 148);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(37, 17);
            this.checkBoxAll.TabIndex = 12;
            this.checkBoxAll.Text = "All";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Location = new System.Drawing.Point(8, 172);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(44, 17);
            this.checkBoxLog.TabIndex = 13;
            this.checkBoxLog.Text = "Log";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            // 
            // checkBoxRTF
            // 
            this.checkBoxRTF.AutoSize = true;
            this.checkBoxRTF.Location = new System.Drawing.Point(8, 196);
            this.checkBoxRTF.Name = "checkBoxRTF";
            this.checkBoxRTF.Size = new System.Drawing.Size(47, 17);
            this.checkBoxRTF.TabIndex = 14;
            this.checkBoxRTF.Text = "RTF";
            this.checkBoxRTF.UseVisualStyleBackColor = true;
            // 
            // groupBoxBgInfoOptions
            // 
            this.groupBoxBgInfoOptions.Controls.Add(this.lblPath);
            this.groupBoxBgInfoOptions.Controls.Add(this.checkBoxRTF);
            this.groupBoxBgInfoOptions.Controls.Add(this.btnSetConfigPath);
            this.groupBoxBgInfoOptions.Controls.Add(this.checkBoxLog);
            this.groupBoxBgInfoOptions.Controls.Add(this.txtBgInfoConfigPath);
            this.groupBoxBgInfoOptions.Controls.Add(this.checkBoxAll);
            this.groupBoxBgInfoOptions.Controls.Add(this.lblTimer);
            this.groupBoxBgInfoOptions.Controls.Add(this.checkBoxTaskbar);
            this.groupBoxBgInfoOptions.Controls.Add(this.numericUpDownTimer);
            this.groupBoxBgInfoOptions.Controls.Add(this.checkBoxSilent);
            this.groupBoxBgInfoOptions.Controls.Add(this.checkBoxPopup);
            this.groupBoxBgInfoOptions.Location = new System.Drawing.Point(12, 76);
            this.groupBoxBgInfoOptions.Name = "groupBoxBgInfoOptions";
            this.groupBoxBgInfoOptions.Size = new System.Drawing.Size(467, 223);
            this.groupBoxBgInfoOptions.TabIndex = 15;
            this.groupBoxBgInfoOptions.TabStop = false;
            this.groupBoxBgInfoOptions.Text = "BgInfo Options";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 310);
            this.Controls.Add(this.groupBoxBgInfoOptions);
            this.Controls.Add(this.btnSetBgInfoPath);
            this.Controls.Add(this.txtBgInfoPath);
            this.Controls.Add(this.lblBgInfoPath);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BgAssist Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.groupBoxBgInfoOptions.ResumeLayout(false);
            this.groupBoxBgInfoOptions.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnSetConfigPath;
        private System.Windows.Forms.TextBox txtBgInfoConfigPath;
        private System.Windows.Forms.Label lblBgInfoPath;
        private System.Windows.Forms.TextBox txtBgInfoPath;
        private System.Windows.Forms.Button btnSetBgInfoPath;
        private System.Windows.Forms.CheckBox checkBoxPopup;
        private System.Windows.Forms.CheckBox checkBoxSilent;
        private System.Windows.Forms.CheckBox checkBoxTaskbar;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.CheckBox checkBoxRTF;
        private System.Windows.Forms.GroupBox groupBoxBgInfoOptions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

namespace BgAssist
{
    partial class BgAssist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BgAssist));
            this.lblBginfoPath = new System.Windows.Forms.Label();
            this.txtBginfoPath = new System.Windows.Forms.TextBox();
            this.lblBginfoArgs = new System.Windows.Forms.Label();
            this.txtBginfoArgs = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnViewLog = new System.Windows.Forms.Button();
            this.comboBoxColorPicker = new System.Windows.Forms.ComboBox();
            this.lblColorPicker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBginfoPath
            // 
            this.lblBginfoPath.AutoSize = true;
            this.lblBginfoPath.Location = new System.Drawing.Point(5, 15);
            this.lblBginfoPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBginfoPath.Name = "lblBginfoPath";
            this.lblBginfoPath.Size = new System.Drawing.Size(67, 13);
            this.lblBginfoPath.TabIndex = 0;
            this.lblBginfoPath.Text = "BGinfo Path:";
            // 
            // txtBginfoPath
            // 
            this.txtBginfoPath.Enabled = false;
            this.txtBginfoPath.Location = new System.Drawing.Point(73, 11);
            this.txtBginfoPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtBginfoPath.Name = "txtBginfoPath";
            this.txtBginfoPath.Size = new System.Drawing.Size(477, 20);
            this.txtBginfoPath.TabIndex = 1;
            // 
            // lblBginfoArgs
            // 
            this.lblBginfoArgs.AutoSize = true;
            this.lblBginfoArgs.Location = new System.Drawing.Point(5, 37);
            this.lblBginfoArgs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBginfoArgs.Name = "lblBginfoArgs";
            this.lblBginfoArgs.Size = new System.Drawing.Size(66, 13);
            this.lblBginfoArgs.TabIndex = 2;
            this.lblBginfoArgs.Text = "BGinfo Args:";
            // 
            // txtBginfoArgs
            // 
            this.txtBginfoArgs.Enabled = false;
            this.txtBginfoArgs.Location = new System.Drawing.Point(73, 35);
            this.txtBginfoArgs.Margin = new System.Windows.Forms.Padding(2);
            this.txtBginfoArgs.Name = "txtBginfoArgs";
            this.txtBginfoArgs.Size = new System.Drawing.Size(477, 20);
            this.txtBginfoArgs.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(436, 58);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 21);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh Background";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Desktop Background";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(365, 58);
            this.btnViewLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(67, 21);
            this.btnViewLog.TabIndex = 7;
            this.btnViewLog.Text = "View Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // comboBoxColorPicker
            // 
            this.comboBoxColorPicker.FormattingEnabled = true;
            this.comboBoxColorPicker.Location = new System.Drawing.Point(119, 58);
            this.comboBoxColorPicker.Name = "comboBoxColorPicker";
            this.comboBoxColorPicker.Size = new System.Drawing.Size(155, 21);
            this.comboBoxColorPicker.TabIndex = 8;
            this.comboBoxColorPicker.SelectedValueChanged += new System.EventHandler(this.comboBoxColorPicker_SelectedValueChanged);
            // 
            // lblColorPicker
            // 
            this.lblColorPicker.AutoSize = true;
            this.lblColorPicker.Location = new System.Drawing.Point(3, 61);
            this.lblColorPicker.Name = "lblColorPicker";
            this.lblColorPicker.Size = new System.Drawing.Size(115, 13);
            this.lblColorPicker.TabIndex = 9;
            this.lblColorPicker.Text = "Background Template:";
            // 
            // BgAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 87);
            this.Controls.Add(this.lblColorPicker);
            this.Controls.Add(this.comboBoxColorPicker);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtBginfoArgs);
            this.Controls.Add(this.lblBginfoArgs);
            this.Controls.Add(this.txtBginfoPath);
            this.Controls.Add(this.lblBginfoPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BgAssist";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Background";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BgAssist_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.BgAssist_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBginfoPath;
        private System.Windows.Forms.TextBox txtBginfoPath;
        private System.Windows.Forms.Label lblBginfoArgs;
        private System.Windows.Forms.TextBox txtBginfoArgs;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.ComboBox comboBoxColorPicker;
        private System.Windows.Forms.Label lblColorPicker;
    }
}


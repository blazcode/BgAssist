namespace Wallpaper_Refresher
{
    partial class WallpaperRefresher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WallpaperRefresher));
            this.lblBginfoPath = new System.Windows.Forms.Label();
            this.txtBginfoPath = new System.Windows.Forms.TextBox();
            this.lblBginfoArgs = new System.Windows.Forms.Label();
            this.txtBginfoArgs = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnViewLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBginfoPath
            // 
            this.lblBginfoPath.AutoSize = true;
            this.lblBginfoPath.Location = new System.Drawing.Point(13, 18);
            this.lblBginfoPath.Name = "lblBginfoPath";
            this.lblBginfoPath.Size = new System.Drawing.Size(100, 20);
            this.lblBginfoPath.TabIndex = 0;
            this.lblBginfoPath.Text = "BGinfo Path:";
            // 
            // txtBginfoPath
            // 
            this.txtBginfoPath.Enabled = false;
            this.txtBginfoPath.Location = new System.Drawing.Point(115, 12);
            this.txtBginfoPath.Name = "txtBginfoPath";
            this.txtBginfoPath.Size = new System.Drawing.Size(478, 26);
            this.txtBginfoPath.TabIndex = 1;
            // 
            // lblBginfoArgs
            // 
            this.lblBginfoArgs.AutoSize = true;
            this.lblBginfoArgs.Location = new System.Drawing.Point(13, 52);
            this.lblBginfoArgs.Name = "lblBginfoArgs";
            this.lblBginfoArgs.Size = new System.Drawing.Size(100, 20);
            this.lblBginfoArgs.TabIndex = 2;
            this.lblBginfoArgs.Text = "BGinfo Args:";
            // 
            // txtBginfoArgs
            // 
            this.txtBginfoArgs.Enabled = false;
            this.txtBginfoArgs.Location = new System.Drawing.Point(115, 49);
            this.txtBginfoArgs.Name = "txtBginfoArgs";
            this.txtBginfoArgs.Size = new System.Drawing.Size(478, 26);
            this.txtBginfoArgs.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(515, 81);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 33);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Wallpaper Refresher";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(409, 81);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(100, 33);
            this.btnViewLog.TabIndex = 7;
            this.btnViewLog.Text = "View Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // WallpaperRefresher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 129);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtBginfoArgs);
            this.Controls.Add(this.lblBginfoArgs);
            this.Controls.Add(this.txtBginfoPath);
            this.Controls.Add(this.lblBginfoPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WallpaperRefresher";
            this.ShowInTaskbar = false;
            this.Text = "Wallpaper Refresher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WallpaperRefresher_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.WallpaperRefresher_Shown);
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
    }
}


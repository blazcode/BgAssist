using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BgAssist_Config
{
    public partial class BgAssistConfigMainForm : Form
    {
        public BgAssistConfigMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadAppConfig();
        }

        private void btnSetConfigPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogConfigPath = new OpenFileDialog
            {
                Title = "Set BgInfo Configuration File Path",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "BgInfo Configuration Files (*.bgi)|"
            };

            openFileDialogConfigPath.FileOk += delegate (object s, CancelEventArgs ev)
            {
                string filename = openFileDialogConfigPath.SafeFileName;
                string extension = Path.GetExtension(filename).ToUpper();

                if (extension != ".BGI")
                {
                    MessageBox.Show("Must choose *.bgi");
                    ev.Cancel = true;
                }
            };

            if (openFileDialogConfigPath.ShowDialog() == DialogResult.OK)
            {
                txtBgInfoConfigPath.Text = openFileDialogConfigPath.FileName;
            }
        }

        private void btnSetBgInfoPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogBgInfo = new OpenFileDialog
            {
                Title = "Set BgInfo64 Path",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "BgInfo64 (Bginfo64.exe)|"
            };

            openFileDialogBgInfo.FileOk += delegate (object s, CancelEventArgs ev)
            {
                if (openFileDialogBgInfo.SafeFileName != "Bginfo64.exe")
                {
                    MessageBox.Show("Must choose Bginfo64.exe");
                    ev.Cancel = true;
                }
            };

            if (openFileDialogBgInfo.ShowDialog() == DialogResult.OK)
            {
                txtBgInfoPath.Text = openFileDialogBgInfo.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadAppConfig();
        }

        private void loadAppConfig()
        {
            /* BgInfo Options */
            txtBgInfoPath.Text = ConfigurationManager.AppSettings["BgInfoPath"];
            txtBgInfoConfigPath.Text = ConfigurationManager.AppSettings["BgInfoConfigPath"];
            numericUpDownTimer.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["BgInfoTimer"]);
            checkBoxPopup.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BgInfoPopup"]);
            checkBoxSilent.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BgInfoSilent"]);
            checkBoxTaskbar.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BgInfoTaskbar"]);
            checkBoxLog.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BgInfoLog"]);
            checkBoxRTF.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BgInfoRTF"]);

            /* BgAssist Options */
            checkBoxHideSystemTrayIcon.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["BgAssistHideSystemTrayIcon"]);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            
            /* BgInfo Options */
            config.AppSettings.Settings.Remove("BgInfoPath");
            config.AppSettings.Settings.Add("BgInfoPath", txtBgInfoPath.Text);

            config.AppSettings.Settings.Remove("BgInfoConfigPath");
            config.AppSettings.Settings.Add("BgInfoConfigPath", txtBgInfoConfigPath.Text);

            config.AppSettings.Settings.Remove("BgInfoTimer");
            config.AppSettings.Settings.Add("BgInfoTimer", numericUpDownTimer.Value.ToString());

            config.AppSettings.Settings.Remove("BgInfoPopup");
            config.AppSettings.Settings.Add("BgInfoPopup", checkBoxPopup.Checked.ToString());

            config.AppSettings.Settings.Remove("BgInfoSilent");
            config.AppSettings.Settings.Add("BgInfoSilent", checkBoxSilent.Checked.ToString());

            config.AppSettings.Settings.Remove("BgInfoTaskbar");
            config.AppSettings.Settings.Add("BgInfoTaskbar", checkBoxTaskbar.Checked.ToString());

            config.AppSettings.Settings.Remove("BgInfoLog");
            config.AppSettings.Settings.Add("BgInfoLog", checkBoxLog.Checked.ToString());

            config.AppSettings.Settings.Remove("BgInfoRTF");
            config.AppSettings.Settings.Add("BgInfoRTF", checkBoxRTF.Checked.ToString());

            /* BgAssist Options */
            config.AppSettings.Settings.Remove("BgAssistHideSystemTrayIcon");
            config.AppSettings.Settings.Add("BgAssistHideSystemTrayIcon", checkBoxHideSystemTrayIcon.Checked.ToString());

            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

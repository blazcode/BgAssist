﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using NLog;
using System.IO;

namespace Wallpaper_Refresher
{
    public partial class WallpaperRefresher : Form
    {
        public WallpaperRefresher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Fire up logging
            Logger logger = LogManager.GetLogger("fileLogger");
            logger.Info("Wallpaper Refresher started.");

            //Register event listeners
            SystemEvents.DisplaySettingsChanging += SystemEvents_DisplaySettingsChanging;
            SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;

            //Validate BGinfo64.exe and .bgi configuration file
            string bginfoPath = ConfigurationManager.AppSettings.Get("BGinfoPath");
            string bginfoArgs = ConfigurationManager.AppSettings.Get("BGinfoArgs");

            try
            {
                if (File.Exists(bginfoPath + "\\BGinfo64.exe"))
                {
                    logger.Info("BGinfo64 executable found in configured path.");

                    //Set form text field value
                    txtBginfoPath.Text = bginfoPath;
                } else
                {
                    logger.Info("BGinfo64 executable not found in configured path!");
                    txtBginfoPath.Text = "Not Found!";
                }
            } catch
            {
                logger.Error("Error locating Bginfo64.exe in configured path! ");
            }

            
            txtBginfoArgs.Text = bginfoArgs;
        }

        static void SystemEvents_DisplaySettingsChanging(object sender, EventArgs e)
        {
            //Nothing to do here, but could be handy
        }

        static void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            Logger logger = LogManager.GetLogger("fileLogger");

            try
            {
                string bginfoPath = ConfigurationManager.AppSettings.Get("BGinfoPath");

                if (File.Exists(bginfoPath + "\\BGinfo64.exe"))
                {
                    Process.Start(ConfigurationManager.AppSettings.Get("BGinfoPath"), ConfigurationManager.AppSettings.Get("BGinfoArgs"));
                    logger.Info("Display settings change triggered wallpaper refresh.");
                } else
                {
                    logger.Info("Display settings change triggered wallpaper refresh but couldn't be completed due to missing BGinfo executable.");
                }
            }
            catch
            {
                logger.Error("Display settings change triggered wallpaper refresh, but encountred an error...");
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Logger logger = LogManager.GetLogger("fileLogger");

            try
            {
                Process.Start(ConfigurationManager.AppSettings.Get("BGinfoPath" + "\\Bginfo64.exe"), ConfigurationManager.AppSettings.Get("BGinfoArgs"));
                logger.Info("User manually triggered wallpaper refresh.");
            }
            catch
            {
                logger.Error("Error manually refreshing wallpaper! ");
            }
        }

        private void WallpaperRefresher_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            try
            {
                string logPath = Environment.GetEnvironmentVariable("LocalAppData") + "\\WallpaperRefresher-Log.txt";
                Process.Start("notepad.exe",logPath);
            } catch
            {

            }
        }

        private void WallpaperRefresher_Shown(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
// Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 03-29-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-14-2020 ***********************************************************************
// <copyright file="MainForm.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************

using PathFinder.Common;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PathFinder
{
    /// <summary>
    /// Class MainForm. Implements the <see cref="System.Windows.Forms.Form"/>
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form"/>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the ffxiprocess.
        /// </summary>
        /// <value>The ffxiprocess.</value>
        public ffxiProcess ffxiprocess { get; set; }

        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        /// <value>The logger.</value>
        public Log Logger { get; set; }

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <value>The client.</value>
        private WebClient Client { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            try
            {
                InitializeComponent();
                Logger = new Log();
                ffxiprocess = new ffxiProcess(this.Logger);
                Client = new WebClient();
                Check();
            }
            catch (Exception ex)
            {
                Logger.AddDebugText(CheckedItemsRTB, ex.ToString());
                Logger.LogFile(ex.Message, FindForm().Name);
            }
        }

        /// <summary>
        /// Checks this instance.
        /// </summary>
        public void Check()
        {
            try
            {
                if (DoWeHaveAllNeededFiles())
                {
                    ffxiprocess.GetProcess();
                }
            }
            catch (Exception ex)
            {
                Logger.AddDebugText(CheckedItemsRTB, ex.ToString());
            }
        }

        /// <summary>
        /// Does the we have all needed files.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool DoWeHaveAllNeededFiles()
        {
            try
            {
                string NetVersion = Environment.Version.ToString();
                Logger.AddDebugText(CheckedItemsRTB, string.Format(@".NetFramework v  = ({0})", NetVersion));
                if (!NetVersion.Contains("4."))
                {
                    Logger.AddDebugText(CheckedItemsRTB, "Please Update your .Net framework, https://www.microsoft.com/en-us/download/details.aspx?id=53344");
                    return false;
                }

                if (File.Exists("EliteAPI.dll"))
                {
                    FileVersionInfo EliteAPIVersion = FileVersionInfo.GetVersionInfo("EliteAPI.dll");
                    Logger.AddDebugText(CheckedItemsRTB, string.Format(@"EliteAPI Found: Version: ({0})", EliteAPIVersion.FileVersion));
                }
                if (!File.Exists("EliteAPI.dll"))
                {
                    Logger.AddDebugText(CheckedItemsRTB, string.Format(@"EliteAPI Missing"));
                    Logger.AddDebugText(CheckedItemsRTB, "Getting Latest EliteAPI.dll");
                    Client.DownloadFile("http://ext.elitemmonetwork.com/downloads/eliteapi/EliteAPI.dll", "EliteAPI.dll");
                }
                if (File.Exists("FFXINAV.dll"))
                {
                    FileVersionInfo FFXINAVversion = FileVersionInfo.GetVersionInfo("FFXINAV.dll");
                    Logger.AddDebugText(CheckedItemsRTB, string.Format(@"FFXINAV.dll Found: Version: ({0})", FFXINAVversion.FileVersion));
                }
                else if (!File.Exists("FFXINAV.dll"))
                {
                    Logger.AddDebugText(CheckedItemsRTB, @"FFXINAV.dll is missing");
                }

                if (File.Exists("EliteMMO.API.dll"))
                {
                    FileVersionInfo EliteAPIVersion = FileVersionInfo.GetVersionInfo("EliteMMO.API.dll");
                    Logger.AddDebugText(CheckedItemsRTB, string.Format(@"EliteMMO.API Found: Version: ({0})", EliteAPIVersion.FileVersion));
                }
                else if (!File.Exists("EliteMMO.API.dll"))
                {
                    Logger.AddDebugText(CheckedItemsRTB, "EliteMMO.API MISSING");
                    Logger.AddDebugText(CheckedItemsRTB, "Getting Latest EliteMMO.API.dll");
                    Client.DownloadFile("http://ext.elitemmonetwork.com/downloads/elitemmo_api/EliteMMO.API.dll", "EliteMMO.API.dll");
                }

                Logger.AddDebugText(CheckedItemsRTB, @"Finished checking files");
            }
            catch (Exception ex)
            {
                Logger.LogFile(ex.Message, "CheckNeededFiles");
                Logger.AddDebugText(CheckedItemsRTB, ex.ToString());
                return false;
            }
            Client.Dispose();
            return true;
        }

        /// <summary>
        /// Handles the Click event of the NextBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ffxiprocess._CharacterDictionary.Count < 1 && NextBtn.Text == "Refresh")
                {
                    NextBtn.Text = "Next";
                    ffxiprocess.GetProcess();
                }
                if (ffxiprocess._CharacterDictionary.Count > 0 && NextBtn.Text == "Next")
                {
                    ffxiprocess.AddToons();
                    NextBtn.Visible = false;
                    CheckedItemsRTB.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Logger.LogFile(ex.Message, FindForm().Name);
            }
        }

        /// <summary>
        /// Handles the Click event of the onTopToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void onTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onTopToolStripMenuItem.CheckState == System.Windows.Forms.CheckState.Checked)
            {
                MainForm.ActiveForm.TopMost = true;
            }
            else
                MainForm.ActiveForm.TopMost = false;
        }

        /// <summary>
        /// Handles the Click event of the transparentToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void transparentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transparentToolStripMenuItem.CheckState == System.Windows.Forms.CheckState.Checked)
            {
                MainForm.ActiveForm.Opacity = 0.50;
            }
            else
                MainForm.ActiveForm.Opacity = 1;
        }

        /// <summary>
        /// Handles the Click event of the settingsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
// Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-14-2020 ***********************************************************************
// <copyright file="ToonControl.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using EliteMMO.API;
using PathFinder.Characters;
using PathFinder.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace PathFinder
{
    /// <summary>
    /// Class ToonControl. Implements the <see cref="System.Windows.Forms.UserControl"/>
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl"/>
    public partial class ToonControl : UserControl
    {
        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>The character.</value>
        public Character Character { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToonControl"/> class.
        /// </summary>
        /// <param name="mf">The mf.</param>
        /// <param name="chars">The chars.</param>
        /// <param name="api">The API.</param>
        public ToonControl(Log logger, Dictionary<string, EliteAPI> chars, EliteAPI api)
        {
            InitializeComponent();
            Character = new Character(logger, this, chars, api);
        }

        /// <summary>
        /// Handles the TextChanged event of the rtbDebug control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rtbDebug_TextChanged(object sender, EventArgs e)
        {
            rtbDebug.SelectionStart = rtbDebug.Text.Length;
            rtbDebug.ScrollToCaret();
        }

        /// <summary>
        /// Gets or sets the selected point.
        /// </summary>
        /// <value>The selected point.</value>
        public string SelectedPoint { get; set; }

        /// <summary>
        /// Handles the Click event of the button13 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button13_Click(object sender, EventArgs e)
        {
            Character.Tasks.NavTask.Options.Ppoint.ID = Character.Api.Player.ZoneId;
            Character.Tasks.NavTask.Options.Ppoint.Name = PointNametb.Text;
            Character.Tasks.NavTask.Options.Ppoint.X = Character.Api.Player.X;
            Character.Tasks.NavTask.Options.Ppoint.Y = Character.Api.Player.Y;
            Character.Tasks.NavTask.Options.Ppoint.Z = Character.Api.Player.Z;
            Character.Tasks.NavTask.Options.Points.Add(Character.Tasks.NavTask.Options.Ppoint);
            PointsComboBox.Items.Add(Character.Tasks.NavTask.Options.Ppoint.Name);
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"{0} Added to Points of interest list", Character.Tasks.NavTask.Options.Ppoint.Name));
            PointsComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles the Click event of the saveHitPointsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveHitPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character.SavePointsOfInterest();
        }

        /// <summary>
        /// Handles the Click event of the loadHitPointToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void loadHitPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character.LoadPointsOfInterest();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the PointsComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PointsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPoint = PointsComboBox.SelectedItem.ToString();
            Character.Api.AutoFollow.IsAutoFollowing = false;
            Character.FFxiNAV.Waypoints.Clear();
            Character.Tasks.NavTask.Options.WayPoints.Clear();
            foreach (var item in Character.Tasks.NavTask.Options.Points)
            {
                if (item.ID == Character.Api.Player.ZoneId && item.Name == SelectedPoint)
                {
                    Character.Logger.AddDebugText(rtbDebug, string.Format(@"Point Set {0} x = {1} z = {2}",
                    item.Name, item.X.ToString(), item.Z.ToString()));
                    Character.Tasks.NavTask.Options.KeepMovingStartPosi.X = Character.Api.Player.X;
                    Character.Tasks.NavTask.Options.KeepMovingStartPosi.Y = Character.Api.Player.Y;
                    Character.Tasks.NavTask.Options.KeepMovingStartPosi.Z = Character.Api.Player.Z;
                    Character.Tasks.NavTask.Options.Posi.X = item.X;
                    Character.Tasks.NavTask.Options.Posi.Y = item.Y;
                    Character.Tasks.NavTask.Options.Posi.Z = item.Z;
                    SelectedPoint = item.Name;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the RunBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RunBtn_Click(object sender, EventArgs e)
        {
            if (RunBtn.Text == "Start" && !Character.Tasks.NavTask.IsBusy)
            {
                RunBtn.Text = "Stop";
                Thread.Sleep(100);
                Character.Tasks.NavTask.Start();
                Character.Tasks.NavTask.Options.StopRunning = false;
            }
            else if (RunBtn.Text == "Stop")
            {
                Character.Tasks.NavTask.Stop();
                Character.Navi.Reset();
                Character.Tasks.Stop();
                Character.FFxiNAV.Waypoints.Clear();
                Character.Tasks.NavTask.Options.WayPoints.Clear();
                Character.Tasks.NavTask.Options.StopRunning = true;
                Character.Api.AutoFollow.IsAutoFollowing = false;
                // Character.Api.AutoFollow.SetAutoFollowCoords(0, 0, 0);
                RunBtn.Text = "Start";
                Thread.Sleep(200);
                Character.Navi.Reset();
            }
            else if (RunBtn.Text == "Start" && Character.Tasks.NavTask.IsBusy)
            {
                RunBtn.Text = "Stop";
                Thread.Sleep(100);
                Character.Tasks.NavTask.Stop();
                Character.Tasks.Stop();
                Character.Api.AutoFollow.SetAutoFollowCoords(0, 0, 0);
                Character.FFxiNAV.Waypoints.Clear();
                Character.Tasks.NavTask.Options.WayPoints.Clear();
                Character.Tasks.NavTask.Options.StopRunning = true;
                Character.Api.AutoFollow.IsAutoFollowing = false;
                Character.Logger.AddDebugText(rtbDebug, "NavTask is busy. attempting to stop");
            }
        }

        /// <summary>
        /// Handles the Click event of the button16 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button16_Click(object sender, EventArgs e)
        {
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"Points in navmesh path = {0}", Character.Tasks.NavTask.FFxiNav.PathCount().ToString()));
        }

        /// <summary>
        /// Handles the Click event of the button14 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button14_Click(object sender, EventArgs e)
        {
            Character.LoadNavMesh();
        }

        /// <summary>
        /// Handles the Click event of the button15 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button15_Click(object sender, EventArgs e)
        {
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"NavMesh is enabled = {0}", Character.Tasks.NavTask.FFxiNav.IsNavMeshEnabled().ToString()));
        }

        /// <summary>
        /// Handles the Click event of the button12 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button12_Click(object sender, EventArgs e)
        {
            Character.FFxiNAV.GetWaypoints();
            if (Character.FFxiNAV.Waypoints.Count > 0)
            {
                foreach (var item in Character.FFxiNAV.Waypoints)
                {
                    Character.Logger.AddDebugText(rtbDebug, string.Format(@"waypoint list x = {0} z = {1}", item.X.ToString(), item.Z.ToString()));
                }
            }
            else
                Character.Logger.AddDebugText(rtbDebug, "No Waypoints");
        }

        /// <summary>
        /// Handles the Click event of the button17 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button17_Click(object sender, EventArgs e)
        {
            Character.Logger.AddDebugText(rtbDebug, string.Format("Looking for path"));
            Character.Tasks.NavTask.Options.KeepMovingStartPosi.X = Character.Api.Player.X;
            Character.Tasks.NavTask.Options.KeepMovingStartPosi.Y = Character.Api.Player.Y;
            Character.Tasks.NavTask.Options.KeepMovingStartPosi.Z = Character.Api.Player.Z;
            Character.Tasks.NavTask.FFxiNav.FindPathToPosi(Character.Tasks.NavTask.Options.KeepMovingStartPosi, Character.Tasks.NavTask.Options.Posi, false);
        }

        /// <summary>
        /// Handles the 1 event of the button1_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            Character.ExportMapData();
        }

        /// <summary>
        /// Handles the Click event of the toolStripMenuItem1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Character.LoadZones();
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            Character.ExportSingleMapData(mapLB.SelectedItem.ToString());
        }

        /// <summary>
        /// The old string
        /// </summary>
        private string OldString;

        /// <summary>
        /// Creates new string.
        /// </summary>
        private string NewString;

        /// <summary>
        /// The old zone
        /// </summary>
        private string OldZone;

        /// <summary>
        /// Creates new zone.
        /// </summary>
        private string NewZone;

        /// <summary>
        /// The old mesh edge distance
        /// </summary>
        public double OldMeshEdgeDistance;

        /// <summary>
        /// Creates new meshedgedistance.
        /// </summary>
        public double NewMeshEdgeDistance;

        /// <summary>
        /// Gets or sets a value indicating whether [show MSG].
        /// </summary>
        /// <value><c>true</c> if [show MSG]; otherwise, <c>false</c>.</value>
        private bool ShowMsg { get; set; } = true;
 

        /// <summary>
        /// Handles the Tick event of the timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {

                NewString = Character.FFxiNAV.GetErrorMessage();
                if (OldString != NewString)
                {
                    Character.Logger.AddDebugText(this.rtbDebug, NewString);
                    OldString = Character.FFxiNAV.GetErrorMessage();
                }

                var path = string.Format(Application.StartupPath + "\\Dumped NavMeshes\\");
                int fCount = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;

                if (fCount == 0)
                {
                    if (ShowMsg)
                    {
                        ShowMsg = false;
                        if (MessageBox.Show("NavMesh files are missing!, do you want to download them from GitHub?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Character.Logger.AddDebugText(this.rtbDebug, "No NavMesh files found... Downloading...");

                            // https://github.com/xenonsmurf/FFXINavMeshes/archive/master.zip

                            WebClient webClient = new WebClient();
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                            webClient.DownloadFileAsync(new Uri("https://github.com/xenonsmurf/FFXINavMeshes/archive/master.zip"),
                                string.Format(@"{0}\\master.zip", path));
                        }
                    }
                }

                if (fCount > 1 && !Character.Zoning() && Character.Api.Player.ZoneId != 0)
                {
                    NewZone = string.Format(@"Zone id = {0}", Character.Api.Player.ZoneId.ToString());
                    if (OldZone != NewZone)
                    {
                        Character.Logger.AddDebugText(this.rtbDebug, NewZone);
                        OldZone = string.Format(@"Zone id = {0}", Character.Api.Player.ZoneId.ToString());
                        if (fCount > 0)
                        {
                            var NavFile = string.Format(Application.StartupPath + "\\Dumped NavMeshes\\{0}.nav", Character.Api.Player.ZoneId);
                            if (File.Exists(NavFile))
                            {
                                Character.FFxiNAV.Load(NavFile);
                            }
                            else
                                Character.Logger.AddDebugText(this.rtbDebug, "Unable to load NavMesh for current Zone");
                        }

                        if (PointsComboBox.Items.Count > 0)
                        {
                            PointsComboBox.Items.Clear();

                            foreach (var item in Character.Tasks.NavTask.Options.Points)
                            {
                                if (item.ID == Character.Api.Player.ZoneId)
                                {
                                    PointsComboBox.Items.Add(item.Name);
                                }
                            }
                            PointsComboBox.SelectedIndex = 1;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Character.Logger.AddDebugText(rtbDebug, ex.ToString());
            }
        }

        /// <summary>
        /// Completeds the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="AsyncCompletedEventArgs"/> instance containing the event data.
        /// </param>
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                Character.Logger.AddDebugText(this.rtbDebug, "Download completed!");
                Character.Logger.AddDebugText(this.rtbDebug, "Extracting Nav files");
                var path = string.Format(Application.StartupPath + "\\Dumped NavMeshes\\");
                string startPath = path;
                string zipPath = string.Format(@"{0}master.zip", path);
                string extractPath = path;
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Character.Logger.AddDebugText(this.rtbDebug, "Extraction complete");
                Character.Logger.AddDebugText(this.rtbDebug, "Moving files to NavMesh folder");
                foreach (var file in Directory.EnumerateFiles(string.Format(@"{0}{1}", path, "FFXINavMeshes-master")))
                {
                    string destFile = Path.Combine(path, Path.GetFileName(file));

                    if (!File.Exists(destFile))
                        File.Move(file, destFile);
                }
                Character.Logger.AddDebugText(this.rtbDebug, "Moved files, Deleting crap.");
                foreach (string file in Directory.GetFiles(path))
                {
                    if (!file.EndsWith(".nav"))
                    {
                        File.Delete(file);
                    }
                }
                if (File.Exists(string.Format(@"{0}FFXINavMeshes-master", path)))
                {
                    File.Delete(string.Format(@"{0}FFXINavMeshes-master", path));
                }
                Character.Logger.AddDebugText(this.rtbDebug, "good to go.");
            }
            catch (Exception ex)
            {
                Character.Logger.AddDebugText(this.rtbDebug, ex.ToString());
            }
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();
            string PATH = (string.Format(Application.StartupPath + "\\Map Collision obj\\"));
            OpenDialog.InitialDirectory = PATH;
            OpenDialog.FilterIndex = 0;

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                string ZoneFilename = OpenDialog.FileName;
                Character.Logger.AddDebugText(rtbDebug, string.Format(@"Obj File Selected = {0}", ZoneFilename));
                try
                {
                    Stopwatch stopWatch = new Stopwatch();

                    string result;
                    result = Path.GetFileName(ZoneFilename);
                    string result2 = result.Substring(0, result.LastIndexOf(".") + 1);
                    if (File.Exists(string.Format(@"{0}\\Dumped NavMeshes\\{1}nav", Application.StartupPath, result2)))
                    {
                        if (MessageBox.Show(string.Format(@"Are you sure you want to overwrite {0}.nav", result2.ToString()), "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Character.Logger.AddDebugText(rtbDebug, string.Format(@"Dumping NavMesh for {0}", result));
                            Thread.Sleep(100);
                            if (!Character.FFxiNAV.DumpingMesh)
                            {
                                Stopwatch stopWatch2 = new Stopwatch();
                                stopWatch.Start();
                                Character.FFxiNAV.Dump_NavMesh(ZoneFilename);
                                stopWatch.Stop();
                                TimeSpan ts2 = stopWatch.Elapsed;

                                // Format and display the TimeSpan value.
                                string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                    ts2.Hours, ts2.Minutes, ts2.Seconds,
                                    ts2.Milliseconds / 10);
                                Character.Logger.AddDebugText(rtbDebug, string.Format(@"Time Taken to dump mesh = " + elapsedTime2));
                            }
                        }
                    }
                    if (!File.Exists(string.Format(@"{0}\\Dumped NavMeshes\\{1}nav", Application.StartupPath, result2)))
                    {
                        stopWatch.Start();
                        Character.Logger.AddDebugText(rtbDebug, string.Format(@"Dumping NavMesh for {0}", ZoneFilename));
                        Character.FFxiNAV.Dump_NavMesh(ZoneFilename);

                        stopWatch.Stop();
                        TimeSpan ts = stopWatch.Elapsed;

                        // Format and display the TimeSpan value.
                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds,
                            ts.Milliseconds / 10);

                        Character.Logger.AddDebugText(rtbDebug, string.Format(@"Finished dumping NavMesh for {0}", ZoneFilename));
                        Character.Logger.AddDebugText(rtbDebug, string.Format(@"Time Taken to dump NavMesh = " + elapsedTime));
                    }
                }
                catch (Exception ex)
                {
                    Character.Logger.AddDebugText(rtbDebug, string.Format(ex.ToString()));
                }
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the CSTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void CSTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the CHTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void CHTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the AHTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void AHTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the ARTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void ARTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the MCTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void MCTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the MSTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void MSTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the TSTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TSTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the button4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double CS = Convert.ToDouble(CSTB.Text);
                double CH = Convert.ToDouble(CHTB.Text);
                double AH = Convert.ToDouble(AHTB.Text);
                double AR = Convert.ToDouble(ARTB.Text);
                double MC = Convert.ToDouble(MCTB.Text);
                double MS = Convert.ToDouble(MSTB.Text);
                double TS = Convert.ToDouble(TSTB.Text);
                double Rs = Convert.ToDouble(RMinS.Text);
                double Rms = Convert.ToDouble(RMS.Text);
                double EML = Convert.ToDouble(EMaxL.Text);
                double Em = Convert.ToDouble(EmE.Text);
                double Vpp = Convert.ToDouble(vPP.Text);
                double Dsd = Convert.ToDouble(DSD.Text);
                double Dsm = Convert.ToDouble(DsM.Text);
                Character.FFxiNAV.ChangeNavMeshSettings(CS, CH, AH, AR, MC, MS, TS, Rs, Rms, EML, Em, Vpp, Dsd, Dsm);
                Character.Logger.AddDebugText(rtbDebug, "NavMesh Settings changed.");
            }
            catch (Exception es)
            {
                Character.Logger.AddDebugText(rtbDebug, es.ToString());
            }
        }

        /// <summary>
        /// Handles the Click event of the button5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Start dumping all zone.obj file navmeshes" && !DumpMeshes.IsBusy)
            {
                button5.Text = "Stop dumping all zone.obj file navmeshes";
                Thread.Sleep(100);
                DumpMeshes.RunWorkerAsync();
            }
            else if (button5.Text == "Stop dumping all zone.obj file navmeshes")
            {
                DumpMeshes.CancelAsync();
                Thread.Sleep(200);
                button5.Text = "Start dumping all zone.obj file navmeshes";
                Thread.Sleep(200);
            }
            else if (button5.Text == "Stop dumping all zone.obj file navmeshes" && DumpMeshes.IsBusy)
            {
                DumpMeshes.CancelAsync();
                Thread.Sleep(200);
                button5.Text = "Start dumping all zone.obj file navmeshes";
                Thread.Sleep(200);
            }
        }

        /// <summary>
        /// Handles the DoWork event of the DumpMeshes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.
        /// </param>
        private void DumpMeshes_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                while (!DumpMeshes.CancellationPending)
                {
                    string path = string.Format("{0}\\Map Collision obj\\", Application.StartupPath);
                    int fileCount = Directory.GetFiles(path, "*.obj", SearchOption.AllDirectories).Length;
                    Character.Logger.AddDebugText(rtbDebug, string.Format(@"{0}.obj files fould in Map Collision obj folder", fileCount.ToString()));
                    foreach (var file in Directory.EnumerateFiles(string.Format(path, "*.obj")))
                    {
                        string result;
                        result = Path.GetFileName(file);
                        string result2 = result.Substring(0, result.LastIndexOf(".") + 1);
                        if (File.Exists(string.Format(@"{0}\\Dumped NavMeshes\\{1}nav", Application.StartupPath, result2)))
                        {
                            DialogResult box = MessageBox.Show(string.Format(@"Are you sure you want to overwrite {0}.nav", result2.ToString()), "Question", MessageBoxButtons.YesNoCancel);

                            if (box == DialogResult.Yes)
                            {
                                if (!Character.FFxiNAV.DumpingMesh && !DumpMeshes.CancellationPending)
                                {
                                    Stopwatch stopWatch = new Stopwatch();
                                    stopWatch.Start();
                                    Character.FFxiNAV.Dump_NavMesh(file);
                                    stopWatch.Stop();
                                    Thread.Sleep(1000);
                                    Character.FFxiNAV.UnloadMeshBuilder();
                                    Thread.Sleep(1000);
                                    TimeSpan ts = stopWatch.Elapsed;

                                    // Format and display the TimeSpan value.
                                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                        ts.Hours, ts.Minutes, ts.Seconds,
                                        ts.Milliseconds / 10);
                                    Character.Logger.AddDebugText(rtbDebug, string.Format(@"Time Taken to dump mesh = " + elapsedTime));
                                }
                                if (Character.FFxiNAV.DumpingMesh)
                                {
                                    Thread.Sleep(1000);
                                }
                            }
                            else if (box == DialogResult.Cancel)
                            {
                                DumpMeshes.CancelAsync();
                                break;
                            }
                            else if (box == DialogResult.No)
                            {
                                continue;
                            }
                        }
                        if (!File.Exists(string.Format(@"{0}\\Dumped NavMeshes\\{1}nav", Application.StartupPath, result2)))
                        {
                            Character.Logger.AddDebugText(rtbDebug, string.Format(@"Dumping NavMesh for {0}", result));
                            Thread.Sleep(1000);
                            if (!Character.FFxiNAV.DumpingMesh)
                            {
                                Stopwatch stopWatch = new Stopwatch();
                                stopWatch.Start();
                                Character.FFxiNAV.Dump_NavMesh(file);
                                stopWatch.Stop();
                                Thread.Sleep(1000);
                                Character.FFxiNAV.UnloadMeshBuilder();
                                Thread.Sleep(1000);
                                TimeSpan ts = stopWatch.Elapsed;

                                // Format and display the TimeSpan value.
                                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                    ts.Hours, ts.Minutes, ts.Seconds,
                                    ts.Milliseconds / 10);
                                Character.Logger.AddDebugText(rtbDebug, string.Format(@"Time Taken to dump mesh = " + elapsedTime));
                            }
                            if (Character.FFxiNAV.DumpingMesh)
                            {
                                Thread.Sleep(1000);
                            }
                        }
                        Thread.Sleep(1000);
                    }
                    Thread.Sleep(1000);
                    DumpMeshes.CancelAsync();
                }
            }
            catch (Exception es)
            {
                Character.Logger.AddDebugText(rtbDebug, es.ToString());
            }
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the DumpMeshes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> instance containing
        /// the event data.
        /// </param>
        private void DumpMeshes_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"No zone.obj files to dump meshes for, lets stop background worker."));
            button5.Text = "Start dumping all zone.obj file navmeshes";
            Thread.Sleep(200);
            DumpMeshes.CancelAsync();
        }

        /// <summary>
        /// Handles the Click event of the button6 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button6_Click(object sender, EventArgs e)
        {
            Character.FFxiNAV.Unload();
        }

        /// <summary>
        /// Handles the Click event of the button7 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button7_Click(object sender, EventArgs e)
        {
            var test = new position_t { X = 99999, Y = 9999, Z = 9999, Moving = 0, Rotation = 0 };
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"is this a valid Position on the mesh Test = {0}", Character.FFxiNAV.isValidPosition(test, false).ToString()));
            var PlayerPos = new position_t { X = Character.Api.Player.X, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z, Moving = 0, Rotation = 0 };
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"is this a valid Position on the mesh PlayerPos = {0}", Character.FFxiNAV.isValidPosition(PlayerPos, false).ToString()));
        }

        /// <summary>
        /// Handles the 1 event of the button16_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button16_Click_1(object sender, EventArgs e)
        {
            var test = new position_t { X = 99999, Y = 9999, Z = 9999, Moving = 0, Rotation = 0 };
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"is this a valid Position on the mesh Test = {0}", Character.FFxiNAV.isValidPosition(test, false).ToString()));
            var PlayerPos = new position_t { X = Character.Api.Player.X, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z, Moving = 0, Rotation = 0 };
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"is this a valid Position on the mesh PlayerPos = {0}", Character.FFxiNAV.isValidPosition(PlayerPos, false).ToString()));
        }

        /// <summary>
        /// Handles the 1 event of the button12_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button12_Click_1(object sender, EventArgs e)
        {
            Character.LoadNavMesh();
        }

        /// <summary>
        /// Handles the Click event of the button11 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button11_Click(object sender, EventArgs e)
        {
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"NavMesh is enabled = {0}", Character.Tasks.NavTask.FFxiNav.IsNavMeshEnabled().ToString()));
        }

        /// <summary>
        /// Handles the Click event of the button10 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button10_Click(object sender, EventArgs e)
        {
            Character.FFxiNAV.Unload();
        }

        /// <summary>
        /// Handles the Click event of the RandomRunBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RandomRunBtn_Click(object sender, EventArgs e)
        {
            if (RandomRunBtn.Text == "Start" && !Character.Tasks.RandomPathTask.IsBusy)
            {
                RandomRunBtn.Text = "Stop";
                Thread.Sleep(100);
                Character.Tasks.RandomPathTask.Start();
                Character.Tasks.RandomPathTask.Options.StopRunning = false;
            }
            else if (RandomRunBtn.Text == "Stop")
            {
                Character.Tasks.RandomPathTask.Stop();
                Character.Navi.Reset();
                Character.Tasks.Stop();
                Character.FFxiNAV.Waypoints.Clear();
                Character.Tasks.RandomPathTask.Options.WayPoints.Clear();
                Character.Tasks.RandomPathTask.Options.StopRunning = true;
                Character.Api.AutoFollow.IsAutoFollowing = false;
                // Character.Api.AutoFollow.SetAutoFollowCoords(0, 0, 0);
                RandomRunBtn.Text = "Start";
                Thread.Sleep(200);
                Character.Navi.Reset();
            }
            else if (RandomRunBtn.Text == "Start" && Character.Tasks.RandomPathTask.IsBusy)
            {
                RandomRunBtn.Text = "Stop";
                Thread.Sleep(100);
                Character.Tasks.RandomPathTask.Stop();
                Character.Tasks.Stop();
                Character.Api.AutoFollow.SetAutoFollowCoords(0, 0, 0);
                Character.FFxiNAV.Waypoints.Clear();
                Character.Tasks.RandomPathTask.Options.WayPoints.Clear();
                Character.Tasks.RandomPathTask.Options.StopRunning = true;
                Character.Api.AutoFollow.IsAutoFollowing = false;
                Character.Logger.AddDebugText(rtbDebug, "NavTask is busy. attempting to stop");
            }
        }

        /// <summary>
        /// Handles the 1 event of the button7_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button7_Click_1(object sender, EventArgs e)
        {
            var start = new position_t { X = Character.Api.Player.X, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z, Moving = 0, Rotation = 0 };
            //this is just a test. the end location can be anywhere.
            var end = new position_t { X = Character.Api.Player.X + 2, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z + 2, Moving = 0, Rotation = 0 };
            Character.FFxiNAV.findClosestPath(start, end, false);
            if (Character.FFxiNAV.PathCount() > 0)
            {
                Character.Logger.AddDebugText(rtbDebug, string.Format(@"We found a path, waypoint count = {0}", Character.FFxiNAV.PathCount().ToString()));
            }
            if (Character.FFxiNAV.PathCount() == 0)
            {
                Character.Logger.AddDebugText(rtbDebug, string.Format(@"No Path was found"));
            }
        }

        /// <summary>
        /// Handles the 1 event of the button17_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button17_Click_1(object sender, EventArgs e)
        {
            var start = new position_t { X = Character.Api.Player.X, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z, Moving = 0, Rotation = 0 };
            //this is just a test. the end location can be anywhere.
            var end = new position_t { X = Character.Api.Player.X - 3, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z - 3, Moving = 0, Rotation = 0 };

            Character.Logger.AddDebugText(rtbDebug, string.Format(@"Rotation = {0}", Character.FFxiNAV.Getrotation(start, end).ToString()));
        }

        /// <summary>
        /// Handles the Click event of the button18 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button18_Click(object sender, EventArgs e)
        {
            // position_t start, float maxRadius, sbyte maxTurns, bool UseCustom)
            var PlayerPos = new position_t { X = Character.Api.Player.X, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z, Moving = 0, Rotation = 0 };
            float Distance = 100;
            sbyte Turns = 30;
            bool UseCustom = false; // set true if you are using meshes made with geometry data from Noesis
            bool RandomPathFound = Character.FFxiNAV.findRandomPath(PlayerPos, Distance, Turns, UseCustom);
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"Did we find a random path = {0}", RandomPathFound.ToString()));
        }

        /// <summary>
        /// Handles the Click event of the button8 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button8_Click(object sender, EventArgs e)
        {
            string ConfigPath = string.Format("{0}\\Log Configs\\Default_Config.conf", Application.StartupPath);
            try
            {
                if (Character.FFxiNAV.Initialize(ConfigPath))
                {
                    Character.Logger.AddDebugText(rtbDebug, "Initialized");
                }
                if (!Character.FFxiNAV.Initialize(ConfigPath))
                {
                    Character.Logger.AddDebugText(rtbDebug, "Unable to Initialize");
                }
            }
            catch (Exception ex)
            {
                Character.Logger.AddDebugText(rtbDebug, ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000;)
            {
                if (IsDivisible(i, 10))
                {
                    if (!Character.Tasks.RandomPathTask.IsBusy)
                    {
                        Thread.Sleep(1000);
                        Character.Tasks.RandomPathTask.Start();
                        Character.Tasks.RandomPathTask.Options.StopRunning = false;
                    }
                }
                else if (IsDivisible(i, 10) && Character.Tasks.RandomPathTask.IsBusy)
                {
                    Thread.Sleep(1000);
                    Character.Tasks.RandomPathTask.Stop();
                    Character.Tasks.RandomPathTask.Options.StopRunning = true;
                }
                i++;
            }
        }

        public bool IsDivisible(int x, int n)
        {
            return (x % n) == 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.Text == "Start looking for Random Paths")
            {
                timer1.Enabled = true;
                timer1.Start();
                button20.Text = "Stop looking for Random Paths";
            }
            else if (button20.Text == "Stop looking for Random Paths")
            {
                timer1.Enabled = false;
                timer1.Stop();
                Thread.Sleep(100);
                Character.Tasks.RandomPathTask.Stop();
                Character.Navi.Reset();
                Character.Tasks.Stop();
                Character.FFxiNAV.Waypoints.Clear();
                Character.Tasks.RandomPathTask.Options.WayPoints.Clear();
                Character.Tasks.RandomPathTask.Options.StopRunning = true;
                Character.Api.AutoFollow.IsAutoFollowing = false;
                button20.Text = "Start looking for Random Paths";
            }
        }



        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private const int DEFAULT_SPEED = 100;
        private const int FLEE_SPEED = 200;
        private const int MAX_SPEED = 800;
        private const int TRACKBAR_MULTIPLIER = 20;
        private float Speed = 5;
        private bool TrackBarChange = false;
        const int DEFAULT_SPD_1 = 0x80;
        const int DEFAULT_SPD_2 = 0x40;
        const int FLEE_SPD_1 = 0xFF;
        const int MAX_SPEED_1 = 0x00;
        const int MAX_SPEED_2 = 0x42;
        const int OVER_FLEE_SPEED_2 = 0x41;

        private void hacktimer_Tick(object sender, EventArgs e)
        {
            try
            {

                if (!Character.Zoning())
                {
                    var PlayerID = (int)Character.Api.Party.GetPartyMember(0).TargetIndex;
                    var LocalPlayer = Character.Api.Entity.GetLocalPlayer();
                    if (Character.Tasks.NavTask.IsBusy)
                    {
                        //DateTime utcDate = new DateTime();
                        //if (Character.Navi.IsStuck())
                        //{
                        //    uint WallHack = 2684371968; //A0004400
                        //    LocalPlayer.Render0002 = WallHack;
                        //    utcDate = DateTime.UtcNow;

                        //}
                        //if (utcDate.AddSeconds(5) > DateTime.UtcNow)
                        //{
                        //    uint GmFlag = 2684363776; //A0002400
                        //    LocalPlayer.Render0002 = GmFlag;
                        //}
                    }
                    if (Character.Tasks.RandomPathTask.IsBusy)
                    {
                        DateTime utcDate = new DateTime();
                        if (Character.Navi.IsStuck())
                        {
                            uint WallHack = 2684371968; //A0004400
                            LocalPlayer.Render0002 = WallHack;
                            utcDate = DateTime.UtcNow;

                        }
                        if (utcDate.AddSeconds(5) > DateTime.UtcNow)
                        {
                            uint GmFlag = 2684363776; //A0002400
                            LocalPlayer.Render0002 = GmFlag;
                        }
                    }


                    if (chkEnableSpeed.Checked && LocalPlayer.Speed != Speed)
                    {
                        LocalPlayer.Speed = Speed;
                        TrackBarChange = false;
                    }
                if (Ja0WaitOnRBtn.Checked)
                    {
                        LocalPlayer.ActionTimer1 = 0;
                    }
                    foreach (RadioButton btn in FlagGB.Controls)
                    {
                        if (btn != null && btn.Checked)
                        {
                            switch (btn.Name)
                            {
                                case "NormalRBtn":
                                    //Don't need to set this, entity update packet will change it.
                                    //uint Disabled = 1024;
                                    //Character.Api.Entity.SetEntityRenderFlag02(Convert.ToInt32(PlayerID), Disabled);
                                    break;

                                case "GmRBtn":
                                    uint GmFlag = 2684363776; //A0002400
                                    LocalPlayer.Render0002 = GmFlag;

                                    break;

                                case "NoClipRBnt":
                                    uint WallHack = 2684371968; //A0004400
                                    LocalPlayer.Render0002 = WallHack;
                                    break;

                                default:

                                    break;
                            }
                        }
                    }
                    foreach (RadioButton btn in StatusGB.Controls)
                    {
                        if (btn != null && btn.Checked)
                        {
                            switch (btn.Name)
                            {
                                case "RBNorm":
                                    break;

                                case "RBDead":
                                    Character.Api.Entity.SetEntityStatus(Convert.ToInt32(PlayerID), 2);
                                    break;

                                case "RBEvent":
                                    Character.Api.Entity.SetEntityStatus(Convert.ToInt32(PlayerID), 4);
                                    break;

                                case "RBChocobo":
                                    Character.Api.Entity.SetEntityStatus(Convert.ToInt32(PlayerID), 5);
                                    break;

                                case "RBHealing":
                                    Character.Api.Entity.SetEntityStatus(Convert.ToInt32(PlayerID), 33);
                                    break;

                                case "RBFighting":
                                    Character.Api.Entity.SetEntityStatus(Convert.ToInt32(PlayerID), 1);
                                    break;

                                case "RBFishing":
                                    Character.Api.Entity.SetEntityStatus(Convert.ToInt32(PlayerID), 50);
                                    break;

                                case "RBSitting":
                                    Character.Api.Entity.SetEntityStatus(Convert.ToInt32(PlayerID), 47);
                                    break;

                                case "RBSynthing":
                                    Character.Api.Entity.SetEntityStatus(Convert.ToInt32(PlayerID), 44);
                                    break;
                                case "RBMaint": //status maintinance flag
                                    Character.Api.Entity.SetEntityStatus(Convert.ToInt32(PlayerID), 28);
                                    break;

                                default:
                                    break;
                            }

                        }
                    }
                }
                Thread.Sleep(10);
            }
            
            catch (Exception ex)
            {
                Character.Logger.AddDebugText(rtbDebug, ex.ToString());

            }
        }
        public void MiscCB_CheckedChanged(object sender, EventArgs e)
        {
            if (MiscCB.Checked)
            {
                hacktimer.Enabled = true;
            }
            else
                hacktimer.Enabled = false;
        }

        public void tBarSetSpeed_Scroll(object sender, EventArgs e)
        {
            TrackBarChange = true;
            if (tBarSetSpeed.Value ==5)
            {
                textSetSpeed.Text = (0).ToString() + " %";
                
                Speed = 5f;
            }
            else if (tBarSetSpeed.Value  == 10)
            {
                textSetSpeed.Text = (12.5).ToString() + " %";
                Speed = 5.625f;
            }
            else if (tBarSetSpeed.Value == 15)
            {
                textSetSpeed.Text = (25).ToString() + " %";
                Speed = 6.25f;
            }
            else if (tBarSetSpeed.Value ==20)
            {
                textSetSpeed.Text = (37.50).ToString() + " %";
                Speed = 6.875f;
            }
            else if (tBarSetSpeed.Value == 25 )
            {
                textSetSpeed.Text = (50).ToString() + " %";
                Speed = 7.5f;
            }
            else if (tBarSetSpeed.Value == 30)
            {
                textSetSpeed.Text = (62.50).ToString() + " %";
                Speed = 8.125f;
            }
            else if (tBarSetSpeed.Value == 35)
            {
                textSetSpeed.Text = (75).ToString() + " %";
                Speed = 8.75f;
            }
            else if (tBarSetSpeed.Value == 40)
            {
                textSetSpeed.Text = (87.50).ToString() + " %";
                Speed = 9.375f;
            }
            else if (tBarSetSpeed.Value > 40)
            {
                textSetSpeed.Text = (100).ToString() + " %";
                Speed = 10f;
            }

        }

        private void MiscCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (MiscCB.Checked)
            {
                hacktimer.Enabled = true;
            }
            else
                hacktimer.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var PlayerPosition = new position_t();

            //this will enable the nearest poly to player position
            if(Character.FFxiNAV.EnableOrDisableNearestPoly(PlayerPosition, true, false))
            { 
            Character.Logger.AddDebugText(rtbDebug, "Nearest Poly Enabled");
        }
            else Character.Logger.AddDebugText(rtbDebug, "Something went wrong trying to Enabled Nearest Poly");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var PlayerPosition = new position_t();

            //this will enable the nearest poly to player position
           if( Character.FFxiNAV.EnableOrDisableNearestPoly(PlayerPosition, false, false))
            {
                Character.Logger.AddDebugText(rtbDebug, "Nearest Poly Disabled");
            }
            else Character.Logger.AddDebugText(rtbDebug, "Something went wrong trying to Disable Nearest Poly");
        }
    }
}
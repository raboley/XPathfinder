// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
// Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 03-23-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="ffxiProcess.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using EliteMMO.API;
using PathFinder.Characters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PathFinder.Common
{
    /// <summary>
    /// Class ffxiProcess.
    /// </summary>
    public class ffxiProcess
    {
        /// <summary>
        /// The character dictionary
        /// </summary>
        public Dictionary<string, EliteAPI> _CharacterDictionary = new Dictionary<string, EliteAPI>();

        /// <summary>
        /// The identifier
        /// </summary>
        private int id;

        /// <summary>
        /// Initializes a new instance of the <see cref="ffxiProcess"/> class.
        /// </summary>
        /// <param name="mainform">The mainform.</param>
        public ffxiProcess(Log logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Gets or sets the API.
        /// </summary>
        /// <value>The API.</value>
        public EliteAPI Api { get; set; }

        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>The character.</value>
        public Character Character { get; set; }

        /// <summary>
        /// Gets or sets the mf.
        /// </summary>
        /// <value>The mf.</value>
        public Log Logger { get; set; }

        /// <summary>
        /// Gets or sets the processes.
        /// </summary>
        /// <value>The processes.</value>
        public Process[] processes { get; set; }

        /// <summary>
        /// Gets or sets the tc.
        /// </summary>
        /// <value>The tc.</value>
        public ToonControl tc { get; set; }

        /// <summary>
        /// The tab control
        /// </summary>
        private System.Windows.Forms.TabControl _TabControl = new System.Windows.Forms.TabControl();

        /// <summary>
        /// Adds the toons.
        /// </summary>
        public void AddToons()
        {
            try
            {
                foreach (var api in _CharacterDictionary.Values)
                {
                    tc = new ToonControl(Logger, _CharacterDictionary, api);

                    TabPage tp = new TabPage() { Text = api.Player.Name };
                    tp.Controls.Add(tc);
                    tc.Dock = DockStyle.Fill;
                    _TabControl.Controls.Add(tp);
                    _TabControl.Dock = DockStyle.Fill;
                    _TabControl.Padding = new System.Drawing.Point(10, 10);
                }
                // MF.ToonPanel.Controls.Add(_TabControl);
                //
                // MF.ToonPanel.BringToFront();
                // MF.ToonPanel.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                Logger.LogFile(ex.Message, "ffxiProcess");
            }
        }

        /// <summary>
        /// Gets the process.
        /// </summary>
        public void GetProcess()
        {
            try
            {
                _CharacterDictionary.Clear();
                processes = Process.GetProcesses();
                var query = from p
                            in processes
                            where IsProcessFullyLoggedIn(p)
                            select p;
                if (query.Count() > 0)
                {
                    foreach (var process in query)
                    {
                        Api = new EliteAPI(process.Id);
                        _CharacterDictionary.Add(Api.Player.Name, Api);
                        Console.WriteLine(string.Format(@"FFxi process found :- {0}", Api.Player.Name));
                        id = process.Id;
                        // MF.NextBtn.Text = "Next";
                    }
                }
                else if (query.Count() < 1)
                {
                    Console.WriteLine("Failed to find Pol Process, Checking for Boot Process..");
                    _CharacterDictionary.Clear();
                    processes = Process.GetProcesses();
                    var query2 = from p
                                in processes
                                 where IsBootProcessFullyLoggedIn(p)
                                 select p;
                    if (query2.Count() > 0)
                    {
                        foreach (var process in query2)
                        {
                            Api = new EliteAPI(process.Id);
                            _CharacterDictionary.Add(Api.Player.Name, Api);
                            Console.WriteLine(String.Format(@"FFxi process found :- {0}", Api.Player.Name));
                            id = process.Id;
                            // MF.NextBtn.Text = "Next";
                        }
                    }
                    else if (query2.Count() < 1)
                    {
                        Console.WriteLine( "Please make sure you are fully Logged into ffxi");
                        // MF.NextBtn.Text = "Refresh";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message, "ffxiProcess");
            }
        }

        /// <summary>
        /// Determines whether [is process fully logged in] [the specified p].
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns>
        /// <c>true</c> if [is process fully logged in] [the specified p]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsProcessFullyLoggedIn(Process p)
        {
            return p.ProcessName.Contains("pol") &&
                !string.IsNullOrEmpty(p.MainWindowTitle)
                   && p.MainWindowTitle.Length > 2
                   && !p.MainWindowTitle.Contains("pol.exe")
                   && !p.MainWindowTitle.Contains("FINAL FANTASY XI")
                   && string.Compare(p.MainWindowTitle, "Final Fantasy XI", StringComparison.OrdinalIgnoreCase) != 0
                   && p.MainWindowTitle.IndexOf("PlayOnline", StringComparison.Ordinal) <= -1
                   && p.MainWindowTitle.IndexOf("Final Fantasy XI", StringComparison.Ordinal) <= -1;
        }

        /// <summary>
        /// Determines whether [is boot process fully logged in] [the specified p].
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns>
        /// <c>true</c> if [is boot process fully logged in] [the specified p]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsBootProcessFullyLoggedIn(Process p)
        {
            return p.ProcessName.Contains("boot") &&
                !string.IsNullOrEmpty(p.MainWindowTitle)
                   && p.MainWindowTitle.Length > 2
                   && !p.MainWindowTitle.Contains("pol.exe")
                   && !p.MainWindowTitle.Contains("FINAL FANTASY XI")
                   && string.Compare(p.MainWindowTitle, "Final Fantasy XI", StringComparison.OrdinalIgnoreCase) != 0
                   && p.MainWindowTitle.IndexOf("PlayOnline", StringComparison.Ordinal) <= -1
                   && p.MainWindowTitle.IndexOf("Final Fantasy XI", StringComparison.Ordinal) <= -1;
        }
    }
}
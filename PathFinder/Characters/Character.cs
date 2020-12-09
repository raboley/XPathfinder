// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
// Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-14-2020 ***********************************************************************
// <copyright file="Character.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using EliteMMO.API;
using PathFinder.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PathFinder.Characters
{
    /// <summary>
    /// Class Character.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Gets or sets the dat.
        /// </summary>
        /// <value>The dat.</value>
        public DAT dat { get; set; }

        /// <summary>
        /// The character dictionary
        /// </summary>
        public Dictionary<string, EliteAPI> _CharacterDictionary;

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public EntityStatus Status { get; private set; }

        /// <summary>
        /// Gets or sets the monitored API.
        /// </summary>
        /// <value>The monitored API.</value>
        public EliteAPI MonitoredAPI { get; set; }

        /// <summary>
        /// Gets or sets the navi.
        /// </summary>
        /// <value>The navi.</value>
        public Navigation Navi { get; set; }

        /// <summary>
        /// Gets or sets the f fxi nav.
        /// </summary>
        /// <value>The f fxi nav.</value>
        public FFXINAV FFxiNAV { get; set; }

        /// <summary>
        /// Gets or sets the tasks.
        /// </summary>
        /// <value>The tasks.</value>
        public Tasks Tasks { get; set; }

        /// <summary>
        /// Gets or sets the points.
        /// </summary>
        /// <value>The points.</value>
        public List<PointsOfInterest> Points { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        /// <param name="Log">The log.</param>
        /// <param name="tc">The tc.</param>
        /// <param name="chars">The chars.</param>
        /// <param name="api">The API.</param>
        public Character(Log Log, ToonControl tc, Dictionary<string, EliteAPI> chars, EliteAPI api)
        {
            Logger = Log;
            Tc = tc;
            _CharacterDictionary = chars;
            Api = api;
            Navi = new Navigation(this);
            Target = new Target(this);
            FFxiNAV = new FFXINAV();
            Points = new List<PointsOfInterest>();
            Tasks = new Tasks(this);
            CreateFolders();
            string ConfigPath = string.Format("{0}\\Log Configs\\Default_Config.conf", Application.StartupPath);
            try
            {
                if (FFxiNAV.Initialize(ConfigPath))
                {
                    Logger.AddDebugText(tc.rtbDebug, "Initialized");
                }
                if (!FFxiNAV.Initialize(ConfigPath))
                {
                    Logger.AddDebugText(tc.rtbDebug, "Unable to Initialize");
                }
            }
            catch (Exception ex)
            {
                Logger.AddDebugText(tc.rtbDebug, ex.ToString());
            }
        }

        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>The filename.</value>
        public string Filename { get; set; }

        /// <summary>
        /// Exports the map data.
        /// </summary>
        public void ExportMapData()
        {
            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                foreach (var zn in Tasks.RandomPathTask.Options.Zones)
                {
                    Logger.AddDebugText(Tc.rtbDebug, string.Format(@"Exporting {0} ID= {1}", zn.name, zn.id.ToString()));
                    string str = zn.path.Replace(@"\", @"/");
                    if (zn.name != "NILL" && zn.path != "NILL" && !File.Exists(string.Format(@"Map Collision obj\{0}.obj", zn.name)))
                    {
                        Filename = zn.id.ToString();
                        dat = new DAT(this, zn.id.ToString());
                        String[] foos = new String[] { str };
                        dat.Load(foos);
                    }
                }
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;

                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);

                Logger.AddDebugText(Tc.rtbDebug, string.Format(@"Finished dumping all zones collision data .obj's"));
                Logger.AddDebugText(Tc.rtbDebug, string.Format(@"Time Taken to dump zones collision data .obj's = " + elapsedTime));
            }
            catch (Exception ex)
            {
                Logger.AddDebugText(Tc.rtbDebug, string.Format(@"{0} Best comment out {1} from ZoneList.xml save it,reload and try again. Please use noesis to export that map",
                    ex.ToString(), Filename));
            }
        }

        /// <summary>
        /// Exports the single map data.
        /// </summary>
        /// <param name="name">The name.</param>
        public void ExportSingleMapData(string Id)
        {
            try
            {
                foreach (var zn in Tasks.RandomPathTask.Options.Zones)
                {
                    if (zn.id.ToString() == Id)
                    {
                        Logger.AddDebugText(Tc.rtbDebug, string.Format(@"Exporting {0} ID= {1}", zn.name, zn.id.ToString()));
                        string str = zn.path.Replace(@"\", @"/");
                        if (zn.name != "NILL" && zn.path != "NILL" && !File.Exists(string.Format(@"Map Collision obj\{0}.obj", zn.name)))
                        {
                            Filename = zn.id.ToString();
                            dat = null;
                            dat = new DAT(this, zn.id.ToString());
                            String[] foos = new String[] { str };
                            dat.Load(foos);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.AddDebugText(Tc.rtbDebug, string.Format(@"{0} Best comment out {1} from ZoneList.xml save it,reload and try again. Please use noesis to export that map",
                    ex.ToString(), Filename));
            }
        }

        /// <summary>
        /// Occurs when [moved].
        /// </summary>
        public event EventHandler<NavigationEventArgs> Moved = delegate { };

        /// <summary>
        /// Gets or sets the API.
        /// </summary>
        /// <value>The API.</value>
        public EliteAPI Api { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is moving.
        /// </summary>
        /// <value><c>true</c> if this instance is moving; otherwise, <c>false</c>.</value>
        public bool IsMoving { get; set; }

        /// <summary>
        /// Gets or sets the leader.
        /// </summary>
        /// <value>The leader.</value>
        public EliteAPI Leader { get; set; }

        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        /// <value>The logger.</value>
        public Log Logger { get; set; }

        /// <summary>
        /// Gets or sets the tc.
        /// </summary>
        /// <value>The tc.</value>
        public ToonControl Tc { get; set; }

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>The target.</value>
        public Target Target { get; set; }

        /// <summary>
        /// Creates the folders.
        /// </summary>
        public void CreateFolders()
        {
            if (!System.IO.Directory.Exists(string.Format(@"Documents\{0}\ChatLog", Api.Player.Name)))
            {
                System.IO.Directory.CreateDirectory(string.Format(@"Documents\{0}\ChatLog", Api.Player.Name));
            }
            if (!System.IO.Directory.Exists(string.Format(@"Documents\Points of intrest")))
            {
                System.IO.Directory.CreateDirectory(string.Format(@"Documents\Points of intrest"));
            }
            if (!System.IO.Directory.Exists(string.Format(@"Map Collision obj")))
            {
                System.IO.Directory.CreateDirectory(string.Format(@"Map Collision obj"));
            }
            if (!System.IO.Directory.Exists(string.Format(@"Dumped NavMeshes")))
            {
                System.IO.Directory.CreateDirectory(string.Format(@"Dumped NavMeshes"));
            }
            if (!System.IO.Directory.Exists(string.Format(@"Documents\{0}\Config", Api.Player.Name)))
            {
                System.IO.Directory.CreateDirectory(string.Format(@"Documents\{0}\Config", Api.Player.Name));
            }
            if (!System.IO.Directory.Exists(string.Format("{0}\\Log Configs", Application.StartupPath)))
            {
                System.IO.Directory.CreateDirectory(string.Format("{0}\\Log Configs", Application.StartupPath));
            }
            if (!System.IO.Directory.Exists(string.Format("{0}\\Logs", Application.StartupPath)))
            {
                System.IO.Directory.CreateDirectory(string.Format("{0}\\Logs", Application.StartupPath));
            }

            string ConfigPath = string.Format("{0}\\Log Configs\\Default_Config.conf", Application.StartupPath);
            if (!System.IO.Directory.Exists(ConfigPath))
            {
                using (StreamWriter sw = File.CreateText(ConfigPath))
                {
                    sw.WriteLine("* GLOBAL:");
                    sw.WriteLine(" FORMAT                  =   \"%datetime | %level | %logger | %msg\"");
                    sw.WriteLine(" FILENAME                =  \"Logs\\FFXINAV-Info.log\"");
                    sw.WriteLine(" ENABLED                 =   true");
                    sw.WriteLine(" TO_FILE                 =   true");
                    sw.WriteLine(" TO_STANDARD_OUTPUT      =   true");
                    sw.WriteLine(" SUBSECOND_PRECISION     =   3");
                    sw.WriteLine(" PERFORMANCE_TRACKING    =   false");
                    sw.WriteLine(" MAX_LOG_FILE_SIZE       =   2097152 ## Throw log files away after 2MB");
                    sw.Dispose();
                }
            }
        }

        /// <summary>
        /// Determines whether this instance is engaged.
        /// </summary>
        /// <returns><c>true</c> if this instance is engaged; otherwise, <c>false</c>.</returns>
        public bool IsEngaged()
        {
            return Api.Player.Status == (ulong)EntityStatus.Engaged;
        }

        /// <summary>
        /// Determines whether [is target locked].
        /// </summary>
        /// <returns><c>true</c> if [is target locked]; otherwise, <c>false</c>.</returns>
        public bool IsTargetLocked()
        {
            var _Target = Api.Target.GetTargetInfo();
            if (_Target.TargetIndex == (uint)Target.FindBestTarget() && _Target.LockedOn)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Handles the <see cref="E:Moved"/> event.
        /// </summary>
        /// <param name="e">
        /// The <see cref="NavigationEventArgs"/> instance containing the event data.
        /// </param>
        protected virtual void OnMoved(NavigationEventArgs e)
        {
            Moved(this, e);
        }

        /// <summary>
        /// Gets or sets the old position.
        /// </summary>
        /// <value>The old position.</value>
        public Position OldPosition { get; set; }

        /// <summary>
        /// Gets the current position.
        /// </summary>
        /// <value>The current position.</value>
        public Position CurrentPosition => new Position { X = Api.Player.X, Y = Api.Player.Y, Z = Api.Player.Z, H = Api.Player.H };

        /// <summary>
        /// Saves the points of interest.
        /// </summary>
        public void SavePointsOfInterest()
        {
            try
            {
                string PATH = (string.Format(Application.StartupPath + "\\Documents\\Points of intrest"));

                SaveFileDialog SaveDialog = new SaveFileDialog
                {
                    InitialDirectory = PATH,
                    Filter = "xml |*.xml",
                    FilterIndex = 1
                };
                string Filename;
                if (SaveDialog.ShowDialog() == DialogResult.OK)
                {
                    if (SaveDialog.FileName.Contains(".xml"))
                        Filename = SaveDialog.FileName;
                    else
                        Filename = SaveDialog.FileName + ".xml";
                    XmlSerializationHelper.Serialize(Filename, Tasks.RandomPathTask.Options.Points);
                }
                SaveDialog.Dispose();
            }
            catch (Exception ex)
            {
                Logger.AddDebugText(Tc.rtbDebug, string.Format(@"Error Saving {0}", ex));
            }
        }

        /// <summary>
        /// Loads the points of interest.
        /// </summary>
        public void LoadPointsOfInterest()
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();
            Tc.PointsComboBox.Items.Clear();
            string PATH = (string.Format(Application.StartupPath + "\\Documents\\Points of intrest"));
            OpenDialog.InitialDirectory = PATH;
            OpenDialog.FilterIndex = 0;

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                Navi.Reset();
                Tasks.NavTask.Options.Points.Clear();

                string PointsFilename = OpenDialog.FileName;
                Logger.AddDebugText(Tc.rtbDebug, string.Format(@"Nav file loaded = {0}", PointsFilename));
                try
                {
                    Tasks.NavTask.Options.Points = XmlSerializationHelper.Deserialize<List<PointsOfInterest>>(PointsFilename) ?? new List<PointsOfInterest>();

                    OpenDialog.Dispose();
                    foreach (var item in Tasks.NavTask.Options.Points)
                    {
                        if (item.ID == Api.Player.ZoneId)
                        {
                            Tc.PointsComboBox.Items.Add(item.Name);
                        }
                    }

                    Logger.AddDebugText(Tc.rtbDebug, string.Format(@"Added {0} Points of interest", Tasks.NavTask.Options.Points.Count.ToString()));
                    if (Tc.PointsComboBox.Items.Count > 0)
                    {
                        Tc.PointsComboBox.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    Logger.AddDebugText(Tc.rtbDebug, string.Format(@"LoadWaypoints error {0}", ex.ToString()));
                }
            }
        }

        /// <summary>
        /// Loads the zones.
        /// </summary>
        public void LoadZones()
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();
            string PATH = (string.Format(Application.StartupPath + "\\Documents\\"));
            OpenDialog.InitialDirectory = PATH;
            OpenDialog.FilterIndex = 0;

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                Tasks.RandomPathTask.Options.Zones.Clear();

                string ZoneFilename = OpenDialog.FileName;
                Logger.AddDebugText(Tc.rtbDebug, string.Format(@"Nav file loaded = {0}", ZoneFilename));
                try
                {
                    Tasks.RandomPathTask.Options.Zones = XmlSerializationHelper.Deserialize<List<Zones>>(ZoneFilename) ?? new List<Zones>();

                    OpenDialog.Dispose();

                    Logger.AddDebugText(Tc.rtbDebug, string.Format(@"Added {0} Zones", Tasks.RandomPathTask.Options.Zones.Count.ToString()));
                    foreach (var item in Tasks.RandomPathTask.Options.Zones)
                    {
                        Tc.mapLB.Items.Add(item.id);
                    }
                }
                catch (Exception ex)
                {
                    Logger.AddDebugText(Tc.rtbDebug, string.Format(@"LoadZones error {0}", ex.ToString()));
                }
            }
        }

        /// <summary>
        /// Loads the nav mesh.
        /// </summary>
        public void LoadNavMesh()
        {
            try
            {
                OpenFileDialog OpenDialog = new OpenFileDialog();
                string PATH = (string.Format(Application.StartupPath));
                OpenDialog.InitialDirectory = PATH;
                OpenDialog.FilterIndex = 0;

                if (OpenDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = OpenDialog.FileName;
                    FFxiNAV.Load(path);
                    Logger.AddDebugText(Tc.rtbDebug, string.Format(@"NavMesh initialized, File Loaded = {0}", path));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Character"/> is busy.
        /// </summary>
        /// <value><c>true</c> if busy; otherwise, <c>false</c>.</value>
        public bool Busy => IsDead || IsAfflicted(EliteMMO.API.StatusEffect.Charm1) ||
                       IsAfflicted(EliteMMO.API.StatusEffect.Charm2)
                       || IsAfflicted(EliteMMO.API.StatusEffect.Sleep)
                       || IsAfflicted(EliteMMO.API.StatusEffect.Sleep2) || IsAfflicted(EliteMMO.API.StatusEffect.Stun)
                       || IsAfflicted(EliteMMO.API.StatusEffect.Stun)
                       || IsAfflicted(EliteMMO.API.StatusEffect.Petrification)
                       || IsAfflicted(EliteMMO.API.StatusEffect.Terror)
                       || IsCasting
                       || Zoning()
                       || Status == EntityStatus.Healing;

        /// <summary>
        /// Gets a value indicating whether this instance is afflicte amnesia.
        /// </summary>
        /// <value><c>true</c> if this instance is afflicte amnesia; otherwise, <c>false</c>.</value>
        public bool IsAfflicteAmnesia => IsAfflicted(EliteMMO.API.StatusEffect.Amnesia);

        /// <summary>
        /// Gets a value indicating whether this instance is silenced.
        /// </summary>
        /// <value><c>true</c> if this instance is silenced; otherwise, <c>false</c>.</value>
        public bool IsSilenced => IsAfflicted(EliteMMO.API.StatusEffect.Silence);

        /// <summary>
        /// Casts the check.
        /// </summary>
        public void CastCheck()
        {
            if (CastPercentEx.Equals(0))
            {
                if (IsCasting)
                {
                    Logger.AddDebugText(Tc.rtbDebug, "Cast stop");
                }
                IsCasting = false; // Not casting
            }
            else if (CastPercentEx.Equals(LastcastingValue)) // we were interupted
            {
                if (IsCasting)
                {
                    Logger.AddDebugText(Tc.rtbDebug, "Cast stop");
                }
                IsCasting = false;
            }
            else // we are casting
            {
                if (!IsCasting)
                {
                    Logger.AddDebugText(Tc.rtbDebug, "Cast start");
                }
                LastcastingValue = CastPercentEx;
                IsCasting = true;
            }
        }

        /// <summary>
        /// The lastcasting value
        /// </summary>
        public float LastcastingValue;

        /// <summary>
        /// Gets the cast percent ex.
        /// </summary>
        /// <value>The cast percent ex.</value>
        public float CastPercentEx => (Api.CastBar.Percent);

        /// <summary>
        /// Determines whether [is afflicted ja] [the specified effect].
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <returns><c>true</c> if [is afflicted ja] [the specified effect]; otherwise, <c>false</c>.</returns>
        public bool IsAfflictedJA(EliteMMO.API.StatusEffect effect)
        {
            foreach (var s in Api.Player.Buffs)
            {
                var status = (EliteMMO.API.StatusEffect)s;
                if (status == effect)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is casting.
        /// </summary>
        /// <value><c>true</c> if this instance is casting; otherwise, <c>false</c>.</value>
        public bool IsCasting { get; set; }

        /// <summary>
        /// Zonings this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Zoning()
        {
            return Api.Player.LoginStatus == (int)LoginStatus.Loading || Api.Player.LoginStatus == (int)LoginStatus.LoginScreen;
        }

        /// <summary>
        /// Occurs when [status changed].
        /// </summary>
        public event EventHandler StatusChanged = delegate { };

        /// <summary>
        /// Occurs when [zone changed].
        /// </summary>
        public event EventHandler ZoneChanged = delegate { };

        /// <summary>
        /// Gets a value indicating whether this instance is dead.
        /// </summary>
        /// <value><c>true</c> if this instance is dead; otherwise, <c>false</c>.</value>
        public bool IsDead => Status == EntityStatus.Dead || Status == EntityStatus.DeadEngaged || Api.Player.HP <= 0;

        /// <summary>
        /// Determines whether the specified effect is afflicted.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <returns><c>true</c> if the specified effect is afflicted; otherwise, <c>false</c>.</returns>
        public bool IsAfflicted(EliteMMO.API.StatusEffect effect)
        {
            foreach (var s in Api.Player.Buffs)
            {
                var status = (EliteMMO.API.StatusEffect)s;
                if (status == effect)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
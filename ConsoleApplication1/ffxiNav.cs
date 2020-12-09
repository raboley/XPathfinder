using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using PathFinder;
using PathFinder.Common;
using System.Threading;

namespace ConsoleApplication1
{
    public class ffxiNav
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
        private WebClient Client { get; set; }

        public void Setup()
        {
            try
            {
                Logger = new Log();
                ffxiprocess = new ffxiProcess(Logger);
                Client = new WebClient();
                Check();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            // Check dependencies Present
            HaveFFXINavDll();
            // New FFXINAV
            var ffxiNav = new FFXINAV();
            // Load Up Map
            var navMeshPath = "navmeshes/231.nav";
            navMeshPath =
                "C:\\Users\\Russell\\RiderProjects\\ffxi\\PathFinder\\PathFinder\\bin\\x86\\Debug\\Dumped NavMeshes\\Bostaunieux_Oubliette.nav";


            if (!File.Exists(navMeshPath))
                Console.WriteLine("Cant find navmesh: " + navMeshPath);
            var character = ffxiprocess._CharacterDictionary["Mistrel"];

            var tc = new ToonControl(Logger, ffxiprocess._CharacterDictionary, character);

            ffxiNav.Load(navMeshPath);
            var worked = ffxiNav.IsNavMeshEnabled();

            tc.Character.FFxiNAV.Load(navMeshPath);
            var enabled = tc.Character.FFxiNAV.IsNavMeshEnabled();
            var i = 0;
            while (!enabled)
            {
                enabled = tc.Character.FFxiNAV.IsNavMeshEnabled();
                if (!enabled)
                    Console.WriteLine("attempt: " + i + " Couldn't load mesh: " + navMeshPath);
                else
                    Console.WriteLine("Loaded Mesh: " + navMeshPath);

                worked = ffxiNav.IsNavMeshEnabled();

                if (!worked)
                    Console.WriteLine("Couldn't load mesh: " + navMeshPath);
                else
                    Console.WriteLine("Loaded Mesh: " + navMeshPath);

                Thread.Sleep(1000);
                i++;
            }

            Console.WriteLine("Nav mesh must have loaded!");
        }

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
                Console.WriteLine(ex.ToString());
            }
        }

        public bool DoWeHaveAllNeededFiles()
        {
            try
            {
                string NetVersion = Environment.Version.ToString();
                Console.WriteLine(string.Format(@".NetFramework v  = ({0})", NetVersion));
                if (!NetVersion.Contains("4."))
                {
                    Console.WriteLine(
                        "Please Update your .Net framework, https://www.microsoft.com/en-us/download/details.aspx?id=53344");
                    return false;
                }

                if (File.Exists("EliteAPI.dll"))
                {
                    FileVersionInfo EliteAPIVersion = FileVersionInfo.GetVersionInfo("EliteAPI.dll");
                    Console.WriteLine(string.Format(@"EliteAPI Found: Version: ({0})", EliteAPIVersion.FileVersion));
                }

                if (!File.Exists("EliteAPI.dll"))
                {
                    Console.WriteLine(string.Format(@"EliteAPI Missing"));
                    Console.WriteLine("Getting Latest EliteAPI.dll");
                    Client.DownloadFile("http://ext.elitemmonetwork.com/downloads/eliteapi/EliteAPI.dll",
                        "EliteAPI.dll");
                }

                if (File.Exists("FFXINAV.dll"))
                {
                    FileVersionInfo FFXINAVversion = FileVersionInfo.GetVersionInfo("FFXINAV.dll");
                    Console.WriteLine(string.Format(@"FFXINAV.dll Found: Version: ({0})", FFXINAVversion.FileVersion));
                }
                else if (!File.Exists("FFXINAV.dll"))
                {
                    Console.WriteLine(@"FFXINAV.dll is missing");
                }

                if (File.Exists("EliteMMO.API.dll"))
                {
                    FileVersionInfo EliteAPIVersion = FileVersionInfo.GetVersionInfo("EliteMMO.API.dll");
                    Console.WriteLine(string.Format(@"EliteMMO.API Found: Version: ({0})",
                        EliteAPIVersion.FileVersion));
                }
                else if (!File.Exists("EliteMMO.API.dll"))
                {
                    Console.WriteLine("EliteMMO.API MISSING");
                    Console.WriteLine("Getting Latest EliteMMO.API.dll");
                    Client.DownloadFile("http://ext.elitemmonetwork.com/downloads/elitemmo_api/EliteMMO.API.dll",
                        "EliteMMO.API.dll");
                }

                Console.WriteLine(@"Finished checking files");
            }
            catch (Exception ex)
            {
                Logger.LogFile(ex.Message, "CheckNeededFiles");
                Console.WriteLine(ex.ToString());
                return false;
            }

            Client.Dispose();
            return true;
        }

        private static void HaveFFXINavDll()
        {
            if (File.Exists("FFXINAV.dll"))
            {
                FileVersionInfo FFXINAVversion = FileVersionInfo.GetVersionInfo("FFXINAV.dll");
                Console.WriteLine(string.Format(@"FFXINAV.dll Found: Version: ({0})", FFXINAVversion.FileVersion));
            }
            else if (!File.Exists("FFXINAV.dll"))
            {
                Console.WriteLine(@"FFXINAV.dll is missing");
            }
        }
    }
}
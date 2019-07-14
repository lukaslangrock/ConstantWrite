using System;
using System.IO;

namespace ConstantWrite
{
    class ConstantWrite
    {
        string author = "Lukas Langrock";
        string version = "0.0.1 PRE-RELEASE";
        string github = "https://github.com/lukas34/ConstantWrite/";
        string license = "MIT";
        Config ConfigClass = new Config();
        ConfigObject config = new ConfigObject();

        /// <summary>
        /// This void will prepare and initialize all sorts of things. It has to be run first
        /// </summary>
        public void Initialize()
        {
            Console.WriteLine("[//] Initializing ConstantWrite torture test [\\]");
            Console.WriteLine("[//] Author: " + author + " [\\]");
            Console.WriteLine("[//] Version: " + version + " [\\]");
            Console.WriteLine("[//] GitHub: " + github + " [\\]");
            Console.WriteLine("[//] License: " + license + " [\\]");

            // Read config
            Console.Write("[#] Reading config.json");
            config = ConfigClass.GetConfig();
            ClearCurrentConsoleLine();
            Console.WriteLine("[+] Loaded config.json");

            // Validate config
            Console.Write("[#] Validating settings");
            bool valid = true;
            if (config.FileSize <= 1) { valid = false; };
            if (!config.StoragePath.EndsWith("/") || !config.StoragePath.EndsWith("\\")) { config.StoragePath = config.StoragePath += "/"; }
            try { if (!Directory.Exists(config.StoragePath)) { Directory.CreateDirectory(config.StoragePath); } }
            catch (Exception ex) { valid = false; ClearCurrentConsoleLine(); Console.WriteLine("[+] Error: " + ex.ToString()); }

            ClearCurrentConsoleLine();
            if (valid == true) { Console.WriteLine("[+] Validation complete"); }
            else { Console.WriteLine("[!] Validation failed"); }

            Console.WriteLine("[//] Initialization finnished [\\]" + Environment.NewLine);
        }

        /// <summary>
        /// This will start the torture test.
        /// INFO: Initialize() has to be run first
        /// </summary>
        public void RunTortureTest()
        {
            Console.WriteLine("[+] Running torture test - Press ESC to exit");

            do
            {
                while (!Console.KeyAvailable) { Worker(); }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Console.WriteLine("[+] Stopped!");

            if (config.AutoClean == true)
            {
                Console.Write("[#] Cleaning up...");
                Directory.Delete(config.StoragePath, true);
                ClearCurrentConsoleLine();
                Console.WriteLine("[+] Cleaned up");
            }
        }

        /// <summary>
        /// Saves random data to desired place
        /// </summary>
        private void Worker()
        {
            int BlockSize = 1024 * 8;
            int BlocksPerMB = (1024 * 1024) / BlockSize;
            string filename = config.StoragePath + DateTime.Now.DayOfYear + "." + DateTime.Now.Ticks + ".constantwrite";
            byte[] data = new byte[BlockSize];
            Random random = new Random();
            using (FileStream stream = File.OpenWrite(filename))
            {
                for (int i = 0; i < config.FileSize * BlocksPerMB; i++)
                {
                    random.NextBytes(data);
                    stream.Write(data, 0, data.Length);
                }
            }
        }

        /// <summary>
        /// This just clears the current console line
        /// </summary>
        private void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}

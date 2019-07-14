using Newtonsoft.Json;
using System;

namespace ConstantWrite
{
    public class ConfigObject
    {
        public string StoragePath { get; set; }
        public bool AutoClean { get; set; }
        public int FileSize { get; set; }
    }

    class Config
    {
        private bool AllowExit = false;

        public ConfigObject GetConfig()
        {
            string data = System.IO.File.ReadAllText("config.json");
            ConfigObject config = JsonConvert.DeserializeObject<ConfigObject>(data);
            return config;
        }

        private void SaveConfig(ConfigObject config)
        {
            string data = JsonConvert.SerializeObject(config, Formatting.Indented);
            System.IO.File.WriteAllText("config.json", data);
        }

        public void OpenConfigEditor()
        {
            // CLI editor for config
            Console.Write("Please Wait (...)");
            ConfigObject config = GetConfig();
            ClearCurrentConsoleLine();

            while (AllowExit == false)
            {
                Console.WriteLine("[----- Configuration -----]");
                Console.WriteLine("1. Drive/Folder to torture test");
                Console.WriteLine("2. Size of test files");
                Console.WriteLine("3. Autoclean after end of test");
                Console.WriteLine("4. Return to main menu");
                Console.WriteLine();
                string menu_pool = "1234";
                string menu_selection = "#";

                // ask what to start
                while (!menu_pool.Contains(menu_selection))
                {
                    ClearCurrentConsoleLine();
                    Console.Write("What do you want to configure? Number: ");
                    menu_selection = Console.ReadKey().KeyChar.ToString();
                }

                Console.WriteLine(System.Environment.NewLine); // for nice formatting
                int id = Convert.ToInt32(menu_selection);

                switch (id)
                {
                    case 1:
                        Console.WriteLine("Editing torture test location (leave blank for current)");
                        Console.WriteLine("Current: " + config.StoragePath);
                        Console.Write("New: ");
                        string newdata1 = Console.ReadLine();
                        if (newdata1 == "" || newdata1 == " ") { Console.WriteLine("Canceled!"); }
                        else
                        {
                            Console.Write("Saving ...");
                            config.StoragePath = newdata1;
                            SaveConfig(config);
                            ClearCurrentConsoleLine();
                            Console.WriteLine("Changes saved!");
                        }
                        Console.WriteLine(); // for nice formatting
                        break;

                    case 2:
                        Console.WriteLine("Editing test file size (leave blank for current)");
                        Console.WriteLine("INFO: This number will be the size of test files in MB");
                        Console.WriteLine("Current: " + config.FileSize);
                        Console.Write("New: ");
                        string newdata2 = Console.ReadLine();
                        if (newdata2 == "" || newdata2 == " ") { Console.WriteLine("Canceled!"); }
                        else
                        {
                            if (Convert.ToInt32(newdata2) < 1) { newdata2 = "1"; Console.WriteLine("INFO: Your input was autocorrected to 1 MB because the size cannot be samller than 1 MB"); }

                            Console.Write("Saving ...");
                            config.FileSize = Convert.ToInt32(newdata2);
                            SaveConfig(config);
                            ClearCurrentConsoleLine();
                            Console.WriteLine("Changes saved!");
                        }
                        Console.WriteLine(); // for nice formatting
                        break;

                    case 3:
                        Console.WriteLine("Editing automatic cleanup of test files (leave blank for current)");
                        Console.WriteLine("INFO: This setting can only be 'true' or 'false'");
                        Console.WriteLine("Current: " + config.AutoClean);
                        Console.Write("New: ");
                        string newdata3 = Console.ReadLine();
                        if (newdata3 == "" || newdata3 == " ") { Console.WriteLine("Canceled!"); }
                        else
                        {
                            if (newdata3 == "true" || newdata3 == "True")
                            {
                                Console.Write("Saving ...");
                                config.AutoClean = true;
                                SaveConfig(config);
                                ClearCurrentConsoleLine();
                                Console.WriteLine("Changes saved!");
                            }
                            else if (newdata3 == "false" || newdata3 == "False")
                            {
                                Console.Write("Saving ...");
                                config.AutoClean = false;
                                SaveConfig(config);
                                ClearCurrentConsoleLine();
                                Console.WriteLine("Changes saved!");
                            }
                            else if (newdata3 != "true" && newdata3 != "false") { Console.WriteLine("Error: Invalid input"); }
                        }
                        Console.WriteLine(); // for nice formatting
                        break;

                    case 4:
                        // end menu loop to fall back to main menu
                        AllowExit = true;
                        break;
                }
            }
        }

        private void ClearCurrentConsoleLine() // clone from Program.cs but non-static
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}

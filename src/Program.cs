using System;

namespace ConstantWrite
{
    class Program
    {
        public static bool AllowExit = false;
        public const string GitHubLink = "https://github.com/Lukas34/ConstantWrite";

        static void Main()
        {
            // welcome
            Console.WriteLine("Constant Write v0.0.2 PRE-RELEASE");
            Console.WriteLine("Copyright 2019 Lukas Langrock. All rights reserved.");
            Console.WriteLine("This is an open-source project available on GitHub: " + GitHubLink);
            Console.WriteLine(System.Environment.NewLine + "THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE." + System.Environment.NewLine);

            // return back to menu loop
            while (AllowExit == false)
            {
                // menu
                Console.WriteLine("[----- Menu -----]");
                Console.WriteLine("1. Start torture test");
                Console.WriteLine("2. Edit configuration");
                Console.WriteLine("3. Goodbye");
                Console.WriteLine();
                string menu_pool = "123";
                string menu_selection = "#";

                // ask what to start
                while (!menu_pool.Contains(menu_selection))
                {
                    ClearCurrentConsoleLine();
                    Console.Write("What do you want to do? Number: ");
                    menu_selection = Console.ReadKey().KeyChar.ToString();
                }

                Console.WriteLine(System.Environment.NewLine); // for nice formatting
                StartProcess(Convert.ToInt32(menu_selection)); // handle menu selection
            }
        }

        static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        static void StartProcess(int id)
        {
            switch (id)
            {
                case 1:
                    // not implemented yet
                    break;

                case 2:
                    // open config manager
                    Config config = new Config();
                    config.OpenConfigEditor();
                    break;

                case 3:
                    Console.WriteLine("Goodbye!"); // show goodbye message
                    System.Threading.Thread.Sleep(500); // wait so the user can actually see the goodbye message
                    AllowExit = true; // end menu loop to exit
                    break;

                default:
                    Console.WriteLine("Sorry, this looks like an internal error :(");
                    break;
            }
        }
    }
}

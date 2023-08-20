
namespace TarotReading_Labb1
{
    internal class Menu
    {
        private int _menuSelect;
        private string[] _options;
        private string _prompt;

        public Menu(string prompt, string[] options)
        {
            this._prompt = prompt;
            this._options = options;
            this._menuSelect = 0;
        }

        private void DisplayOptions()
        {
            Application app = new Application();
            app.WriteLogo();

            // Shows the promt you've chosen to display in the constructor
            Console.WriteLine(_prompt);

            for (int i = 0; i < _options.Length; i++)
            {
                string menuOptions = _options[i];

                // Highlights the selected option in the menu
                if (i == _menuSelect)
                {
                    Console.ForegroundColor = Color.Black;
                    Console.BackgroundColor = Color.Coral;
                    Console.WriteLine($"<< {menuOptions} >>");
                }
                else
                {
                    Console.ForegroundColor = Color.White;
                    Console.BackgroundColor = Color.Black;
                    Console.WriteLine(menuOptions);
                }

                Console.ResetColor();
            }
        }

        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    _menuSelect--;
                    if (_menuSelect == -1)
                    {
                        _menuSelect = _options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    _menuSelect++;
                    if (_menuSelect == _options.Length)
                    {
                        _menuSelect = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return _menuSelect;
        }
    }
}

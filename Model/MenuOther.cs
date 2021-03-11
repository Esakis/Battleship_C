using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Model
{
    class MenuOther
    {
        public readonly string Logo = "\n     #####################################\n" +
                                       "     ###########   Battleship  ###########\n" +
                                       "     #####################################\n\n" +
                                       "                 AI Level              \n";

        public int Position { get; set; }

        public MenuOther()
        {
            this.Position = 0;
        }

        public readonly string[] Options =
        {
            "         <  Computer Player Easy  >",
            "         < Computer Player Normal >",
            "         <  Computer Player Hard  >"

        };


        public void Run()
        {
            Console.Title = "                  ----------------   Battleship    -------------------";
            Console.CursorVisible = false;
            while (true)
            {
                Display.PrintMenu(this);
                Navigate();
                HandleOptions();
            }
        }

        private void Navigate()
        {
            do
            {
                ConsoleKeyInfo arrow1 = Console.ReadKey();
                if (arrow1.Key == ConsoleKey.LeftArrow)
                {
                    Position = (Position > 0) ? Position - 1 : Options.Length - 1;
                    Display.PrintMenu(this);
                }
                else if (arrow1.Key == ConsoleKey.RightArrow)
                {
                    Position = (Position + 1) % Options.Length;
                    Display.PrintMenu(this);
                }
                else if (arrow1.Key == ConsoleKey.Escape)
                {
                    Position = Options.Length - 1;
                    break;
                }
                else if (arrow1.Key == ConsoleKey.Enter)
                    break;

            }
            while (true);
        }

        private void HandleOptions()
        {
            switch (Position)
            {
                case 0:
                    Menu menu = new Menu();
                    menu.Run();
                    break;
                case 1:
                    Menu menu1 = new Menu();
                    menu1.Run();
                    break;
                case 2:
                    Menu menu2 = new Menu();
                    menu2.Run();
                    break;
            }
        }
    }
}

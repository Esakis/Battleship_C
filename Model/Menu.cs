using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Model
{
    public class Menu
    {
        public readonly string Logo = "\n     #####################################\n" +
                                       "     ###########   Battleship  ###########\n" +
                                       "     #####################################\n\n" +
                                       "                 CHOOSE GAME              \n";

        public int Position { get; set; }
        public Menu()
        {
            this.Position = 0;
        }


        public readonly string[] Options =
        {
            "                 Play 1 on 1",
            "              Play with Computer",
            "             Choose size of board",
            "               Choose AI level",
            "                    Exit"
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
                if (arrow1.Key == ConsoleKey.UpArrow)
                {
                    Position = (Position > 0) ? Position - 1 : Options.Length - 1;
                    Display.PrintMenu(this);
                }
                else if (arrow1.Key == ConsoleKey.DownArrow)
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
                    // Play 1 to 1
                    Console.Clear();
                    Game standardGame = new Game(GameMode.Standard);
                    standardGame.Play();
                    //Input input = new Input();
                    //input.ReturnToMenu();
                    break;
                case 1:
                    // Play with Computer
                    //   Game gameWithComputer = new Game(GameMode.AI);
                    //   gameWithComputer.Play();
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

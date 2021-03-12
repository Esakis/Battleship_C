using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Model
{
    public class Input
    {
        public void ReturnToMenu()
        {
            Console.WriteLine("\n\n\n     Press X - Exit Game \n     Press Z - Return To Menu ");
            do
            {
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.Z)
                {
                    Menu menu = new Menu();
                    menu.Run();
                }
                else if (button.Key == ConsoleKey.X)
                {
                    Environment.Exit(0);
                    break;
                }

            } while (true);
        }


    }
}
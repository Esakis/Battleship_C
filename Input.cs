using System;
using System.Collections.Generic;
using System.Text;
using Battleship.Enums;

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


        public static Move GetMove()
        {
            var move = Console.ReadKey();
            switch (move.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    return Move.Up;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    return Move.Right;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    return Move.Down;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    return Move.Left;
                case ConsoleKey.Enter:
                    return Move.Accept;
                default:
                    return Move.None;
            }
        }
    }
}
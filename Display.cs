using System;
using Battleship.Model;


namespace Battleship
{
    public class Display
    {
        public static void PrintMenu(Menu menu)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine(menu.Logo);
            for (int i = 0; i < menu.Options.Length; i++)
            {
                if (i == menu.Position)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0, -48}", menu.Options[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.WriteLine(menu.Options[i]);
                }
            }
        }

        internal static void PrintMenu(MenuOther menuOther)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine(menuOther.Logo);
            for (int i = 0; i < menuOther.Options.Length; i++)
            {
                if (i == menuOther.Position)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0, -48}", menuOther.Options[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }
        }

        public static void Playground(Board blueboard)
        {
            char top = 'A';
            int left = blueboard.Size;

            Console.Write(Environment.NewLine + Environment.NewLine);
            for (int j = 0; j < blueboard.Size + 1; j++)
                if (j == 0)
                    Console.Write("            ");
                else
                {
                    Console.Write("" + top + "  ");
                    top++;
                }

            Console.WriteLine();
            for (int i = 0; i < blueboard.Size; i++)
            {
                Console.Write("       " + left + "   |");
                left--;
                for (int j = 0; j < blueboard.Size; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.BackgroundColor = Board.blueCage;
                        Console.Write("  |");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = Board.darkCage;
                        Console.Write("  |");
                        Console.ResetColor();
                    }
                }

                Console.WriteLine();
            }

            return;
        }

        public static void Results(Player winner)
        {
            throw new System.NotImplementedException();
        }
    }
}
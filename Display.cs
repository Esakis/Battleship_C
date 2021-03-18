using System;
using Battleship.Model;


namespace Battleship
{
    public static class Display
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

        public static void Playground(Board player1Board, Board player2Board)
        {
            PrintBoard(player1Board);
            PrintBoard(player2Board);
        }

        private static void PrintBoard(Board board)
        {
            char top = 'A';
            int left = board.Size;

            Console.Write(Environment.NewLine + Environment.NewLine);
            for (int j = 0; j < board.Size + 1; j++)
                if (j == 0)
                    Console.Write("            ");
                else
                {
                    Console.Write("" + top + "  ");
                    top++;
                }

            Console.WriteLine();
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("       " + left + "   |");
                left--;
                for (int j = 0; j < board.Size; j++)
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
                Console.Write("\n");
            }
        }
        
        public static void PlaygroundShowShips(Board player1Board, Board player2Board)
        {
            PrintBoardWithShips(player1Board);
            PrintBoardWithShips(player2Board);
        }

        private static void PrintBoardWithShips(Board board)
        {
            char top = 'A';
            int left = board.Size;

            Console.Write(Environment.NewLine + Environment.NewLine);
            for (int j = 0; j < board.Size + 1; j++)
                if (j == 0)
                    Console.Write("            ");
                else
                {
                    Console.Write("" + top + "  ");
                    top++;
                }

            Console.WriteLine();
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("       " + left + "   |");
                left--;
                for (int j = 0; j < board.Size; j++)
                {
                    var mark = GetMark(board, j, i);
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
                Console.Write("\n");
            }
        }

        private static string GetMark(Board board, int i, int j)
        {
            throw new NotImplementedException();
        }

        public static void Results(Player winner)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System;
using System.Linq;
using System.Threading.Channels;
using Battleship.Enums;
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
            char topHeader = 'A';
            int leftHeader = board.Size;

            Console.Write(Environment.NewLine + Environment.NewLine);
            for (int j = 0; j < board.Size + 1; j++)
                if (j == 0)
                    Console.Write("            ");
                else
                {
                    Console.Write("" + topHeader + "  ");
                    topHeader++;
                }

            Console.WriteLine();
            for (int i = 0; i < board.Size; i++)
            {
                Console.Write("       " + leftHeader + "   |");
                leftHeader--;
                for (int j = 0; j < board.Size; j++)
                {
                    var mark = GetMark(board, i, j);

                    if (i % 2 == 0)
                    {
                        if (board.SelectedField.Equals(new Point2D(j, i)))
                            Console.BackgroundColor = ConsoleColor.Green;
                        else
                            Console.BackgroundColor = Board.blueCage;
                        Console.Write($"{mark} |");
                        Console.ResetColor();
                    }
                    else
                    {
                        if (board.SelectedField.Equals(new Point2D(j, i)))
                            Console.BackgroundColor = ConsoleColor.Green;
                        else
                            Console.BackgroundColor = Board.darkCage;
                        Console.Write($"{mark} |");
                        Console.ResetColor();
                    }
                }

                Console.Write("\n");
            }
        }

        private static string GetMark(Board board, int i, int j)
        {
            if (board.Ocean[i, j].Status == SquareStatus.Hit)
            {
                return Square.statusCharacters[SquareStatus.Hit];
            }

            if (board.Ocean[i, j].Status == SquareStatus.Missed)
            {
                return Square.statusCharacters[SquareStatus.Missed];
            }

            if (board.Ocean[i, j].Status == SquareStatus.Ship)
            {
                return Square.statusCharacters[SquareStatus.Ship];
            }

            if (board.Ocean[i, j].Status == SquareStatus.Empty)
            {
                return Square.statusCharacters[SquareStatus.Empty];
            }

            return " ";
        }

        public static void TwoBoardHorizontally(
            Player player1,
            Player player2,
            Player currentPlayer,
            int offsetBetween = 5,
            int offsetAround = 3)
        {
            int leftHeaderNum = player1.Board.Size;

            // TOP OFFSET
            Console.Clear();
            Console.ResetColor();
            Console.Write(String.Concat(Enumerable.Repeat("\n", offsetAround)));

            // TOP HEADER
            if (currentPlayer == player1)
                DisplayOwner(player1, offsetAround, true);
            else
                DisplayOwner(player1, offsetAround);

            Console.Write("           ");
            if (currentPlayer == player2)
                DisplayOwner(player2, offsetAround, true);
            else
                DisplayOwner(player2, offsetAround);
            Console.WriteLine();
            DisplayHeader(player1, offsetAround);
            DisplayHeader(player2, offsetAround);
            Console.WriteLine();


            // ROWS
            string leftOffset = String.Concat(Enumerable.Repeat("\n", offsetAround));
            for (int i = 0; i < player1.Board.Size; i++)
            {
                if (currentPlayer == player1)
                    DisplayRow(player1, ref leftHeaderNum, i, offsetAround, false);
                else
                    DisplayRow(player1, ref leftHeaderNum, i, offsetAround, true);

                if (currentPlayer == player2)
                    DisplayRow(player2, ref leftHeaderNum, i, offsetAround, false);
                else
                    DisplayRow(player2, ref leftHeaderNum, i, offsetAround, true);

                leftHeaderNum--;
                Console.Write("\n");
            }

            Console.WriteLine();
            Console.WriteLine("LEGEND: ");
            Console.WriteLine("● Ship");
            Console.WriteLine("○ Missed");
            Console.WriteLine("x Hit");
        }

        private static void DisplayOwner(Player player, int offsetAround, bool currentPlayer = false)
        {
            if (currentPlayer)
                Console.BackgroundColor = ConsoleColor.Green;

            string leftOffset = "    " + String.Concat(Enumerable.Repeat(" ", offsetAround));

            Console.Write(leftOffset + $"Board of {player.Name}");
            Console.ResetColor();
        }

        private static void DisplayHeader(Player player, int offsetAround)
        {
            char topHeaderLetter = 'A';

            string topHeader = " ";
            topHeader += String.Concat(Enumerable.Repeat(" ", offsetAround));
            for (int j = 0; j < player.Board.Size + 1; j++)
            {
                if (j == 0)
                    topHeader += "   ";
                else
                {
                    if (j == player.Board.Size)
                        topHeader += topHeaderLetter++ + " ";
                    else
                        topHeader += topHeaderLetter++ + "  ";
                }
            }

            Console.Write(topHeader);
        }

        private static void DisplayRow(Player player1, ref int leftHeaderNum, int i, int offsetAround,
            bool showSelector)
        {
            string leftOffset = String.Concat(Enumerable.Repeat(" ", offsetAround));
            Console.Write(leftOffset + leftHeaderNum + " ");
            for (int j = 0; j < player1.Board.Size; j++)
            {
                var mark = GetMark(player1.Board, i, j);

                if (i % 2 == 0)
                {
                    Console.BackgroundColor = Board.blueCage;
                    if (j == 0)
                        Console.Write("|");
                    if (showSelector)
                    {
                        Console.BackgroundColor = player1.Board.SelectedField.Equals(new Point2D(j, i))
                            ? ConsoleColor.Green
                            : Board.blueCage;
                    }

                    Console.Write($"{mark} ");
                    Console.BackgroundColor = Board.blueCage;
                    Console.Write("|");
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = Board.darkCage;
                    if (j == 0)
                        Console.Write("|");
                    if (showSelector)
                    {
                        Console.BackgroundColor = player1.Board.SelectedField.Equals(new Point2D(j, i))
                            ? ConsoleColor.Green
                            : Board.darkCage;
                    }

                    Console.Write($"{mark} ");
                    Console.BackgroundColor = Board.darkCage;
                    Console.Write("|");
                    Console.ResetColor();
                }
            }
        }

        public static void Results(Player winner)
        {
            throw new System.NotImplementedException();
        }
    }
}
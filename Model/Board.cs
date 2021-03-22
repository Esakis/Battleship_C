using System;
using Battleship.Model.Enums;

namespace Battleship.Model
{
    public class Board
    {

        public int Size { get; }
        public const ConsoleColor blueCage = ConsoleColor.Blue;
        public const ConsoleColor darkCage = ConsoleColor.DarkBlue;
        public Square[,] Ocean { get; }
        public Point2D SelectedField { get; set; }
        
        public Board(int size)
        {
            this.Size = size;
            
            Ocean = new Square[this.Size, this.Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Ocean[i, j] = new Square(new Point2D(j, i));
                }
            }

        }
        
        public void CheckField()
        {
            // TODO add statements for SquareStatus.Hit
            if (Ocean[SelectedField.Y, SelectedField.X].Ship != null)
            {
                Ocean[SelectedField.Y, SelectedField.X].Status = SquareStatus.Ship;
            }
            else
            {
                Ocean[SelectedField.Y, SelectedField.X].Status = SquareStatus.Missed;
            }
        }

        private bool IsPlacementOk()
        {
            throw new NotImplementedException();
        }

    }
}
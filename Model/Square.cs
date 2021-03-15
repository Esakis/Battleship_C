using System.Collections.Generic;
using Battleship.Enums;

namespace Battleship.Model
{
    public class Square
    {
        public readonly Dictionary<SquareStatus, string> statusCharacters = new Dictionary<SquareStatus, string>
        {
            {SquareStatus.Empty, " "},
            {SquareStatus.Hit, "x"},
            {SquareStatus.Missed, "○"},
            {SquareStatus.Ship, "●"}
        };
        public Square(Point2D position, SquareStatus status = SquareStatus.Empty)
        {
            Position = position;
            Status = status;
        }

        public Point2D Position { get; }
        public SquareStatus Status { get; set; }
        public Ship Ship { get; set; }
    }
}
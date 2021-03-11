using Battleship.Enums;

namespace Battleship.Model
{
    public struct Square
    {
        public Square(Point2D position, Ship ship, SquareStatus status = SquareStatus.Empty)
        {
            Position = position;
            Status = status;
            Ship = ship;
        }

        public Point2D Position;
        public SquareStatus Status;
        public Ship Ship;
    }
}
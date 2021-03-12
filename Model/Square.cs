using Battleship.Enums;

namespace Battleship.Model
{
    public struct Square
    {
        public Square(Point2D position, SquareStatus status = SquareStatus.Empty)
        {
            Position = position;
            Status = status;
            Ship = default;
        }

        public Point2D Position { get; }
        public SquareStatus Status { get; }
        public Ship Ship { get; set; }
    }
}
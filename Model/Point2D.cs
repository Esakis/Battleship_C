namespace Battleship.Model
{
    public class Point2D
    {
        public Point2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public bool Equals(Point2D other)
        {
            return this.X == other.X && this.Y == other.Y;
        }
    }
}
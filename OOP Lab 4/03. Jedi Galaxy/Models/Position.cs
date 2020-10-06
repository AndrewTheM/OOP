namespace JediGalaxy.Models
{
    public struct Position
    {
        public int X;
        public int Y;

        public Position(int x, int y) => (X, Y) = (x, y);

        public (int x, int y) Deconstruct() => (X, Y);
    }
}

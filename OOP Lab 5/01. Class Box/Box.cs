namespace ClassBox
{
    public class Box
    {
        private readonly double length;
        private readonly double width;
        private readonly double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetSurfaceArea()
            => GetLateralSurfaceArea() + length * width * 2;

        public double GetLateralSurfaceArea()
            => height * 2 * (length + width);

        public double GetVolume()
            => length * width * height;
    }
}

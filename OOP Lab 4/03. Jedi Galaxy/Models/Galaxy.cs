using System;

namespace JediGalaxy.Models
{
    public class Galaxy
    {
        private Position jediPosition;
        private Position forcePosition;

        public Star[,] Stars { get; }

        public Galaxy(int rows, int cols)
        {
            Stars = new Star[rows, cols];

            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                    Stars[i, j] = new Star(i * rows + j);
        }

        public void PlaceJedi(int starX, int starY)
            => jediPosition = new Position(starX - 1, starY - 1);

        public void PlaceForce(int starX, int starY)
            => forcePosition = new Position(starX - 1, starY - 1);

        public int CollectStars()
        {
            if (jediPosition == null || forcePosition == null)
                throw new Exception("Either Jedi or Force is not in the galaxy");

            ActivateForce();

            int sum = 0;
            var (x, y) = jediPosition.Deconstruct();

            while (x >= 0 && y < Stars.GetLength(1))
            {
                var star = Stars[x--, y++];

                if (!star.IsDestroyed)
                    sum += star.Value;
            }

            return sum;
        }

        protected void ActivateForce()
        {
            var (x, y) = forcePosition.Deconstruct();

            while (x >= 0 && y >= 0)
                Stars[x--, y--].IsDestroyed = true;
        }
    }
}

﻿namespace JediGalaxy.Models
{
    public class Position
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Position(int x, int y) => (X, Y) = (x, y);

        public (int x, int y) Deconstruct() => (X, Y);
    }
}

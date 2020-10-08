using System;

namespace Sneaking.Models
{
    public class Room
    {
        private Position playerPosition;

        public char[][] Fields { get; }

        public Room(string[] roomRows)
        {
            Fields = new char[roomRows.Length][];

            for (int i = 0; i < Fields.Length; ++i)
            {
                Fields[i] = roomRows[i].ToCharArray();

                if (playerPosition == null)
                {
                    for (int j = 0; j < Fields[i].Length; ++j)
                        if (Fields[i][j] == 'S')
                        {
                            playerPosition = new Position(j, i);
                            break;
                        }
                }
            }
        }

        private void MoveEnemies()
        {
            var (x, y) = playerPosition.Deconstruct();

            for (int i = 0; i < Fields.Length; ++i)
                for (int j = 0; j < Fields[i].Length; ++j)
                    if (Fields[i][j] == 'b')
                    {
                        if (j < x && i == y)
                        {
                            Fields[y][x] = 'X';
                            throw new Exception($"Sam died at {y}, {x}");
                        }

                        if (j < Fields[i].Length - 1)
                            (Fields[i][j], Fields[i][j + 1]) = (Fields[i][j + 1], Fields[i][j]);
                        
                        if (j >= Fields[i].Length - 1)
                            Fields[i][^1] = 'd';
                            
                        break;
                    }
                    else if (Fields[i][j] == 'd')
                    {
                        if (j > x && i == y)
                        {
                            Fields[y][x] = 'X';
                            throw new Exception($"Sam died at {y}, {x}");
                        }

                        if (j > 0)
                            (Fields[i][j], Fields[i][j - 1]) = (Fields[i][j - 1], Fields[i][j]);
                        
                        if (j <= 0)
                            Fields[i][0] = 'b';

                        break;
                    }
        }

        private void MovePlayer(Direction direction)
        {
            var (x, y) = playerPosition.Deconstruct();

            switch (direction)
            {
                case Direction.Up:
                    {
                        if (y != 0)
                        {
                            if (Fields[y - 1][x] == 'b' || Fields[y - 1][x] == 'd')
                            {
                                Fields[y - 1][x] = '.';
                            }

                            (Fields[y][x], Fields[y - 1][x]) = (Fields[y - 1][x], Fields[y][x]);
                            playerPosition.Y -= 1;
                        }
                        break;
                    }
                case Direction.Down:
                    {
                        if (y != Fields.Length - 1)
                        {
                            if (Fields[y + 1][x] == 'b' || Fields[y + 1][x] == 'd')
                            {
                                Fields[y + 1][x] = '.';
                            }

                            (Fields[y][x], Fields[y + 1][x]) = (Fields[y + 1][x], Fields[y][x]);
                            playerPosition.Y += 1;
                        }
                        break;
                    }
                case Direction.Left:
                    {
                        if (x != 0)
                        {
                            (Fields[y][x], Fields[y][x - 1]) = (Fields[y][x - 1], Fields[y][x]);
                            playerPosition.X -= 1;
                        }
                        break;
                    }
                case Direction.Right:
                    {
                        if (x != Fields[y].Length - 1)
                        {
                            (Fields[y][x], Fields[y][x + 1]) = (Fields[y][x + 1], Fields[y][x]);
                            playerPosition.X += 1;
                        }
                        break;
                    }
                case Direction.Wait: return;
            }

            y = playerPosition.Y;

            for (int i = 0; i < Fields[y].Length; ++i)
                if (Fields[y][i] == 'N')
                {
                    Fields[y][i] = 'X';
                    throw new Exception("Nikoladze killed!");
                }
        }

        public void TakeTurn(Direction playerDirection)
        {
            MoveEnemies();
            MovePlayer(playerDirection);
        }
    }
}

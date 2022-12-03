namespace AdventOfCode2022_2
{
    public static class StrategyShapeConverter
    {
        public static GameShape ConvertPlayer1Shape(string shape)
        {
            switch (shape.ToLower())
            {
                case "a":
                    return GameShape.Rock;
                case "b":
                    return GameShape.Paper;
                case "c":
                    return GameShape.Scissors;
                default:
                    throw new ArgumentException($"Invalid shape {shape}");
            }
        }

        public static GameShape ConvertPlayer2Shape(string shape)
        {
            switch (shape.ToLower())
            {
                case "x":
                    return GameShape.Rock;
                case "y":
                    return GameShape.Paper;
                case "z":
                    return GameShape.Scissors;
                default:
                    throw new ArgumentException($"Invalid shape {shape}");
            }
        }

        public static GameShape ConvertPlayer2ShapeAlternate(GameShape player1Shape, string code)
        {
            switch (code.ToLower())
            {
                case "x":
                    return PickLosingShape(player1Shape);
                case "y":
                    return player1Shape;
                case "z":
                    return PickWinningShape(player1Shape);
                default:
                    throw new ArgumentException($"Invalid shape {code}");
            }
        }

        private static GameShape PickWinningShape(GameShape player1Shape)
        {
            switch (player1Shape)
            {
                case GameShape.Rock:
                    return GameShape.Paper;
                case GameShape.Paper:
                    return GameShape.Scissors;
                case GameShape.Scissors:
                    return GameShape.Rock;
                default:
                    throw new ArgumentException($"Invalid shape {player1Shape}");
            }
        }

        private static GameShape PickLosingShape(GameShape player1Shape)
        {
            switch (player1Shape)
            {
                case GameShape.Rock:
                    return GameShape.Scissors;
                case GameShape.Paper:
                    return GameShape.Rock;
                case GameShape.Scissors:
                    return GameShape.Paper;
                default:
                    throw new ArgumentException($"Invalid shape {player1Shape}");
            }
        }
    }
}

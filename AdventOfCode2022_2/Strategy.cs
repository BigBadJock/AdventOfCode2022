using Ardalis.GuardClauses;

namespace AdventOfCode2022_2
{
    public class Strategy
    {

        public Strategy(string filename, bool useAlternateStrategy = false)
        {
            Guard.Against.NullOrEmpty(filename, nameof(filename));
            this.Tournament = new Tournament();
            LoadFile(filename, useAlternateStrategy);
        }



        private void LoadFile(string filename, bool useAlternateStrategy)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException($"File {filename} not found.");
            }

            string[] lines = File.ReadAllLines(filename);
            this.Tournament = new Tournament();

            foreach (string line in lines)
            {
                var values = line.Split(' ');
                GameShape player1Shape = StrategyShapeConverter.ConvertPlayer1Shape(values[0]);
                GameShape player2Shape;
                if (!useAlternateStrategy)
                {
                    player2Shape = StrategyShapeConverter.ConvertPlayer2Shape(values[1]);
                }
                else
                {
                    player2Shape = StrategyShapeConverter.ConvertPlayer2ShapeAlternate(player1Shape, values[1]);
                }
                this.Tournament.AddRound(player1Shape, player2Shape);
            }
            this.IsLoaded = true;
        }



        public bool IsLoaded { get; private set; }
        public Tournament Tournament { get; private set; }
    }
}

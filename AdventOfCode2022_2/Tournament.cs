namespace AdventOfCode2022_2
{
    public class Tournament
    {
        public List<Round> Rounds { get; private set; }
        public int Player1TotalScore
        {
            get
            {
                return Rounds.Sum(r => r.Player1Score);
            }
        }

        public int Player2TotalScore
        {
            get
            {
                return Rounds.Sum(r => r.Player2Score);
            }
        }

        public string Winner
        {
            get
            {
                if (Player1TotalScore > Player2TotalScore)
                {
                    return "Player 1";
                }
                else if (Player2TotalScore > Player1TotalScore)
                {
                    return "Player 2";
                }
                else
                {
                    return "Draw";
                }
            }
        }

        public Tournament()
        {
            Rounds = new List<Round>();
        }

        public void AddRound(GameShape player1Shape, GameShape player2Shape)
        {
            Round round = new Round(player1Shape, player2Shape);
            Rounds.Add(round);
        }
    }
}

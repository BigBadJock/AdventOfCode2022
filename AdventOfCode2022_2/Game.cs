namespace AdventOfCode2022_2
{
    public enum GameShape
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }

    public enum GameScore
    {
        Lose = 0,
        Draw = 3,
        Win = 6
    }


    public class Game
    {
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public void Play(GameShape player1Shape, GameShape player2Shape)
        {
            if (player1Shape == player2Shape)
            {
                int score = (int)GameScore.Draw + (int)player1Shape;
                Player1Score = score;
                Player2Score = score;
                return;
            }

            if (IsPlayer1Winner(player1Shape, player2Shape))
            {
                Player1Score = (int)GameScore.Win + (int)player1Shape;
                Player2Score = (int)GameScore.Lose + (int)player2Shape;
            }
            else
            {
                Player1Score = (int)GameScore.Lose + (int)player1Shape;
                Player2Score = (int)GameScore.Win + (int)player2Shape;
            }
        }

        private bool IsPlayer1Winner(GameShape player1Shape, GameShape player2Shape)
        {
            bool win = false;
            if (player1Shape == GameShape.Paper && player2Shape == GameShape.Rock)
            {
                win = true;
            }
            if (player1Shape == GameShape.Scissors && player2Shape == GameShape.Paper)
            {
                win = true;
            }
            if (player1Shape == GameShape.Rock && player2Shape == GameShape.Scissors)
            {
                win = true;
            }
            return win;
        }
    }
}

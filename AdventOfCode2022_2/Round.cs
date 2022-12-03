namespace AdventOfCode2022_2
{
    public class Round
    {
        public Round()
        {
            Player1Shape = GameShape.Rock;
            Player2Shape = GameShape.Rock;
            Player1Score = 0;
            Player2Score = 0;
        }

        public Round(GameShape player1Shape, GameShape player2Shape)
        {
            this.Player1Shape = player1Shape;
            this.Player2Shape = player2Shape;
            Game game = new Game();
            game.Play(player1Shape, player2Shape);
            Player1Score = game.Player1Score;
            Player2Score = game.Player2Score;
        }

        public GameShape Player1Shape { get; set; }
        public GameShape Player2Shape { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
    }
}

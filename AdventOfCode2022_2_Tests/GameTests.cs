namespace AdventOfCode2022_2_Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void ScoreTest_IsDraw_Rock()
        {
            var game = new Game();
            game.Play(GameShape.Rock, GameShape.Rock);
            Assert.AreEqual(game.Player1Score, game.Player2Score);
            Assert.AreEqual(4, game.Player1Score);
        }

        [TestMethod]
        public void ScoreTest_IsDraw_Paper()
        {
            var game = new Game();
            game.Play(GameShape.Paper, GameShape.Paper);
            Assert.AreEqual(game.Player1Score, game.Player2Score);
            Assert.AreEqual(5, game.Player1Score);
        }

        [TestMethod]
        public void ScoreTest_IsDraw_Scissors()
        {
            var game = new Game();
            game.Play(GameShape.Scissors, GameShape.Scissors);
            Assert.AreEqual(game.Player1Score, game.Player2Score);
            Assert.AreEqual(6, game.Player1Score);
        }

        [TestMethod]
        public void ScoreTest_Player1_Wins_Rock()
        {
            var game = new Game();
            game.Play(GameShape.Rock, GameShape.Scissors);
            Assert.AreEqual(7, game.Player1Score);
            Assert.AreEqual(3, game.Player2Score);
        }

        [TestMethod]
        public void ScoreTest_Player1_Wins_Paper()
        {
            var game = new Game();
            game.Play(GameShape.Paper, GameShape.Rock);
            Assert.AreEqual(8, game.Player1Score);
            Assert.AreEqual(1, game.Player2Score);
        }

        [TestMethod]
        public void ScoreTest_Player1_Wins_Scissors()
        {
            var game = new Game();
            game.Play(GameShape.Scissors, GameShape.Paper);
            Assert.AreEqual(9, game.Player1Score);
            Assert.AreEqual(2, game.Player2Score);
        }

    }
}
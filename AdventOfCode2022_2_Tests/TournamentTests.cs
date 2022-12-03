namespace AdventOfCode2022_2_Tests
{

    [TestClass]
    public class TournamentTests
    {
        private Tournament tournament;

        [TestInitialize]
        public void Setup()
        {
            tournament = new Tournament();
        }

        [TestMethod]
        public void TournamentExistsTest()
        {
            Assert.IsNotNull(tournament);
        }

        [TestMethod]
        public void TournamentHasRounds()
        {
            Assert.IsNotNull(tournament.Rounds);
            Assert.IsInstanceOfType(tournament.Rounds, typeof(List<Round>));
        }

        [TestMethod]
        public void TournamentAddGame()
        {
            Assert.AreEqual(0, tournament.Rounds.Count);
            tournament.AddRound(GameShape.Rock, GameShape.Paper);
            Assert.AreEqual(1, tournament.Rounds.Count);
        }

        [TestMethod]
        public void TournamentTotalsTest()
        {
            Assert.AreEqual(0, tournament.Rounds.Count);
            tournament.AddRound(GameShape.Rock, GameShape.Paper);
            tournament.AddRound(GameShape.Rock, GameShape.Paper);
            Assert.AreEqual(2, tournament.Rounds.Count);
            Assert.AreEqual(2, tournament.Player1TotalScore);
            Assert.AreEqual(16, tournament.Player2TotalScore);
        }

        [TestMethod]
        public void TournamentCheckWinner_Player2()
        {
            Assert.AreEqual(0, tournament.Rounds.Count);
            tournament.AddRound(GameShape.Rock, GameShape.Paper);
            tournament.AddRound(GameShape.Rock, GameShape.Paper);
            Assert.AreEqual("Player 2", tournament.Winner);
        }

        [TestMethod]
        public void TournamentCheckWinner_Player1()
        {
            Assert.AreEqual(0, tournament.Rounds.Count);
            tournament.AddRound(GameShape.Scissors, GameShape.Paper);
            tournament.AddRound(GameShape.Scissors, GameShape.Paper);
            Assert.AreEqual("Player 1", tournament.Winner);
        }

        [TestMethod]
        public void TournamentCheckWinner_Draw()
        {
            Assert.AreEqual(0, tournament.Rounds.Count);
            tournament.AddRound(GameShape.Scissors, GameShape.Scissors);
            tournament.AddRound(GameShape.Scissors, GameShape.Scissors);
            Assert.AreEqual("Draw", tournament.Winner);

        }



    }
}

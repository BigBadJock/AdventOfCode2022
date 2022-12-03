namespace AdventOfCode2022_2_Tests
{
    [TestClass]
    public class StrategyTests
    {

        [TestMethod]
        public void StrategyCanLoad()
        {
            string fileName = "strategy.txt";
            Strategy strategy = new Strategy(fileName);
            Assert.IsTrue(strategy.IsLoaded);
        }

        [TestMethod]
        public void StrategyTournamentRoundsCount()
        {
            string fileName = "strategy.txt";
            Strategy strategy = new Strategy(fileName);
            Assert.AreEqual(3, strategy.Tournament.Rounds.Count);
        }

        [TestMethod]
        public void StrategyTournamentScores()
        {
            string fileName = "strategy.txt";
            Strategy strategy = new Strategy(fileName);
            Assert.AreEqual(15, strategy.Tournament.Player1TotalScore);
            Assert.AreEqual(15, strategy.Tournament.Player2TotalScore);
            Assert.AreEqual("Draw", strategy.Tournament.Winner);
        }

        [TestMethod]
        public void StrategyCanLoadAlternate()
        {
            string fileName = "strategy.txt";
            Strategy strategy = new Strategy(fileName, true);
            Assert.IsTrue(strategy.IsLoaded);
        }

        [TestMethod]
        public void StrategyAlternateTournamentRoundsCount()
        {
            string fileName = "strategy.txt";
            Strategy strategy = new Strategy(fileName, true);
            Assert.AreEqual(3, strategy.Tournament.Rounds.Count);
        }

        [TestMethod]
        public void StrategyAlternateTournamentScores()
        {
            string fileName = "strategy.txt";
            Strategy strategy = new Strategy(fileName, true);
            Assert.AreEqual(15, strategy.Tournament.Player1TotalScore);
            Assert.AreEqual(12, strategy.Tournament.Player2TotalScore);
            Assert.AreEqual("Player 1", strategy.Tournament.Winner);
        }

    }
}


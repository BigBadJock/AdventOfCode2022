namespace AdventOfCode2022_2_Tests
{
    [TestClass]
    public class RoundTests
    {

        [TestMethod]
        public void NewRoundTest()
        {
            Round round = new Round(GameShape.Rock, GameShape.Paper);
            Assert.AreEqual(round.Player1Shape, GameShape.Rock);
            Assert.AreEqual(round.Player2Shape, GameShape.Paper);
            Assert.AreEqual(round.Player1Score, 1);
            Assert.AreEqual(round.Player2Score, 8);
        }
    }
}

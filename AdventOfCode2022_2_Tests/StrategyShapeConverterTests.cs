namespace AdventOfCode2022_2_Tests
{
    [TestClass]
    public class StrategyShapeConverterTests
    {

        [TestMethod]
        public void TestPlayer1Shape_A_Rock()
        {
            GameShape actual = StrategyShapeConverter.ConvertPlayer1Shape("A");
            Assert.AreEqual(GameShape.Rock, actual);
        }

        [TestMethod]
        public void TestPlayer1Shape_B_Paper()
        {
            GameShape actual = StrategyShapeConverter.ConvertPlayer1Shape("B");
            Assert.AreEqual(GameShape.Paper, actual);
        }

        [TestMethod]
        public void TestPlayer1Shape_C_Scissors()
        {
            GameShape actual = StrategyShapeConverter.ConvertPlayer1Shape("C");
            Assert.AreEqual(GameShape.Scissors, actual);
        }

        [TestMethod]
        public void TestPlayer2Shape_X_Rock()
        {
            GameShape actual = StrategyShapeConverter.ConvertPlayer2Shape("X");
            Assert.AreEqual(GameShape.Rock, actual);
        }

        [TestMethod]
        public void TestPlayer2Shape_Y_Paper()
        {
            GameShape actual = StrategyShapeConverter.ConvertPlayer2Shape("Y");
            Assert.AreEqual(GameShape.Paper, actual);
        }

        [TestMethod]
        public void TestPlayer2Shape_Z_Scissors()
        {
            GameShape actual = StrategyShapeConverter.ConvertPlayer2Shape("Z");
            Assert.AreEqual(GameShape.Scissors, actual);
        }


        [TestMethod]
        public void TestPlayer2ShapeAlternate_Rock_X()
        {
            GameShape actual = StrategyShapeConverter.ConvertPlayer2ShapeAlternate(GameShape.Rock, "X");
            Assert.AreEqual(GameShape.Scissors, actual);
        }

        [TestMethod]
        public void TestPlayer2ShapeAlternate_Rock_Y()
        {
            GameShape actual = StrategyShapeConverter.ConvertPlayer2ShapeAlternate(GameShape.Rock, "Y");
            Assert.AreEqual(GameShape.Rock, actual);
        }

        [TestMethod]
        public void TestPlayer2ShapeAlternate_Rock_Z()
        {
            GameShape actual = StrategyShapeConverter.ConvertPlayer2ShapeAlternate(GameShape.Rock, "Z");
            Assert.AreEqual(GameShape.Paper, actual);
        }


    }
}

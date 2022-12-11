using AdventOfCode2022_8;

namespace AdventOfCode2022_8_Tests
{
    [TestClass]
    public class Forest_Tests
    {
        private Forest forest;

        [TestInitialize]
        public void Setup()
        {
            forest = new Forest("input.txt");

        }

        [DataTestMethod]
        [DataRow(3, 0, 0)]
        [DataRow(0, 4, 4)]
        public void Forest_LoadsFile(int expected, int y, int x)
        {
            Assert.AreEqual(25, forest.Trees.Length);
            Assert.AreEqual(expected, forest.Trees[y, x]);
        }

        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(1, 2)]
        public void TreeIsVisible_true(int y, int x)
        {
            Assert.IsTrue(forest.IsVisible(y, x));
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(1, 3)]
        [DataRow(2, 2)]
        public void TreeIsVisible_false(int y, int x)
        {
            Assert.IsFalse(forest.IsVisible(y, x));
        }

        [TestMethod]
        public void ForestCountVisibleTrees()
        {
            Assert.AreEqual(21, forest.CountVisibleTrees());
        }

        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(0, 0, 1)]
        [DataRow(0, 0, 2)]
        [DataRow(0, 0, 3)]
        [DataRow(0, 0, 4)]

        [DataRow(0, 1, 0)]
        [DataRow(1, 1, 1)] // 1*1*1*1=1
        [DataRow(4, 1, 2)] // 1*0*2*2=4
        [DataRow(1, 1, 3)] // 0 0 0 0
        [DataRow(0, 1, 4)] // 0 1 0 1 = 0

        [DataRow(0, 2, 0)] // 2 *4 *0*2 = 0
        [DataRow(6, 2, 1)] // 1*1*3*2=6
        [DataRow(1, 2, 2)] // 1*1*1*1
        [DataRow(2, 2, 3)] // 2*1*1*1
        [DataRow(0, 2, 4)] // 1*1*0*1



        [DataRow(8, 3, 2)]
        public void CalculateScenicScore(int expected, int y, int x)
        {
            Assert.AreEqual(expected, forest.CalculateScenicScore(y, x));
        }

        [TestMethod]
        public void CalculateHighestScenicScore()
        {
            Assert.AreEqual(8, forest.CalculateHighestScenicScore());
        }

    }
}
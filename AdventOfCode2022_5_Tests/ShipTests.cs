using AdventOfCode2022_5;

namespace AdventOfCode2022_5_Tests
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void StackHasCrates()
        {
            Ship ship = new Ship();
            Assert.IsTrue(ship.CrateStacks != null);
            Assert.IsInstanceOfType(ship.CrateStacks, typeof(List<Stack<Char>>));
        }

        [TestMethod]
        public void CreateStackWithCrates()
        {
            Ship ship = new Ship("NZ");
            Assert.IsTrue(ship.CrateStacks != null);
            Assert.IsInstanceOfType(ship.CrateStacks, typeof(List<Stack<Char>>));
            Assert.AreEqual(1, ship.CrateStacks.Count);
            Assert.AreEqual('Z', ship.CrateStacks[0].Pop());
            Assert.AreEqual('N', ship.CrateStacks[0].Pop());

        }

        [TestMethod]
        public void CreateThreeStackWithCrates()
        {
            Ship stack = new Ship("NZ", "MCD", "P");
            Assert.IsTrue(stack.CrateStacks != null);
            Assert.IsInstanceOfType(stack.CrateStacks, typeof(List<Stack<Char>>));
            Assert.AreEqual(3, stack.CrateStacks.Count);
            Assert.AreEqual('Z', stack.CrateStacks[0].Pop());
            Assert.AreEqual('N', stack.CrateStacks[0].Pop());

            Assert.AreEqual('D', stack.CrateStacks[1].Pop());
            Assert.AreEqual('C', stack.CrateStacks[1].Pop());
            Assert.AreEqual('M', stack.CrateStacks[1].Pop());

            Assert.AreEqual('P', stack.CrateStacks[2].Pop());

        }

    }
}
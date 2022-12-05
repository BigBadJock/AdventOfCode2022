using AdventOfCode2022_5;
namespace AdventOfCode2022_5_Tests
{

    [TestClass]
    public class CraneMover9001Tests
    {

        [TestMethod]
        public void CraneHasAShip()
        {
            Ship ship = new Ship("NZ");
            CraneMover9001 crane = new CraneMover9001(ship);
            Assert.IsNotNull(crane.Ship);
        }

        [TestMethod]
        public void MoveCrateFromStack2ToStack1()
        {
            Ship ship = new Ship("NZ", "MCD", "P");
            CraneMover9001 crane = new CraneMover9001(ship);
            crane.Move(1, 2, 1);
            Assert.AreEqual('D', ship.CrateStacks[0].Pop());
        }


        [TestMethod]
        public void Move3CratesFrom1Stack1ToStack3()
        {
            Ship ship = new Ship("ZN", "MCD", "P");
            CraneMover9001 crane = new CraneMover9001(ship);
            crane.Move(1, 2, 1);
            crane.Move(3, 1, 3);
            Assert.AreEqual(0, ship.CrateStacks[0].Count);
            Assert.AreEqual(4, ship.CrateStacks[2].Count);
            Assert.AreEqual('D', ship.CrateStacks[2].Peek());
        }

        [TestMethod]
        public void FullRun()
        {
            Ship ship = new Ship("ZN", "MCD", "P");
            CraneMover9001 crane = new CraneMover9001(ship);
            crane.Move(1, 2, 1);
            crane.Move(3, 1, 3);
            crane.Move(2, 2, 1);
            crane.Move(1, 1, 2);
            string actual = crane.GetStackTops();
            Assert.AreEqual(1, ship.CrateStacks[0].Count);
            Assert.AreEqual(1, ship.CrateStacks[1].Count);
            Assert.AreEqual(4, ship.CrateStacks[2].Count);
            Assert.AreEqual("MCD", actual);
        }

    }
}

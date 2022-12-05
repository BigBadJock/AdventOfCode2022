using AdventOfCode2022_5;
namespace AdventOfCode2022_5_Tests
{

    [TestClass]
    public class Crane3Tests
    {

        [TestMethod]
        public void CreateWithStacks()
        {
            Crane3 crane = new Crane3("ZN", "MCD", "P");
            Assert.AreEqual(3, crane.Stacks.Length);
            Assert.AreEqual("ZN", crane.Stacks[0]);
            Assert.AreEqual("MCD", crane.Stacks[1]);
            Assert.AreEqual("P", crane.Stacks[2]);
        }


        [TestMethod]
        public void MoveCrateFromStack2ToStack1()
        {
            Crane3 crane = new Crane3("ZN", "MCD", "P");
            crane.Move(1, 2, 1);
            Assert.AreEqual('D', crane.CheckTop(1));
        }

        [TestMethod]
        public void Move3CratesFrom1Stack1ToStack3()
        {
            Crane3 crane = new Crane3("ZND", "MC", "P");
            crane.Move(3, 1, 3);

            Assert.AreEqual(0, crane.StackCount(1));
            Assert.AreEqual(4, crane.StackCount(3));
            Assert.AreEqual('Z', crane.CheckTop(3));
        }


        [TestMethod]
        public void FullRun()
        {
            Crane3 crane = new Crane3("ZN", "MCD", "P");
            crane.Move(1, 2, 1);
            crane.Move(3, 1, 3);
            crane.Move(2, 2, 1);
            crane.Move(1, 1, 2);
            string actual = crane.GetStackTops();
            Assert.AreEqual(1, crane.StackCount(1));
            Assert.AreEqual(1, crane.StackCount(2));
            Assert.AreEqual(4, crane.StackCount(3));
            Assert.AreEqual("CMZ", actual);
        }



    }
}

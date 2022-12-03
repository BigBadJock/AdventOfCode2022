namespace AdventOfCode2022_3_Tests
{
    [TestClass]
    public class PrioritisationTests
    {
        [TestMethod]
        public void PrioritisationTest_a()
        {
            int priority = Prioritisation.Prioritise('a');
            Assert.AreEqual(1, priority);
        }

        [TestMethod]
        public void PrioritisationTest_z()
        {
            int priority = Prioritisation.Prioritise('z');
            Assert.AreEqual(26, priority);
        }

        [TestMethod]
        public void PrioritisationTest_A()
        {
            int priority = Prioritisation.Prioritise('A');
            Assert.AreEqual(27, priority);
        }

        [TestMethod]
        public void PrioritisationTest_Z()
        {
            int priority = Prioritisation.Prioritise('Z');
            Assert.AreEqual(52, priority);
        }

    }
}

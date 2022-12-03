namespace AdventOfCode2022_3_Tests
{
    [TestClass]
    public class ExpeditionTests
    {

        [TestMethod]
        public void ExpeditionHasRucksacks()
        {
            Expedition expedition = new Expedition();
            Assert.IsNotNull(expedition.Rucksacks);
            Assert.IsInstanceOfType(expedition.Rucksacks, typeof(List<Rucksack>));
        }

        [TestMethod]
        public void ExpeditionLoadsFile()
        {
            Expedition expedition = new Expedition("expedition.txt");
            Assert.IsNotNull(expedition.Rucksacks);
            Assert.IsInstanceOfType(expedition.Rucksacks, typeof(List<Rucksack>));
            Assert.AreEqual(6, expedition.Rucksacks.Count);
        }

        [TestMethod]
        public void ExpeditionDuplicates()
        {
            Expedition expedition = new Expedition("expedition.txt");
            Assert.AreEqual("p", expedition.Rucksacks[0].GetDuplicates());
            Assert.AreEqual("L", expedition.Rucksacks[1].GetDuplicates());
            Assert.AreEqual("P", expedition.Rucksacks[2].GetDuplicates());
            Assert.AreEqual("v", expedition.Rucksacks[3].GetDuplicates());
            Assert.AreEqual("t", expedition.Rucksacks[4].GetDuplicates());
            Assert.AreEqual("s", expedition.Rucksacks[5].GetDuplicates());
        }

        [TestMethod]
        public void ExpeditionDuplicatePriorityTotal()
        {
            Expedition expedition = new Expedition("expedition.txt");
            Assert.AreEqual(157, expedition.GetDuplicatePriorityTotal());
        }
    }
}

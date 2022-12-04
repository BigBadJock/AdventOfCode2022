namespace AdventOfCode2022_4_Tests
{

    [TestClass]
    public class ExpeditionTests
    {

        [TestMethod]
        public void ExpeditionHasPairings()
        {
            Expedition expedition = new Expedition();
            Assert.IsNotNull(expedition.Pairings);
            Assert.IsInstanceOfType(expedition.Pairings, typeof(List<Pairing>));
        }

        [TestMethod]
        public void ExpeditionLoadsFile()
        {
            Expedition expedition = new Expedition("expedition.txt");
            Assert.IsNotNull(expedition.Pairings);
            Assert.IsInstanceOfType(expedition.Pairings, typeof(List<Pairing>));
            Assert.AreEqual(6, expedition.Pairings.Count);
        }

        [TestMethod]
        public void ExpeditionEnclosureCount()
        {
            Expedition expedition = new Expedition("expedition.txt");
            Assert.AreEqual(2, expedition.GetEnclosureCount());
        }

        [TestMethod]
        public void ExpeditionOverLapsCount()
        {
            Expedition expedition = new Expedition("expedition.txt");
            Assert.AreEqual(4, expedition.GetOverlapsCount());
        }

    }
}

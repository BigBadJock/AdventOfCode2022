namespace AdventOfCode2022_3_Tests
{

    [TestClass]
    public class ExpeditionWithGroupsTests
    {
        [TestMethod]
        public void ExpeditionWithGroups_LoadsFile()
        {
            ExpeditionWithGroups expedition = new ExpeditionWithGroups("expedition.txt");
            Assert.IsNotNull(expedition.Groups);
            Assert.IsInstanceOfType(expedition.Groups, typeof(List<Group>));
            Assert.AreEqual(2, expedition.Groups.Count);
        }

        [TestMethod]
        public void ExpeditionWithGroups_TotalBadgePriorites()
        {
            ExpeditionWithGroups expedition = new ExpeditionWithGroups("expedition.txt");
            Assert.AreEqual(70, expedition.GetTotalBadgePriorities());

        }
    }
}

namespace AdventOfCode2022_3_Tests
{

    [TestClass]
    public class GroupTests
    {

        [TestMethod]
        public void GroupHas3Rucksacks()
        {
            Group group = new Group("abcd", "befg", "bhij");
            Assert.AreEqual(3, group.Rucksacks.Count);
        }

        [TestMethod]
        public void GroupHasOneItemInCommon()
        {
            Group group1 = new Group("vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg");
            Group group2 = new Group("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw");
            Assert.AreEqual("r", group1.GetCommonItem());
            Assert.AreEqual("Z", group2.GetCommonItem());
        }

        [TestMethod]
        public void GroupBadge()
        {
            Group group1 = new Group("vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg");
            Group group2 = new Group("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw");
            Assert.AreEqual('r', group1.Badge);
            Assert.AreEqual('Z', group2.Badge);

        }

    }
}

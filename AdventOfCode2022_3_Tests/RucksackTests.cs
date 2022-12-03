namespace AdventOfCode2022_3_Tests
{
    [TestClass]
    public class RucksackTests
    {
        [TestMethod]
        public void RucksackPackingTest_Success()
        {
            Rucksack rucksack = new Rucksack("AaBbCc");
            Assert.AreEqual("AaB", rucksack.Compartment1);
            Assert.AreEqual("bCc", rucksack.Compartment2);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void RucksackPackingTest_Fail()
        {
            Rucksack rucksack = new Rucksack("AaBbC");
        }


        [TestMethod]
        public void CompartmentsHaveDuplicatesTest()
        {
            Rucksack rucksack = new Rucksack("vJrwpWtwJgWrhcsFMMfFFhFp");
            string duplicates = rucksack.GetDuplicates();
            Assert.AreEqual("p", duplicates);
        }

        [TestMethod]
        public void SingleDuplicatePriorityValueTest()
        {
            Rucksack rucksack = new Rucksack("vJrwpWtwJgWrhcsFMMfFFhFp");
            string duplicates = rucksack.GetDuplicates();
            int priority = rucksack.GetPriority(duplicates);
            Assert.AreEqual("p", duplicates);
            Assert.AreEqual(16, priority);
        }

        [TestMethod]
        public void MultipleeDuplicatePriorityValueTest()
        {
            Rucksack rucksack = new Rucksack("aBaB");
            string duplicates = rucksack.GetDuplicates();
            int priority = rucksack.GetPriority(duplicates);
            Assert.AreEqual("aB", duplicates);
            Assert.AreEqual(29, priority);
        }

        [TestMethod]
        public void RucksackContents()
        {
            string packingList = "vJrwpWtwJgWrhcsFMMfFFhFp";
            Rucksack rucksack = new Rucksack(packingList);
            Assert.AreEqual(packingList, rucksack.Contents);
            Assert.AreEqual("vJrwpWtwJgWr", rucksack.Compartment1);
            Assert.AreEqual("hcsFMMfFFhFp", rucksack.Compartment2);
        }

    }
}
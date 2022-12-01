namespace AdventOfCode2022_1_Tests
{
    [TestClass]
    public class ExpeditionTests
    {
        private Expedition expedition;

        [TestInitialize]
        public void Setup()
        {
            expedition = new Expedition();
        }

        [TestMethod]
        public void ExpeditionExists()
        {
            Assert.IsNotNull(expedition);
        }

        [TestMethod]
        public void ExpeditionCanHaveElves()
        {
            Assert.IsNotNull(expedition.Elves);
            Assert.IsInstanceOfType(expedition.Elves, typeof(List<Elf>));
        }

        [TestMethod]
        public void ExpeditionCanAddElf()
        {
            expedition.AddElf(new Elf());
            Assert.AreEqual(1, expedition.Elves.Count);
        }

        [TestMethod]
        public void ExpeditionCanAddElfWithListOfSnacks()
        {
            expedition.AddElf(1000, 2000, 3000);
            Assert.AreEqual(1, expedition.Elves.Count);

        }

        [TestMethod]
        public void ExpeditionGetElfWithMostCalories()
        {
            expedition.AddElf(new Elf(1000, 2000, 3000));
            expedition.AddElf(new Elf(4000));
            expedition.AddElf(new Elf(5000, 6000));
            expedition.AddElf(new Elf(7000, 8000, 9000));
            expedition.AddElf(new Elf(10000));


            // get the top 1 elves
            Elf top1 = expedition.GetElfWithMostCalories();
            Assert.AreEqual(24000, top1.TotalCalories);
        }

        [TestMethod]
        public void ExpeditionGetCaloriesFromTopXElves()
        {
            expedition.AddElf(new Elf(1000, 2000, 3000));
            expedition.AddElf(new Elf(4000));
            expedition.AddElf(new Elf(5000, 6000));
            expedition.AddElf(new Elf(7000, 8000, 9000));
            expedition.AddElf(new Elf(10000));

            int calories = expedition.GetCaloriesFromTopXElves(3);

            Assert.AreEqual(45000, calories);
        }

        [TestMethod]
        public void ExpeditionCanLoadFromFile()
        {
            expedition.LoadFromFile("testfile.txt");
            Elf top1 = expedition.GetElfWithMostCalories();
            Assert.AreEqual(5, expedition.Elves.Count);
            Assert.AreEqual(24000, top1.TotalCalories);

        }

    }
}

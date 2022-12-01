namespace AdventOfCode2022_1_Tests
{
    [TestClass]
    public class ElfTests
    {
        Elf elf;

        [TestInitialize]
        public void Setup()
        {
            elf = new Elf();
        }

        [TestMethod]
        public void ElfExists()
        {
            Assert.IsNotNull(elf);
        }

        [TestMethod]
        public void ElfCanCarrySnacks()
        {
            Assert.IsNotNull(elf.Snacks);
            Assert.IsInstanceOfType(elf.Snacks, typeof(List<int>));
            Assert.AreEqual(elf.Snacks.Count, 0);
        }


        [TestMethod]
        public void ElfCanAddSnack()
        {
            elf.AddSnack(1);
            Assert.AreEqual(1, elf.Snacks.Count);
        }

        [TestMethod]
        public void ElfHas2Snacks()
        {
            elf.AddSnack(1);
            elf.AddSnack(1);

            Assert.AreEqual(2, elf.Snacks.Count);
        }

        [TestMethod]
        public void ElfTotalCalorieCount()
        {
            elf.AddSnack(1000);
            elf.AddSnack(2000);
            Assert.AreEqual(3000, elf.TotalCalories);
        }

        [TestMethod]
        public void ElfAddMultipleSnacks()
        {
            elf.AddSnacks(1000, 2000, 3000);
            Assert.AreEqual(3, elf.Snacks.Count);
            Assert.AreEqual(6000, elf.TotalCalories);
        }

        [TestMethod]
        public void ElfCanCreateWithListOfSnacks()
        {
            Elf elf2 = new Elf(1000, 2000, 3000);
            Assert.AreEqual(3, elf2.Snacks.Count);
            Assert.AreEqual(6000, elf2.TotalCalories);


        }

    }
}
namespace AdventOfCode2022_4_Tests
{
    [TestClass]
    public class PairingTests
    {
        [TestMethod]
        public void PairingHas2Sections()
        {
            // Arrange
            var pairing = new Pairing("2-4", "6-8");
            // Act
            // Assert
            Assert.IsNotNull(pairing.Section1);
            Assert.IsNotNull(pairing.Section2);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void PairingValidateSection_NotNumeric_Fails()
        {
            var pairing = new Pairing("a-b", "6-8");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void PairingValidateSection_NoSeparator_Fails()
        {
            var pairing = new Pairing("ab", "6-8");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void PairingValidateSection_InvalidSeparator_Fails()
        {
            var pairing = new Pairing("a=b", "6-8");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void PairingValidateSection_InvalidRange_Fails()
        {
            var pairing = new Pairing("10-2", "6-8");
        }

        [TestMethod]
        public void PairingValidateSection_LargeRange_Succeeds()
        {
            var pairing = new Pairing("2-200", "6-8");
            Assert.AreEqual(2, pairing.Section1Low);
            Assert.AreEqual(200, pairing.Section1High);
            Assert.AreEqual(6, pairing.Section2Low);
            Assert.AreEqual(8, pairing.Section2High);
        }

        [TestMethod]
        public void PairingSectionsConvertsToRange()
        {
            var pairing = new Pairing("2-4", "6-8");
            Assert.AreEqual(2, pairing.Section1Low);
            Assert.AreEqual(4, pairing.Section1High);
            Assert.AreEqual(6, pairing.Section2Low);
            Assert.AreEqual(8, pairing.Section2High);
        }

        [TestMethod]
        public void EncompassCheck_1in2()
        {
            var pairing = new Pairing("3-7", "2-8");
            Assert.IsTrue(pairing.IsEncompasing());
        }

        [TestMethod]
        public void EncompassCheck_2in1()
        {
            var pairing = new Pairing("2-8", "3-7");
            Assert.IsTrue(pairing.IsEncompasing());
        }

        [TestMethod]
        public void Overlaps_False()
        {
            var pairing = new Pairing("2-4", "6-8");
            Assert.IsFalse(pairing.IsOverlapping());
        }

        [TestMethod]
        public void Overlaps_True()
        {
            var pairing = new Pairing("2-4", "4-8");
            Assert.IsTrue(pairing.IsOverlapping());
        }

    }
}
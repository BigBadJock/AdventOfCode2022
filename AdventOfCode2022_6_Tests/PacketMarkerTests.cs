using AdventOfCode2022_6;

namespace AdventOfCodeDay6_Tests
{
    [TestClass]
    public class PacketMarkerTests
    {
        [DataTestMethod]
        [DataRow("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7)]
        [DataRow("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
        [DataRow("nppdvjthqldpwncqszvftbrmjlhg", 6)]
        [DataRow("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
        [DataRow("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
        public void PacketMarketFindTests(string dataStreamBuffer, int expected)
        {
            // arrange

            // act
            int packetMarkerLocation = PacketMarkerFinder.Find(dataStreamBuffer);

            // assert
            Assert.AreEqual(expected, packetMarkerLocation);
        }
    }
}
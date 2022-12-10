using AdventOfCode2022_6;

namespace AdventOfCodeDay6_Tests
{
    [TestClass]
    public class MarkerTests
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
            int packetMarkerLocation = MarkerFinder.Find(dataStreamBuffer, MarkerFinder.MarkerType.Packet);

            // assert
            Assert.AreEqual(expected, packetMarkerLocation);
        }

        [DataTestMethod]
        [DataRow("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19)]
        [DataRow("bvwbjplbgvbhsrlpgdmjqwftvncz", 23)]
        [DataRow("nppdvjthqldpwncqszvftbrmjlhg", 23)]
        [DataRow("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29)]
        [DataRow("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26)]
        public void MessageMarketFindTests(string dataStreamBuffer, int expected)
        {
            // arrange

            // act
            int packetMarkerLocation = MarkerFinder.Find(dataStreamBuffer, MarkerFinder.MarkerType.Message);

            // assert
            Assert.AreEqual(expected, packetMarkerLocation);
        }

    }
}
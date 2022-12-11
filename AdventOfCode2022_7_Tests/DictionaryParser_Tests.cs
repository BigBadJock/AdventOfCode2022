using AdventOfCode2022_7;

namespace AdventOfCode2022_7_Tests
{
    [TestClass]
    public class DictionaryParser_Tests
    {

        [TestMethod]
        public void DirectoryParser_ParseFile_Test()
        {
            Dictionary<string, int> files = DirectoryParser.Parse("input.txt");

            Assert.IsNotNull(files);
            Assert.AreEqual(10, files.Count);

        }

        [TestMethod]
        public void DictionaryParser_DirectorySize_Test()
        {
            Dictionary<string, int> files = DirectoryParser.Parse("input.txt");
            Dictionary<string, int> directories = DirectoryParser.GetDirectorySizes(files);

            Assert.AreEqual(4, directories.Count);
            Assert.AreEqual(48381165, directories["/"]);
            Assert.AreEqual(94853, directories["/a"]);
            Assert.AreEqual(584, directories["/a/e"]);
            Assert.AreEqual(24933642, directories["/d"]);
        }

        [TestMethod]
        public void DictionarParser_calc_Tests()
        {
            Dictionary<string, int> files = DirectoryParser.Parse("input.txt");
            Dictionary<string, int> directories = DirectoryParser.GetDirectorySizes(files);

            int diskspace = 70_000_000;
            int targetFreeSpace = 30_000_000;
            int actualFreeSpace = diskspace - directories["/"];
            int extraFreeSpaceRequired = targetFreeSpace - actualFreeSpace;

            string key = directories.Where(x => x.Value > extraFreeSpaceRequired).OrderBy(x => x.Value).Select(x => x.Key).First();
            int value = directories[key];
            Assert.AreEqual(key, "/d");
            Assert.AreEqual(24933642, value);
        }

    }
}

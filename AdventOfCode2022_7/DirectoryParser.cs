namespace AdventOfCode2022_7
{
    public static class DirectoryParser
    {

        public static Dictionary<string, int> Parse(string fileName)
        {
            string[] input = ReadFile(fileName);
            Dictionary<string, int> files = ParseInput(input);

            return files;

        }

        public static Dictionary<string, int> GetDirectorySizes(Dictionary<string, int> files)
        {
            Dictionary<string, int> directories = new Dictionary<string, int>();
            foreach (string path in files.Keys)
            {
                int size = files[path];
                string[] folders = path.Split("/");
                string parent = "";
                // miss out last entry which is filename
                for (int i = 0; i < folders.Length - 1; i++)
                {
                    string folder = folders[i];
                    parent = GetParentName(parent, folder);
                    if (directories.ContainsKey(parent))
                    {
                        directories[parent] += size;
                    }
                    else
                    {
                        directories.Add(parent, size);
                    }
                }
            }
            return directories;
        }

        private static string GetParentName(string parent, string folder)
        {
            parent = $"{parent}/{folder}";
            if (parent.StartsWith("//"))
            {
                parent = parent.Substring(1);
            }
            return parent;
        }

        private static Dictionary<string, int> ParseInput(string[] input)
        {
            Dictionary<string, int> files = new Dictionary<string, int>();
            string path = "";
            string parent = "";
            int indent = 0;
            foreach (string line in input)
            {
                if (line == "$ cd /")
                {
                    indent = 0;
                    string s = string.Concat(Enumerable.Repeat(" ", indent));
                    //Console.WriteLine($"{s}{line}");
                }
                else if (line == "$ cd ..")
                {
                    path = path.Substring(0, path.LastIndexOf("/"));
                    //string s = string.Concat(Enumerable.Repeat(" ", indent));
                    //                    Console.WriteLine($"{s}{line}");
                    indent -= 3;
                }
                else if (line.StartsWith("$ cd "))
                {
                    string newDirectoryName = line.Substring(5);
                    parent = path;
                    path = path + "/" + newDirectoryName;
                    string s = string.Concat(Enumerable.Repeat(" ", indent));
                    //Console.WriteLine(path);
                    //Console.WriteLine($"{s}{newDirectoryName}");
                    indent += 3;
                }
                else if (line.StartsWith("dir"))
                {
                    // do nothing
                }
                else if (line.StartsWith("$ ls"))
                {
                    // do nothing
                }
                else
                {
                    string[] f = line.Split(" ");
                    int size = int.Parse(f[0]);
                    string name = f[1];
                    string filePath = $"{path}/{name}";
                    files.Add(filePath, size);
                }
            }
            return files;

        }

        private static string[] ReadFile(string fileName)
        {
            string[] input = File.ReadAllLines(fileName);
            return input;
        }
    }
}

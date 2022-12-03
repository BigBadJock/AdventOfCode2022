namespace AdventOfCode2022_3
{
    public class ExpeditionWithGroups
    {
        public List<Group> Groups { get; private set; }

        public ExpeditionWithGroups(string filename)
        {
            Groups = new List<Group>();
            LoadFile(filename);
        }

        private void LoadFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException($"File {filename} not found.");
            }

            string[] lines = File.ReadAllLines(filename);
            this.Groups = new List<Group>();

            int count = 0;
            foreach (string line in lines)
            {
                if (count % 3 == 0)
                {
                    Groups.Add(new Group(line, lines[count + 1], lines[count + 2]));
                }
                count++;
            }
        }

        public int GetTotalBadgePriorities()
        {
            int total = 0;
            foreach (Group g in Groups)
            {
                total += g.GetBadgePriority();
            }
            return total;
        }
    }
}

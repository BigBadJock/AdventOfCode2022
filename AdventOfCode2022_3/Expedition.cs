namespace AdventOfCode2022_3
{
    public class Expedition
    {

        public List<Rucksack> Rucksacks { get; set; }

        public Expedition()
        {
            Rucksacks = new List<Rucksack>();
        }

        public Expedition(string filename)
        {
            Rucksacks = new List<Rucksack>();
            LoadFile(filename);
        }


        private void LoadFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException($"File {filename} not found.");
            }

            string[] lines = File.ReadAllLines(filename);
            this.Rucksacks = new List<Rucksack>();

            foreach (string line in lines)
            {
                this.Rucksacks.Add(new Rucksack(line));
            }
        }

        public int GetDuplicatePriorityTotal()
        {
            int total = 0;
            foreach (Rucksack r in Rucksacks)
            {
                string duplicates = r.GetDuplicates();
                int priority = r.GetPriority(duplicates);
                total += priority;
            }
            return total;
        }
    }
}

namespace AdventOfCode2022_1
{
    public sealed class Expedition
    {
        public Expedition()
        {
            Elves = new List<Elf>();
        }

        public List<Elf> Elves { get; private set; }

        public void AddElf(Elf elf)
        {
            Guard.Against.Null(elf, nameof(elf));
            Elves.Add(elf);
        }

        public void AddElf(params int[] snacks)
        {
            Guard.Against.Null(snacks, nameof(snacks));
            Elves.Add(new Elf(snacks));
        }

        public Elf GetElfWithMostCalories()
        {
            Elves.Sort((x, y) => y.TotalCalories.CompareTo(x.TotalCalories));

            // get the top 1 elves
            Elf top1 = Elves.First<Elf>();
            return top1;
        }

        public void LoadFromFile(string fileName)
        {
            Guard.Against.NullOrEmpty(fileName, nameof(fileName));

            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException($"File {fileName} not found.");
            }

            string[] lines = File.ReadAllLines(fileName);
            List<int> snacks = new List<int>();
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    this.AddElf(snacks.ToArray());
                    snacks.Clear();
                    continue;
                }
                snacks.Add(int.Parse(line));
            }
            this.AddElf(snacks.ToArray());
        }
    }
}

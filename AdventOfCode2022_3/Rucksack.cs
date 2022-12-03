namespace AdventOfCode2022_3
{
    public class Rucksack
    {
        public string Compartment1 { get; set; }
        public string Compartment2 { get; set; }

        public Rucksack(string packingList)
        {
            Guard.Against.NullOrEmpty(packingList, nameof(packingList));
            int l = packingList.Length;
            if (l % 2 != 0)
            {
                throw new ArgumentException("packingList must be an even number of characters", nameof(packingList));
            }
            int h = l / 2;
            Compartment1 = packingList.Substring(0, h);
            Compartment2 = packingList.Substring(h);
        }

        public string GetDuplicates()
        {
            string duplicates = "";
            foreach (char c in Compartment1)
            {
                if (Compartment2.Contains(c))
                {
                    if (!duplicates.Contains(c))
                        duplicates += c;
                }
            }
            return duplicates;
        }

        public int GetPriority(string duplicates)
        {
            int totalPriority = 0;
            foreach (char c in duplicates)
            {
                int priority = Prioritisation.Prioritise(c);
                totalPriority += priority;
            }
            return totalPriority;

        }
    }
}

namespace AdventOfCode2022_3
{
    public class Group
    {

        public Group(string rucksack1, string rucksack2, string rucksack3)
        {
            Rucksacks = new List<Rucksack>();
            Rucksacks.Add(new Rucksack(rucksack1));
            Rucksacks.Add(new Rucksack(rucksack2));
            Rucksacks.Add(new Rucksack(rucksack3));
            Badge = GetCommonItem().ToCharArray()[0];
        }

        public List<Rucksack> Rucksacks { get; private set; }
        public char Badge { get; set; }

        public string GetCommonItem()
        {
            string commonItem = "";
            foreach (char c in Rucksacks[0].Contents)
            {
                if (Rucksacks[1].Contents.Contains(c) && Rucksacks[2].Contents.Contains(c))
                {
                    if (!commonItem.Contains(c))
                        commonItem += c;
                }
            }
            if (commonItem.Length > 1)
            {
                throw new Exception("More than one common item found");
            }
            return commonItem;
        }

        internal int GetBadgePriority()
        {
            return Prioritisation.Prioritise(this.Badge);
        }
    }
}

namespace AdventOfCode2022_1
{
    public sealed class Elf
    {
        public Elf(params int[] snacks)
        {
            Snacks = new List<int>();
            foreach (int snack in snacks)
            {
                AddSnack(snack);
            }
        }

        public List<int> Snacks { get; private set; }
        public int TotalCalories
        {
            get
            {
                return Snacks.Sum();
            }
        }

        public void AddSnack(int snack)
        {
            Snacks.Add(snack);
        }

        public void AddSnacks(params int[] snacks)
        {
            foreach (int snack in snacks)
            {
                AddSnack(snack);
            }
        }

    }
}

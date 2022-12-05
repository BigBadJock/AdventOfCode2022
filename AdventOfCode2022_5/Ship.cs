namespace AdventOfCode2022_5
{
    public class Ship
    {

        public List<Stack<char>> CrateStacks { get; set; }

        public Ship()
        {
            CrateStacks = new List<Stack<char>>();
        }

        public Ship(params string[] crates) : this()
        {
            foreach (var crate in crates)
            {
                var stack = new Stack<char>();
                foreach (var c in crate)
                {
                    stack.Push(c);
                }
                CrateStacks.Add(stack);
            }
        }

    }
}

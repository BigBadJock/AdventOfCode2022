using System.Text;

namespace AdventOfCode2022_5
{
    public class Crane4
    {
        public string[] Stacks { get; set; }

        public Crane4(params string[] stacks)
        {
            this.Stacks = stacks;
        }

        public void Move(int quantity, int from, int to)
        {
            int f = from - 1;
            int t = to - 1;

            string x = Stacks[f].Substring(Stacks[f].Length - quantity);
            Stacks[f] = Stacks[f].Substring(0, Stacks[f].Length - quantity);
            Stacks[t] += x;
        }

        public char CheckTop(int stack)
        {
            int x = stack - 1;
            return Stacks[x][Stacks[x].Length - 1];
        }

        public int StackCount(int stack)
        {
            int x = stack - 1;
            return Stacks[x].Length;
        }

        public string GetStackTops()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var stack in Stacks)
            {
                if (stack.Length > 0)
                {
                    sb.Append(stack[stack.Length - 1]);
                }
            }
            return sb.ToString();
        }
    }
}

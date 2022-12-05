using System.Text;

namespace AdventOfCode2022_5
{
    public class CraneMover9001
    {
        public CraneMover9001(Ship ship)
        {
            Ship = ship;
        }

        public Ship Ship { get; set; }

        public string GetStackTops()
        {
            var sb = new StringBuilder();
            foreach (var stack in Ship.CrateStacks)
            {
                if (stack.Count > 0)
                {
                    sb.Append(stack.Peek());
                }
            }
            return sb.ToString();

        }

        public void Move(int quantity, int fromStack, int toStack)
        {
            char[] removed = new char[quantity];
            for (int i = 0; i < quantity; i++)
            {
                removed[i] = Ship.CrateStacks[fromStack - 1].Pop();
            }
            for (int i = quantity - 1; i > -1; i--)
            {
                Ship.CrateStacks[toStack - 1].Push(removed[i]);
            }
        }
    }
}

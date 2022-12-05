using System.Text;

namespace AdventOfCode2022_5
{
    public class CraneMover9000
    {
        public CraneMover9000(Ship ship)
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
            for (int i = 0; i < quantity; i++)
            {
                Ship.CrateStacks[toStack - 1].Push(Ship.CrateStacks[fromStack - 1].Pop());
            }
        }
    }
}

namespace AdventOfCode2022_3
{
    public static class Prioritisation
    {
        public static int Prioritise(char v)
        {
            if (!Char.IsLetter(v)) throw new ArgumentException("Not an Alpha character");
            // check if v is lowercase
            if (Char.IsLower(v))
            {
                int val = (int)Convert.ToInt32(v) - 96;
                return val;
            }
            else
            {
                int val = (int)Convert.ToInt32(v) - 38;
                return val;

            }
        }
    }
}

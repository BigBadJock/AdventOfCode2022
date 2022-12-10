namespace AdventOfCode2022_6
{
    public static class PacketMarkerFinder
    {
        public static int Find(string dataStreamBuffer)
        {
            int start = 4;
            bool found = false;
            while (!found && start < dataStreamBuffer.Length)
            {
                string possibleMarker = dataStreamBuffer.Substring(start - 4, 4);
                // check for repeated characters in the possibleMarker
                var chars = possibleMarker.ToCharArray();
                int max = chars.GroupBy(c => c).Where(g => g.Count() > 1).Count();
                if (max == 0)
                {
                    found = true;
                    return start;
                }
                start++;
            }
            return -1;
        }
    }
}
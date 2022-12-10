namespace AdventOfCode2022_6
{
    public static class MarkerFinder
    {

        public enum MarkerType
        {
            Packet,
            Message
        }

        public static int Find(string dataStreamBuffer, MarkerType markerType)
        {
            int markerLength = GetMarkerLength(markerType);

            int start = markerLength;
            bool found = false;
            while (!found && start < dataStreamBuffer.Length)
            {
                string possibleMarker = dataStreamBuffer.Substring(start - markerLength, markerLength);
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

        private static int GetMarkerLength(MarkerType markerType)
        {
            int markerLength = 0;
            switch (markerType)
            {
                case MarkerType.Packet:
                    markerLength = 4;
                    break;
                case MarkerType.Message:
                    markerLength = 14;
                    break;
                default:
                    markerLength = 4;
                    break;
            }

            return markerLength;
        }
    }
}
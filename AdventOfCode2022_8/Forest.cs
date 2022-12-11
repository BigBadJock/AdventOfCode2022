namespace AdventOfCode2022_8
{
    public class Forest
    {
        private int rows;
        private int cols;

        public int[,] Trees { get; set; }

        public Forest(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            rows = lines.Length;
            cols = lines[0].Length;
            Trees = new int[rows, cols];

            for (int y = 0; y < rows; y++)
            {
                string line = lines[y];
                for (int x = 0; x < cols; x++)
                {
                    Trees[y, x] = int.Parse(line.Substring(x, 1));
                }
            }
        }

        public bool IsVisible(int y, int x)
        {
            if (IsVisibleFromTop(y, x)) return true;
            if (IsVisibleFromLeft(y, x)) return true;
            if (IsVisibleFromRight(y, x)) return true;
            if (IsVisibleFromBottom(y, x)) return true;

            return false;

        }

        private bool IsVisibleFromBottom(int y, int x)
        {
            int targetHeight = Trees[y, x];
            for (int i = rows - 1; i > y; i--)
            {
                if (Trees[i, x] >= targetHeight) return false;
            }
            return true;
        }

        private bool IsVisibleFromRight(int y, int x)
        {
            int targetHeight = Trees[y, x];
            for (int i = cols - 1; i > x; i--)
            {
                if (Trees[y, i] >= targetHeight) return false;
            }
            return true;
        }

        private bool IsVisibleFromLeft(int y, int x)
        {
            int targetHeight = Trees[y, x];
            for (int i = 0; i < x; i++)
            {
                if (Trees[y, i] >= targetHeight) return false;
            }
            return true;
        }

        private bool IsVisibleFromTop(int y, int x)
        {
            int targetHeight = Trees[y, x];
            for (int i = 0; i < y; i++)
            {
                if (Trees[i, x] >= targetHeight) return false;
            }
            return true;
        }

        public int CountVisibleTrees()
        {
            int count = 0;
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    if (IsVisible(y, x)) count++;
                }
            }
            return count;
        }

        public int CalculateScenicScore(int y, int x)
        {
            int up = CalculateScenicScoreUp(y, x);
            int left = CalculateScenicScoreLeft(y, x);
            int right = CalculateScenicScoreRight(y, x);
            int down = CalculateScenicScoreDown(y, x);

            return (up * left * right * down);
        }

        private int CalculateScenicScoreLeft(int y, int x)
        {
            int targetHeight = Trees[y, x];
            int count = 0;
            for (int i = x - 1; i > -1; i--)
            {
                if (Trees[y, i] >= targetHeight) return count + 1;
                count++;
            }
            return count;
        }

        private int CalculateScenicScoreRight(int y, int x)
        {
            int targetHeight = Trees[y, x];
            int count = 0;
            for (int i = x + 1; i < cols; i++)
            {
                if (Trees[y, i] >= targetHeight) return count + 1;
                count++;
            }
            return count;
        }

        private int CalculateScenicScoreDown(int y, int x)
        {
            int targetHeight = Trees[y, x];
            int count = 0;
            for (int i = y + 1; i < rows; i++)
            {
                if (Trees[i, x] >= targetHeight) return count + 1;
                count++;
            }
            return count;
        }

        private int CalculateScenicScoreUp(int y, int x)
        {
            int targetHeight = Trees[y, x];
            int count = 0;
            for (int i = y - 1; i > -1; i--)
            {
                if (Trees[i, x] >= targetHeight) return count + 1;
                count++;
            }
            return count;
        }

        public int CalculateHighestScenicScore()
        {
            int max = 0;
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    int score = CalculateScenicScore(y, x);
                    if (score > max) max = score;
                }
            }
            return max;
        }
    }
}

using Ardalis.GuardClauses;
using System.Text.RegularExpressions;

namespace AdventOfCode2022_4
{
    public class Pairing
    {
        public Pairing(string section1, string section2)
        {
            Guard.Against.NullOrEmpty(section1, nameof(section1));
            Guard.Against.NullOrEmpty(section2, nameof(section2));
            if (!ValidateSection1(section1)) throw new ArgumentException("Section1 is invalid");
            if (!ValidateSection2(section2)) throw new ArgumentException("Section2 is invalid");

            Section1 = section1;
            Section2 = section2;
        }

        private bool ValidateSection1(string section)
        {
            int low;
            int high;
            if (!ValidateSection(section, out low, out high)) return false;
            this.Section1 = section;
            this.Section1Low = low;
            this.Section1High = high;
            return true;
        }

        private bool ValidateSection2(string section)
        {
            int low;
            int high;
            if (!ValidateSection(section, out low, out high)) return false;
            this.Section2 = section;
            this.Section2Low = low;
            this.Section2High = high;
            return true;
        }


        private bool ValidateSection(string section, out int low, out int high)
        {
            low = 0;
            high = 0;
            // use regular expression to check section matches 99-99
            bool matchesPattern = Regex.IsMatch(section, @"\d-\d");
            if (!matchesPattern) return false;

            string[] range = section.Split('-');
            low = int.Parse(range[0]);
            high = int.Parse(range[1]);
            if (low > high) return false;
            return true;
        }

        public bool IsEncompasing()
        {
            if (Section2Low >= Section1Low && Section2High <= Section1High) return true;
            if (Section1Low >= Section2Low && Section1High <= Section2High) return true;
            return false;
        }

        public bool IsOverlapping()
        {
            if (Section2Low >= Section1Low && Section2Low <= Section1High) return true;
            if (Section2High >= Section1Low && Section2Low <= Section1High) return true;
            if (Section1Low >= Section2Low && Section1Low <= Section2High) return true;
            if (Section1High >= Section2Low && Section1Low <= Section2High) return true;
            return false;
        }

        public string Section1 { get; private set; }
        public string Section2 { get; private set; }
        public int Section1Low { get; private set; }
        public int Section1High { get; private set; }
        public int Section2Low { get; private set; }
        public int Section2High { get; private set; }
    }
}

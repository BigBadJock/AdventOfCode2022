namespace AdventOfCode2022_4
{
    public class Expedition
    {

        public Expedition()
        {
            this.Pairings = new List<Pairing>();
        }

        public Expedition(string filename)
        {
            LoadFile(filename);
        }

        private void LoadFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException($"File {filename} not found.");
            }

            string[] lines = File.ReadAllLines(filename);
            this.Pairings = new List<Pairing>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                this.Pairings.Add(new Pairing(parts[0], parts[1]));
            }
        }

        public int GetEnclosureCount()
        {
            int enclosureCount = this.Pairings.Where(p => p.IsEncompasing()).Count();
            return enclosureCount;
        }

        public int GetOverlapsCount()
        {
            int enclosureCount = this.Pairings.Where(p => p.IsOverlapping()).Count();
            return enclosureCount;
        }

        public List<Pairing> Pairings { get; set; }
    }
}

using AdventOfCode2022_4;

Expedition expedition = new Expedition("expedition.txt");
Console.WriteLine("Expediton Enclosure Count: " + expedition.GetEnclosureCount());
Console.WriteLine("Expediton Overlapping Count: " + expedition.GetOverlapsCount());
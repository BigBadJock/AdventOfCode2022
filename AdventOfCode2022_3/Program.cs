using AdventOfCode2022_3;

Expedition expedition = new Expedition("expedition.txt");
Console.WriteLine($"Duplicate Priorities Total = {expedition.GetDuplicatePriorityTotal()}");

ExpeditionWithGroups expedition2 = new ExpeditionWithGroups("expedition.txt");
Console.WriteLine($"Badge Priority Total = {expedition2.GetTotalBadgePriorities()}");
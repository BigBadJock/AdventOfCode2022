// See https://aka.ms/new-console-template for more information
using AdventOfCode2022_7;

Console.WriteLine("Hello, World!");

Dictionary<string, int> files = DirectoryParser.Parse("input.txt");
Dictionary<string, int> directories = DirectoryParser.GetDirectorySizes(files);

var selectedTotal = directories.Where(x => x.Value < 100_000).Select(x => x.Value).Sum();

// parse input into FileDir structure
//FileDir root = FileParser.Parse("input.txt");
//int selectedTotal = FileParser.GetSelectedTotal(root, 100_000);
Console.WriteLine("Selected total: " + selectedTotal);

int diskspace = 70_000_000;
int targetFreeSpace = 30_000_000;
int actualFreeSpace = diskspace - directories["/"];
int extraFreeSpaceRequired = targetFreeSpace - actualFreeSpace;

Console.WriteLine($"Disk space: {diskspace.ToString("N0")}");
Console.WriteLine($"Target free space: {targetFreeSpace.ToString("N0")}");
Console.WriteLine($"Actual free space: {actualFreeSpace.ToString("N0")}");
Console.WriteLine($"Extra Free space required: {extraFreeSpaceRequired.ToString("N0")}");

string key = directories.Where(x => x.Value > extraFreeSpaceRequired).OrderBy(x => x.Value).Select(x => x.Key).First();
int value = directories[key];

Console.WriteLine($"Directory: {key} size : {value.ToString("N0")}");
// See https://aka.ms/new-console-template for more information
using AdventOfCode2022_8;

Console.WriteLine("Hello, World!");


Forest forest = new Forest("input.txt");

Console.WriteLine($"Visible Trees: {forest.CountVisibleTrees()}");
Console.WriteLine($"Highest Scenic Score: {forest.CalculateHighestScenicScore()}");

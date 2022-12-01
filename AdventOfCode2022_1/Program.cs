// See https://aka.ms/new-console-template for more information

Expedition expedition = new Expedition();
expedition.LoadFromFile("Day1Data.txt");
Elf elf = expedition.GetElfWithMostCalories();
Console.WriteLine($"Elf with most calories: {elf.TotalCalories}");



// See https://aka.ms/new-console-template for more information

Expedition expedition = new Expedition();
expedition.LoadFromFile("Day1Data.txt");
Elf elf = expedition.GetElfWithMostCalories();
Console.WriteLine($"Elf with most calories: {elf.TotalCalories}");

int calories = expedition.GetCaloriesFromTopXElves(3);
Console.WriteLine($"Total calories from top 3 elves: {calories}");

Console.ReadLine();



using AdventOfCode2022_5;

Ship ship1 = new Ship("SLW", "JTNQ", "SCHFJ", "TRMWNGB", "TRLSDHQB", "MJBVFHRL", "DWRNJM", "BZTFHNDJ", "HLQNBFT");
Ship ship2 = new Ship("SLW", "JTNQ", "SCHFJ", "TRMWNGB", "TRLSDHQB", "MJBVFHRL", "DWRNJM", "BZTFHNDJ", "HLQNBFT");
CraneMover9000 crane1 = new CraneMover9000(ship1);
CraneMover9001 crane2 = new CraneMover9001(ship2);
Crane3 crane3 = new Crane3("SLW", "JTNQ", "SCHFJ", "TRMWNGB", "TRLSDHQB", "MJBVFHRL", "DWRNJM", "BZTFHNDJ", "HLQNBFT");
Crane4 crane4 = new Crane4("SLW", "JTNQ", "SCHFJ", "TRMWNGB", "TRLSDHQB", "MJBVFHRL", "DWRNJM", "BZTFHNDJ", "HLQNBFT");


string[] lines = File.ReadAllLines("input.txt");
foreach (var line in lines)
{
    string[] parts = line.Split(' ');
    int quantity = int.Parse(parts[1]);
    int fromStack = int.Parse(parts[3]);
    int toStack = int.Parse(parts[5]);
    crane1.Move(quantity, fromStack, toStack);
    crane2.Move(quantity, fromStack, toStack);
    crane3.Move(quantity, fromStack, toStack);
    crane4.Move(quantity, fromStack, toStack);
}

Console.WriteLine($"Crane 9000 Stack tops =  {crane1.GetStackTops()}");
Console.WriteLine($"Crane 9001 Stack tops =  {crane2.GetStackTops()}");
Console.WriteLine($"Crane 3 Stack tops =  {crane3.GetStackTops()}");
Console.WriteLine($"Crane 4 Stack tops =  {crane4.GetStackTops()}");
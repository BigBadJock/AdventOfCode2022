using AdventOfCode2022_2;

Strategy strategy = new Strategy("strategy.txt");
Console.WriteLine(strategy.Tournament.Player2TotalScore);


Strategy strategyB = new Strategy("strategy.txt", true);
Console.WriteLine(strategyB.Tournament.Player2TotalScore);
﻿using MandatoryAssignmentLibrary;

World world = World.Instance();
world.PrintWorld();
while (world.Hero.IsAlive && world.Creatures.Count != 0)
{
    ConsoleKey c = Console.ReadKey().Key;
    world.MoveHero(world.CharToNumber(c));
    world.PrintWorld();
}
string victoryString = world.Hero.IsAlive ? "You won!" : "You Lost!";
Logger.GetLogger().CloseLogger();
Console.WriteLine(victoryString);
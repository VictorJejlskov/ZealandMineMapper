using MandatoryAssignmentLibrary.Factory;
using MandatoryAssignmentLibrary.Interfaces;
using MandatoryAssignmentLibrary.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MandatoryAssignmentLibrary
{
    public class World
    {
        private readonly String horizontalLine = "";
        private static World _instance;
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public Creature Hero { get; set; }
        public List<Creature> Creatures { get; set; }
        public List<Position> DeadCreaturePositions { get; set; } = new List<Position>();
        public List<Position> ListOfPositions { get; set; } = new List<Position>();
        private Logger _logger = Logger.GetLogger();

        private World InitializeWorld()
        {
            XmlDocument configDoc = new XmlDocument();
            string _path = Environment.GetEnvironmentVariable("GameFrameworkConfig");
            configDoc.Load(_path);
            var world = configDoc.DocumentElement.SelectSingleNode("Playground");
            int maxX = Convert.ToInt32(world.SelectSingleNode("MaxX").InnerText);
            int maxY = Convert.ToInt32(world.SelectSingleNode("MaxY").InnerText);
            int healthMod = Convert.ToInt32(world.SelectSingleNode("HeroHealthModifier").InnerText);
            int amountOfCreatures = Convert.ToInt32(world.SelectSingleNode("AmountOfCreatures").InnerText);
            this.MaxX = maxX;
            this.MaxY = maxY;
            Creatures = new List<Creature>();
            for (int i = 0; i < amountOfCreatures; i++)
            {
                Creature theCreature = new Creature(maxX, maxY) { Name = "Creature" + i };
                while (ListOfPositions.Contains(theCreature.Position))
                {
                    theCreature.RerollPosition(maxX, maxY);
                }
                Creatures.Add(theCreature);
                ListOfPositions.Add(theCreature.Position);
            }  
            var rnd = new Random();
            Hero = Creatures[rnd.Next(0, Creatures.Count)];
            Hero.Hitpoints *= healthMod;
            Hero.Name = "Hero";
            Creatures.Remove(Hero);
            return this;
        }



        public static World Instance()
        {
            return _instance ?? new World();
        }

        private World()
        {
            _instance = InitializeWorld();
            for (int i = 0; i < _instance.MaxX+2; i++)
            {
                horizontalLine += "-";
            }

        }

        public void PrintWorld()
        {
            Console.Clear();
            Console.WriteLine("Fight game: ");
            Console.WriteLine(horizontalLine);
            for (int r = 0; r < _instance.MaxY; r++)
            {
                Console.Write("|");
                PrintRowString(r);
                Console.WriteLine($"|");
            }
            Console.WriteLine(horizontalLine);
            Fight();
        }

        private void PrintRowString(int r)
        {
            StringBuilder sb = new StringBuilder();
            for (int c = 0; c < _instance.MaxX; c++)
            {
                PrintColRowChar(r, c);
            }
        }

        private void PrintColRowChar(int row, int col)
        {
            Position p = new Position(col, row);

            var positions = Creatures.Select(it => it.Position).ToList();
            positions.Add(Hero.Position);

            bool isMatch = false;
            bool isDeathMatch = false;

            foreach (var position in positions)
            {
                if (position.Equals(p))
                {
                    isMatch = true;
                    break;
                }
            }
            foreach (var position in DeadCreaturePositions)
            {
                if (position.Equals(p))
                {
                    isDeathMatch = true;
                    break;
                }
            }
            if (isMatch && Hero.Position.Equals(p)){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('X');
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (isMatch)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write('X');
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (isDeathMatch)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write('D');
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write('X');
            }


        }
        public void MoveHero(int input)
        {
            switch (input)
            {
                case 0:
                    if (Hero.Position.PosY != 0)
                        Hero.Position.PosY--;
                    break;
                case 1:
                    if (Hero.Position.PosX != MaxX - 1)
                        Hero.Position.PosX++;
                    break;
                case 2:
                    if (Hero.Position.PosY != MaxY - 1)
                        Hero.Position.PosY++;
                    break;
                case 3:
                    if (Hero.Position.PosX != 0)
                        Hero.Position.PosX--;
                    break;
            }
        }
        public int CharToNumber(ConsoleKey c)
        {
            switch(c)
            {
                case ConsoleKey.W: return 0;
                case ConsoleKey.UpArrow: return 0;
                case ConsoleKey.D: return 1;
                case ConsoleKey.RightArrow: return 1;
                case ConsoleKey.S: return 2;
                case ConsoleKey.DownArrow: return 2;
                case ConsoleKey.A: return 3;
                case ConsoleKey.LeftArrow: return 3;
                default: return 4;
            }
        }
        public void Fight()
        {
            var creatureToFight = Creatures.FirstOrDefault(creature => creature.Position.Equals(Hero.Position));
            if (creatureToFight != null)
            {
                while(creatureToFight.IsAlive && Hero.IsAlive) { 
                    creatureToFight.ReceiveHit(Hero.Hit());
                    if (!creatureToFight.IsAlive)
                    {
                        Creatures.Remove(creatureToFight);
                        DeadCreaturePositions.Add(creatureToFight.Position);
                    }
                    else
                    {
                        Hero.ReceiveHit(creatureToFight.Hit());
                    }
                }
                string winner = Hero.IsAlive ? "Hero" : "Creature";
                _logger.LogInfo(winner + " won!");
            }

        }
    }
}

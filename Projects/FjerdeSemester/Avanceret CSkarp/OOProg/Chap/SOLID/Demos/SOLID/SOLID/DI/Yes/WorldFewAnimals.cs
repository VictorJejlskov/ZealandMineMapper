﻿namespace SOLID.DI.Yes
{
    public class WorldFewAnimals : IWorld
    {
        public bool IsAnimalClose(string animalDesc)
        {
            // Low probability
            return false;
        }
    }
}
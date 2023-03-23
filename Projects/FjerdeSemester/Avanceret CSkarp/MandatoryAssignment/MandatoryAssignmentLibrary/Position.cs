using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentLibrary
{
    public class Position
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Position(int posX, int posY)
        {
            PosX = posX;
            PosY = posY;
        }

        public override string ToString()
        {
            return $"{{x: {PosX.ToString()}, y: {PosY.ToString()}}}";
        }
    }
}

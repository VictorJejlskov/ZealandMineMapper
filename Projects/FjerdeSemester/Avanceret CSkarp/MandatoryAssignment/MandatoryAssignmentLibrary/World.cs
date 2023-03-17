using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentLibrary
{
    public class World
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public List<Creature> Creatures { get; set; } = new List<Creature>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryThreading
{
    public class Bottle
    {
        public int Id { get; set; }
        private static int _nextId;
        public Bottle()
        {
            Id = _nextId++;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}}}";
        }
    }
}

using MandatoryAssignmentLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Sandbox
{
    public class WorldBuilder
    {
        private static List<string> _names = new List<string>();
        public static World NewWorld()
        {
            XmlDocument configDoc = new XmlDocument();
            string _path = Environment.GetEnvironmentVariable("GameFrameworkConfig");
            configDoc.Load(_path);

            var playground = configDoc.DocumentElement.SelectSingleNode("Playground");

            var maxX = Convert.ToInt32(playground.SelectSingleNode("MaxX").InnerText.ToString());
            var maxY = Convert.ToInt32(playground.SelectSingleNode("MaxY").InnerText.ToString());
            var amount = Convert.ToInt32(playground.SelectSingleNode("AmountOfCreatures").InnerText.ToString());


            if (_names.Count == 0)
            {
                var names = configDoc.DocumentElement.SelectSingleNode("CreatureNames").InnerText.ToString().Trim().Split("\n").ToList();
                names.ForEach(name => _names.Add(name.Trim()));
            }
            Random rnd = new Random();
            World newWorld = new World(maxX, maxY);
            for (int i = 0; i < amount; i++) CreatureBuilder.NewCreature(newWorld, _names[rnd.Next(0, _names.Count-1)]);
            return newWorld;
        }
    }
}

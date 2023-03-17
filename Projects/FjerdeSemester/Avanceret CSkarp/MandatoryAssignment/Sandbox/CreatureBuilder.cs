using MandatoryAssignmentLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sandbox
{
    public class CreatureBuilder
    {

        public Creature NewCreature(string name = null)
        {
            XmlDocument configDoc = new XmlDocument();
            string _path = Environment.GetEnvironmentVariable("GameFrameworkConfig");
            configDoc.Load(_path);

            var creatureOne = configDoc.DocumentElement.SelectNodes("Creature1");
            var newName = "";
            if (name == null) newName = creatureOne.Item(0).SelectSingleNode("Name").InnerText.ToString();
            else newName = name;
            var newHP = Convert.ToInt32(creatureOne.Item(0).SelectSingleNode("HitPoints").InnerText);
            var newPosX = Convert.ToInt32(creatureOne.Item(0).SelectSingleNode("PosX").InnerText);
            var newPosY = Convert.ToInt32(creatureOne.Item(0).SelectSingleNode("PosY").InnerText);

            return new Creature(name, newHP, new Position(newPosX, newPosY), null, null);
        }
    }
}

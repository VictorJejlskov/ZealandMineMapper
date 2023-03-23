using MandatoryAssignmentLibrary;
using MandatoryAssignmentLibrary.Builders;
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

        public static void NewCreature(World world, string name = null)
        {
            XmlDocument configDoc = new XmlDocument();
            string _path = Environment.GetEnvironmentVariable("GameFrameworkConfig");
            configDoc.Load(_path);


            var creatureTemplate = configDoc.DocumentElement.SelectSingleNode("Creature");
            var newName = "";
            if (name == null) newName = creatureTemplate.SelectSingleNode("Name").InnerText.ToString();
            else newName = name;
            var newHP = Convert.ToInt32(creatureTemplate.SelectSingleNode("Hitpoints").InnerText);
            var attackItemLimit = Convert.ToInt32(creatureTemplate.SelectSingleNode("AttackItemLimit").InnerText.ToString());
            var defenceItemLimit = Convert.ToInt32(creatureTemplate.SelectSingleNode("DefenceItemLimit").InnerText.ToString());
            Random rand = new Random();
            List<AttackItem> attackItems = AttackItemBuilder.GenerateItems(rand.Next(0, attackItemLimit) + 1);
            List<DefenceItem> defenceItems = DefenceItemBuilder.GenerateItems(rand.Next(0, defenceItemLimit) + 1);

            world.Creatures.Add(new Creature(newName, newHP, new Position(rand.Next(0, world.MaxX + 1), rand.Next(0, world.MaxY)), attackItems, defenceItems));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MandatoryAssignmentLibrary.Builders
{
    public class AttackItemBuilder
    {
        private static List<AttackItem> _attackItems = GenerateAttackItems();


        private static List<AttackItem> GenerateAttackItems()
        {
            XmlDocument configDoc = new XmlDocument();
            string _path = Environment.GetEnvironmentVariable("GameFrameworkConfig");
            configDoc.Load(_path);

            var weapons = configDoc.DocumentElement.SelectSingleNode("Weapons");
            List<AttackItem> items = new List<AttackItem>();
            for (int i = 0; i < weapons.ChildNodes.Count; i++)
            {
                var name = weapons.ChildNodes.Item(i).SelectSingleNode("Name").InnerText;
                var value = Convert.ToInt32(weapons.ChildNodes.Item(i).SelectSingleNode("Damage").InnerText);
                var range = Convert.ToInt32(weapons.ChildNodes.Item(i).SelectSingleNode("Range").InnerText);
                items.Add(new AttackItem(name, value, range));
            }
            return items;
        }

        public static AttackItem GetRandomItem()
        {
            Random rnd = new Random();
            return _attackItems[rnd.Next(0, _attackItems.Count)];
        }
        public static List<AttackItem> GenerateItems(int amount)
        {
            List<AttackItem> items = new List<AttackItem>();
            for (int i = 0; i < amount; i++)
            {
                items.Add(GetRandomItem());
            }
            return items;
        }
    }
}

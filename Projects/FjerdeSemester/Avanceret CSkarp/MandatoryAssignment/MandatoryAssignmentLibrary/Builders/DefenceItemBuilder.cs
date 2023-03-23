using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MandatoryAssignmentLibrary.Builders
{
    public class DefenceItemBuilder
    {
        private static List<DefenceItem> _defenceItems = GenerateDefenceItems();


        private static List<DefenceItem> GenerateDefenceItems()
        {
            XmlDocument configDoc = new XmlDocument();
            string _path = Environment.GetEnvironmentVariable("GameFrameworkConfig");
            configDoc.Load(_path);

            var armor = configDoc.DocumentElement.SelectSingleNode("Armor");
            List<DefenceItem> items = new List<DefenceItem>();
            for(int i = 0; i < armor.ChildNodes.Count; i++)
            {
                var name = armor.ChildNodes.Item(i).SelectSingleNode("Name").InnerText;
                var value = Convert.ToInt32(armor.ChildNodes.Item(i).SelectSingleNode("DefenceValue").InnerText);
                items.Add(new DefenceItem(name, value));
            }
            return items;
        }

        public static DefenceItem GetRandomItem()
        {
            Random rnd = new Random();
            return _defenceItems[rnd.Next(0, _defenceItems.Count)];
        }
        public static List<DefenceItem> GenerateItems(int amount)
        {
            List<DefenceItem> items = new List<DefenceItem> ();
            for (int i = 0; i < amount; i++)
            {
                items.Add(GetRandomItem());
            }
            return items;
        }

    }
}

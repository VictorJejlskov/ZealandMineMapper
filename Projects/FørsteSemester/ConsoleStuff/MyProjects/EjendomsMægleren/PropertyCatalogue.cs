using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EjendomsMægleren
{
    class PropertyCatalogue
    {
        public static Dictionary<int, Property> PropDictionary = new Dictionary<int, Property>();

        public static void AddProperty(Property inputPropery)
        {
            PropDictionary.Add(inputPropery.PropertyID, inputPropery);
        }

        public static Property RemoveProperty(Property inputProperty)
        {
            PropDictionary.Remove(inputProperty.PropertyID);
            return inputProperty;
        }

        public static List<Property> GetAll()
        {
            return PropDictionary.Values.ToList();
        }

        public static List<Property> FilteredList(Property.PropertyTypes PropType)
        {
            List<Property> unfilteredList = GetAll();
            List<Property> filteredList = new List<Property>();
            foreach (Property prop in unfilteredList)
            {
                if (prop.PropertyType == PropType)
                {
                    filteredList.Add(prop);
                }
            }
            return filteredList;
        }

        public static List<Property> GetByPrice(int input)
        {
            List<Property> priceProperty = new List<Property>();
            foreach (Property prop in GetAll())
            {
                if (prop.PropertyPrice <= input)
                {
                    priceProperty.Add(prop);
                }
            }
            return priceProperty;
        }
        public static List<Property> GetBySize(int input)
        {
            List<Property> sizeProperty =  new List<Property>();
            foreach (Property prop in GetAll())
            {
                if (prop.PropertySize >= input)
                {
                    sizeProperty.Add(prop);
                }
            }
            return sizeProperty;
        }
        public static Property GetByID(int input)
        {
            return PropDictionary[input];
        }
        public static void PrintList(List<Property> inputList)
        {
            foreach (Property prop in inputList)
            {
                Console.WriteLine(prop);
            }
        }
    }
}

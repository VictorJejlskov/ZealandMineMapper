using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJsonLib
{
    public static class MyJsonConverter
    {
        public static String Serialize<T>(T obj)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");

            Type t = obj.GetType();

            var props = t.GetProperties();
            foreach (var prop in props)
            {
                if (prop.PropertyType.IsPrimitive || prop.PropertyType == typeof(string))
                {
                    sb.Append($"\"{prop.Name}\":\"{prop.GetValue(obj, null)}\",");
                }
                else if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    sb.Append($"\"{prop.Name}\":[");
                    var list = (IEnumerable)prop.GetValue(obj, null);
                    foreach (var item in list)
                    {
                        sb.Append($"\"{item}\",");
                    }
                    sb.Remove(sb.Length - 1, 1); // Remove the trailing comma
                    sb.Append("],");
                }
                else
                {
                    sb.Append($"\"{prop.Name}\":{Serialize(prop.GetValue(obj, null))},");
                }
            }

            sb.Remove(sb.Length - 1, 1); // Remove the trailing comma
            sb.Append("}");

            string json = sb.ToString();

            return sb.ToString();

        }

        //public static T Deserialize<T>(string json)
        //{

        //}
    }
}

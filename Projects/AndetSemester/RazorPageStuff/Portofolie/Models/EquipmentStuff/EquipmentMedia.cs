using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portofolie.Models.EquipmentStuff
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class SelfMed
    {
        public string href { get; set; }
    }

    public class LinksMed
    {
        public SelfMed self { get; set; }
    }

    public class Asset
    {
        public string key { get; set; }
        public string value { get; set; }
        public int file_data_id { get; set; }
    }

    public class EquippedItemMedia
    {
        public LinksMed _links { get; set; }
        public List<Asset> assets { get; set; }
        public int id { get; set; }
    }


}

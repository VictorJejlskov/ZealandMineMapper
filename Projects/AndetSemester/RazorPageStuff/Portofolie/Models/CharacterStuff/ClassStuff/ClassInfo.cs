using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portofolie.Models.CharacterStuff.ClassStuff
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
    }

    public class GenderName
    {
        public string male { get; set; }
        public string female { get; set; }
    }

    public class Key
    {
        public string href { get; set; }
    }

    public class PowerType
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Specialization
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Media
    {
        public Key key { get; set; }
        public int id { get; set; }
    }

    public class PvpTalentSlots
    {
        public string href { get; set; }
    }

    public class ClassInfo
    {
        public Links _links { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public GenderName gender_name { get; set; }
        public PowerType power_type { get; set; }
        public List<Specialization> specializations { get; set; }
        public Media media { get; set; }
        public PvpTalentSlots pvp_talent_slots { get; set; }
    }


}

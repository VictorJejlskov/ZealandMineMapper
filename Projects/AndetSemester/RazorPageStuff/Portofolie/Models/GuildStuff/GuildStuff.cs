using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portofolie.Models.GuildStuff
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

    public class Key
    {
        public string href { get; set; }
    }

    public class Realm
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string slug { get; set; }
    }

    public class Faction
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Guild
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public Realm realm { get; set; }
        public Faction faction { get; set; }
    }

    public class PlayableClass
    {
        public Key key { get; set; }
        public int id { get; set; }
    }

    public class PlayableRace
    {
        public Key key { get; set; }
        public int id { get; set; }
    }

    public class Character
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public Realm realm { get; set; }
        public int level { get; set; }
        public PlayableClass playable_class { get; set; }
        public PlayableRace playable_race { get; set; }
    }

    public class Member
    {
        public Character character { get; set; }
        public int rank { get; set; }
    }

    public class GuildInfo
    {
        public Links _links { get; set; }
        public Guild guild { get; set; }
        public List<Member> members { get; set; }
    }


}

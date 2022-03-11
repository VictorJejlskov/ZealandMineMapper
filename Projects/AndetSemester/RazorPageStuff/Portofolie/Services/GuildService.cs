using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portofolie.Models.GuildStuff;

namespace Portofolie.Services
{
    public class GuildService
    {
        public List<Member> Members;

        public List<Member> SortByRank(List<Member> members)
        {
            List<Member> sortedList = new List<Member>();
            sortedList.AddRange(members.Where(x => x.rank == 0));
            sortedList.AddRange(members.Where(x => x.rank == 1));
            sortedList.AddRange(members.Where(x => x.rank == 3));
            sortedList.AddRange(members.Where(x => x.rank == 4));
            sortedList.AddRange(members.Where(x => x.rank == 2));
            sortedList.AddRange(members.Where(x => x.rank == 5));
            sortedList.AddRange(members.Where(x => x.rank == 6));
            sortedList.AddRange(members.Where(x => x.rank == 7));
            sortedList.AddRange(members.Where(x => x.rank == 8));
            sortedList.AddRange(members.Where(x => x.rank == 9));
            return sortedList;
        }
        public List<Member> SortByRankDescending(List<Member> members)
        {
            List<Member> sortedList = new List<Member>();
            sortedList.AddRange(members.Where(x => x.rank == 9));
            sortedList.AddRange(members.Where(x => x.rank == 8));
            sortedList.AddRange(members.Where(x => x.rank == 7));
            sortedList.AddRange(members.Where(x => x.rank == 6));
            sortedList.AddRange(members.Where(x => x.rank == 5));
            sortedList.AddRange(members.Where(x => x.rank == 2));
            sortedList.AddRange(members.Where(x => x.rank == 4));
            sortedList.AddRange(members.Where(x => x.rank == 3));
            sortedList.AddRange(members.Where(x => x.rank == 1));
            sortedList.AddRange(members.Where(x => x.rank == 0));
            return sortedList;
        }

        public List<Member> SortByName(List<Member> members)
        {
            List<Member> sortedList = members.OrderBy(m => m.character.name).ToList();
            return sortedList;
        }
        public List<Member> SortByNameDescending(List<Member> members)
        {
            List<Member> sortedList = members.OrderByDescending(m => m.character.name).ToList();
            return sortedList;
        }

        public List<Member> SortByClass(List<Member> members)
        {
            List<Member> sortedList = members.OrderBy(m => m.character.playable_class.id).ThenBy(m => m.rank).ToList();
            return sortedList;
        }
        public List<Member> SortByClassDescending(List<Member> members)
        {
            List<Member> sortedList = members.OrderByDescending(m => m.character.playable_class.id).ThenBy(m => m.rank).ToList();
            return sortedList;
        }
        public List<Member> SortByRace(List<Member> members)
        {
            List<Member> sortedList = members.OrderBy(m => m.character.playable_race.id).ThenBy(m => m.rank).ToList();
            return sortedList;
        }
        public List<Member> SortByRaceDescending(List<Member> members)
        {
            List<Member> sortedList = members.OrderByDescending(m => m.character.playable_race.id).ThenBy(m => m.rank).ToList();
            return sortedList;
        }
    }
}

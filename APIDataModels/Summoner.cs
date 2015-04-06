using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDataModels
{
    public class SummonerDto
    {
        public long id { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public long summonerLevel { get; set; }
    }

    public class MasteryPagesDto
    {
        public List<MasteryPageDto> pages { get; set; }
        public long summonerId { get; set; }
    }

    public class MasteryPageDto
    {
        public bool current { get; set; }
        public long id { get; set; }
        public List<MasteryDto> masteries { get; set; }
        public string name { get; set; }
    }

    public class MasteryDto
    {
        public int id { get; set; }
        public int rank { get; set; }
    }

    public class RunePagesDto
    {
        public List<RunePageDto> pages { get; set; }
        public long summonerId { get; set; }
    }

    public class RunePageDto
    {
        public bool current { get; set; }
        public long id { get; set; }
        public string name { get; set; }
        public List<RuneSlotDto> slots { get; set; }
    }

    public class RuneSlotDto
    {
        public int runeId { get; set; }
        public int runeSlotId { get; set; }
    }
}

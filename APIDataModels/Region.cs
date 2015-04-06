using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDataModels
{
    public enum Region
    {
            [Description("br")]
            br = 0,
            [Description("eune")]
            eune = 1,
            [Description("euw")]
            euw = 2,
            [Description("kr")]
            kr = 3,
            [Description("lan")]
            lan = 4,
            [Description("las")]
            las = 5,
            [Description("na")]
            na = 6,
            [Description("oce")]
            oce = 7,
            [Description("ru")]
            ru = 8,
            [Description("tr")]
            tr = 9
    }
    public enum PlatformId
    {
        [Description("na1")]
        Na1 = 0,
        [Description("br1")]
        Br1 = 1,
        [Description("la1")]
        La1 = 2,
        [Description("la2")]
        La2 = 3,
        [Description("oc1")]
        Oc1 = 4,
        [Description("eun1")]
        Eun1 = 5,
        [Description("tr1")]
        Tr1 = 6,
        [Description("ru")]
        Ru = 7,
        [Description("euw1")]
        Euw1 = 8,
        [Description("kr")]
        Kr = 9,
        [Description("pbe1")]
        Pbe1 = 10
    }
    public enum LeagueType
    {
        [Description("RANKED_SOLO_5x5")]
        RANKED_SOLO_5x5 = 0,
        [Description("RANKED_TEAM_3x3")]
        RANKED_TEAM_3x3 = 1,
        [Description("RANKED_TEAM_5x5")]
        RANKED_TEAM_5x5 = 2
    }

}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIDataModels.Static.Champion
{

    #region Champion

    public class ChampionListDto
    {
        public Dictionary<string, ChampionDto> data { get; set; }
        public string format { get; set; }
        public Dictionary<string, string> keys { get; set; }
        public string type { get; set; }
        public string version { get; set; }

    }

    public class ChampionDto
    {
        public List<string> allytips { get; set; }
        public string blurb { get; set; }
        public List<string> enemytips { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public InfoDto info { get; set; }
        public string key { get; set; }
        public string lore { get; set; }
        public string name { get; set; }
        public string partype { get; set; }
        public PassiveDto passive { get; set; }
        public List<RecommendedDto> recommended { get; set; }
        public List<SkinDto> skins { get; set; }
        public List<ChampionSpellDto> spells { get; set; }
        public StatsDto stats { get; set; }
        public List<string> tags { get; set; }
        public string title { get; set; }
    }

    public class InfoDto
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int difficulty { get; set; }
        public int magic { get; set; }
    }

    public class StatsDto
    {
        public double armor { get; set; }
        public double armorperlevel { get; set; }
        public double attackdamage { get; set; }
        public double attackdamageperlevel { get; set; }
        public double attackrange { get; set; }
        public double attackspeedoffset { get; set; }
        public double attackspeedperlevel { get; set; }
        public double crit { get; set; }
        public double critperlevel { get; set; }
        public double hp { get; set; }
        public double hpperlevel { get; set; }
        public double hpregen { get; set; }
        public double hpregenperlevel { get; set; }
        public double movespeed { get; set; }
        public double mp { get; set; }
        public double mpperlevel { get; set; }
        public double mpregen { get; set; }
        public double mpregenperlevel { get; set; }
        public double spellblock { get; set; }
        public double spellblockperlevel { get; set; }
    }

    public class SkinDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int num { get; set; }
    }

    public class RecommendedDto
    {
        public List<BlockDto> blocks { get; set; }
        public string champion { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public bool priority { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class BlockDto
    {
        public List<BlockItemDto> items { get; set; }
        public bool recMath { get; set; }
        public string type { get; set; }
    }

    public class BlockItemDto
    {
        public int count { get; set; }
        public int id { get; set; }
    }

    public class PassiveDto
    {
        public string description { get; set; }
        public ImageDto image { get; set; }
        public string name { get; set; }
        public string sanitizedDescription { get; set; }
    }

    public class ChampionSpellDto
    {
        public List<ImageDto> altimages { get; set; }
        public List<double> cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public List<int> cost { get; set; }
        public string costBurn { get; set; }
        public string costType { get; set; }
        public string description { get; set; }
        public List<List<double>> effect { get; set; }
        public List<string> effectBurn { get; set; }
        public ImageDto image { get; set; }
        public string key { get; set; }
        public LevelTipDto leveltip { get; set; }
        public int maxrank { get; set; }
        public string name { get; set; }
        public object range { get; set; }
        //This field is either a List of Integer or the String 'self' for spells that target one's own champion.
        public string rangeBurn { get; set; }
        public string resource { get; set; }
        public string sanitizedDescription { get; set; }
        public string sanitizedTooltip { get; set; }
        public string tooltip { get; set; }
        public List<SpellVarsDto> vars { get; set; }
    }

    public class LevelTipDto
    {
        public List<string> spellblockperlevel { get; set; }
        public List<string> label { get; set; }
    }

    public class ImageDto
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int difficulty { get; set; }
        public int magic { get; set; }
    }

    #endregion
}
namespace APIDataModels.Static.Item
{
    #region Item
    public class ItemListDto
    {
        public BasicDataDto basic { get; set; }
        public Dictionary<string, ItemDto> data { get; set; }
        public List<GroupDto> groups { get; set; }
        public List<ItemTreeDto> tree { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }

    public class ItemTreeDto
    {
        public string header { get; set; }
        public List<string> tags { get; set; }
    }

    public class ItemDto
    {
        public string colloq { get; set; }
        public bool consumeOnFull { get; set; }
        public bool consumed { get; set; }
        public int depth { get; set; }
        public string description { get; set; }
        public Dictionary<string, string> effect { get; set; }
        public List<string> from { get; set; }
        public GoldDto gold { get; set; }
        public string group { get; set; }
        public bool hideFromAll { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public bool inStore { get; set; }
        public List<string> into { get; set; }
        public Dictionary<string, bool> maps { get; set; }
        public string name { get; set; }
        public string plaintext { get; set; }
        public string requiredChampion { get; set; }
        public MetaDataDto rune { get; set; }
        public string sanitizedDescription { get; set; }
        public int specialRecipe { get; set; }
        public int stacks { get; set; }
        public BasicDataStatsDto stats { get; set; }
        public List<string> tags { get; set; }
    }

    public class ImageDto
    {
        public string full { get; set; }
        public string group { get; set; }
        public int h { get; set; }
        public string sprite { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }


    public class GroupDto
    {
        public string MaxGroupOwnable { get; set; }
        public string key { get; set; }
    }

    #endregion

}
namespace APIDataModels.Static.Language
{
    #region Language

    public class LanguageStringsDto
    {
        public Dictionary<string,string> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }

    #endregion

}
namespace APIDataModels.Static
{
    #region reusables

    public class SpellVarsDto
    {
        public List<double> coeff { get; set; }
        public string dyn { get; set; }
        public string key { get; set; }
        public string link { get; set; }
        public string ranksWith { get; set; }
    }

    public class GoldDto
    {
        [JsonProperty(PropertyName = "base")]
        public int baseAmount { get; set; }//original is base but C# reserves base

        public bool purchasable { get; set; }
        public int sell { get; set; }
        public int total { get; set; }
    }

    public class BasicDataDto
    {
        public string colloq { get; set; }
        public bool consumeOnFull { get; set; }
        public bool consumed { get; set; }
        public int depth { get; set; }
        public string description { get; set; }
        public List<string> from { get; set; }
        public GoldDto gold { get; set; }//Data Dragon includes the gold field for basic data, which is shared by both rune and item. However, only items have a gold field on them, representing their gold cost in the store. Since runes are not sold in the store, they have no gold cost.
        public string group { get; set; }
        public bool hideFromAll { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public bool inStore { get; set; }
        public List<string> into { get; set; }
        public Dictionary<string, bool> maps { get; set; }
        public string name { get; set; }
        public string plaintext { get; set; }
        public string requiredChampion { get; set; }
        public MetaDataDto rune { get; set; }
        public string sanitizedDescription { get; set; }
        public int specialRecipe { get; set; }
        public int stacks { get; set; }
        public BasicDataStatsDto stats { get; set; }
        public List<string> tags { get; set; }
    }

    public class BasicDataStatsDto
    {
        public double FlatArmorMod { get; set; }
        public double FlatAttackSpeedMod { get; set; }
        public double FlatBlockMod { get; set; }
        public double FlatCritChanceMod { get; set; }
        public double FlatCritDamageMod { get; set; }
        public double FlatEXPBonus { get; set; }
        public double FlatEnergyPoolMod { get; set; }
        public double FlatEnergyRegenMod { get; set; }
        public double FlatHPPoolMod { get; set; }
        public double FlatHPRegenMod { get; set; }
        public double FlatMPPoolMod { get; set; }
        public double FlatMPRegenMod { get; set; }
        public double FlatMagicDamageMod { get; set; }
        public double FlatMovementSpeedMod { get; set; }
        public double FlatPhysicalDamageMod { get; set; }
        public double FlatSpellBlockMod { get; set; }
        public double PercentArmorMod { get; set; }
        public double PercentAttackSpeedMod { get; set; }
        public double PercentBlockMod { get; set; }
        public double PercentCritChanceMod { get; set; }
        public double PercentCritDamageMod { get; set; }
        public double PercentDodgeMod { get; set; }
        public double PercentEXPBonus { get; set; }
        public double PercentHPPoolMod { get; set; }
        public double PercentHPRegenMod { get; set; }
        public double PercentLifeStealMod { get; set; }
        public double PercentMPPoolMod { get; set; }
        public double PercentMPRegenMod { get; set; }
        public double PercentMagicDamageMod { get; set; }
        public double PercentMovementSpeedMod { get; set; }
        public double PercentPhysicalDamageMod { get; set; }
        public double PercentSpellBlockMod { get; set; }
        public double PercentSpellVampMod { get; set; }
        public double rFlatArmorModPerLevel { get; set; }
        public double rFlatArmorPenetrationMod { get; set; }
        public double rFlatArmorPenetrationModPerLevel { get; set; }
        public double rFlatCritChanceModPerLevel { get; set; }
        public double rFlatCritDamageModPerLevel { get; set; }
        public double rFlatDodgeMod { get; set; }
        public double rFlatDodgeModPerLevel { get; set; }
        public double rFlatEnergyModPerLevel { get; set; }
        public double rFlatEnergyRegenModPerLevel { get; set; }
        public double rFlatGoldPer10Mod { get; set; }
        public double rFlatHPModPerLevel { get; set; }
        public double rFlatHPRegenModPerLevel { get; set; }
        public double rFlatMPModPerLevel { get; set; }
        public double rFlatMPRegenModPerLevel { get; set; }
        public double rFlatMagicDamageModPerLevel { get; set; }
        public double rFlatMagicPenetrationMod { get; set; }
        public double rFlatMagicPenetrationModPerLevel { get; set; }
        public double rFlatMovementSpeedModPerLevel { get; set; }
        public double rFlatPhysicalDamageModPerLevel { get; set; }
        public double rFlatSpellBlockModPerLevel { get; set; }
        public double rFlatTimeDeadMod { get; set; }
        public double rFlatTimeDeadModPerLevel { get; set; }
        public double rPercentArmorPenetrationMod { get; set; }
        public double rPercentArmorPenetrationModPerLevel { get; set; }
        public double rPercentAttackSpeedModPerLevel { get; set; }
        public double rPercentCooldownMod { get; set; }
        public double rPercentCooldownModPerLevel { get; set; }
        public double rPercentMagicPenetrationMod { get; set; }
        public double rPercentMagicPenetrationModPerLevel { get; set; }
        public double rPercentMovementSpeedModPerLevel { get; set; }
        public double rPercentTimeDeadMod { get; set; }
        public double rPercentTimeDeadModPerLevel { get; set; }
    }
    #endregion

    #region Map

    public class MapDataDto
    {
        public Dictionary<string,MapDetailsDto> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }

    public class MapDetailsDto
    {
        public ImageDto Type { get; set; }
        public long mapId { get; set; }
        public string mapName { get; set; }
        public List<long> unpurchasableItemList { get; set; }
    }

    public class MetaDataDto
    {
        public bool isRune { get; set; }
        public string tier { get; set; }
        public string type { get; set; }
    }
     
    public class ImageDto
    {
        public string full { get; set; }
        public string group { get; set; }
        public int h { get; set; }
        public string sprite { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    #endregion

    #region Mastery

    public class MasteryListDto
    {
        public Dictionary<string,MasteryDto> data { get; set; }
        public MasteryTreeDto tree { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }

    public class MasteryTreeDto
    {
        public List<MastryTreeListDto> Defense { get; set; }
        public List<MastryTreeListDto> Offense { get; set; }
        public List<MastryTreeListDto> Utility { get; set; }
    }

    public class MastryTreeListDto
    {
        public List<MasteryTreeItemDto> masteryTreeItems { get; set; }
    }

    public class MasteryTreeItemDto
    {
        public int masteryId { get; set; }
        public string prereq { get; set; }
    }

    public class MasteryDto
    {
        public List<string> description { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public string masteryTree { get; set; } //Legal values: Defense, Offense, Utility
        public string name { get; set; }
        public string prereq { get; set; }
        public int ranks { get; set; }
        public List<string> sanitizedDescription { get; set; }
    }

    #endregion

    #region Realm

    public class RealmDto
    {
        public string cdn { get; set; }
        public string css { get; set; }
        public string dd { get; set; }
        public string l { get; set; }
        public string lg { get; set; }
        public Dictionary<string,string> n { get; set; }
        public int profileiconmax { get; set; }
        public string store { get; set; }
        public string v { get; set; }
    }

    #endregion

    #region Runes

    public class RuneListDto
    {
        public BasicDataDto basic { get; set; }
        public Dictionary<string, RuneDto> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }

    public class RuneDto
    {
        public string colloq { get; set; }
        public bool consumeOnFull { get; set; }
        public bool consumed { get; set; }
        public int depth { get; set; }
        public string description { get; set; }
        public List<string> from { get; set; }
        public string group { get; set; }
        public bool hideFromAll { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public bool inStore { get; set; }
        public List<string> into { get; set; }
        public Dictionary<string,bool> maps { get; set; }
        public string name { get; set; }
        public string plaintext { get; set; }
        public string requiredChampion { get; set; }
        public int specialRecipe { get; set; }
        public int stacks { get; set; }
        public BasicDataStatsDto stats { get; set; }
        public List<string> tags { get; set; }
    }



    #endregion

    #region SummonerSpells

    public class SummonerSpellListDto
    {
        public Dictionary<string,SummonerSpellDto> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }

    public class SummonerSpellDto
    {
        public List<double> cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public List<int> cost { get; set; }
        public string costBurn { get; set; }
        public string costType { get; set; }
        public string description { get; set; }
        public List<List<double>> effect { get; set; }
        public List<string> effectBurn { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public string key { get; set; }
        public LevelTipDto leveltip { get; set; }
        public int maxrank { get; set; }
        public List<string> modes { get; set; }
        public string name { get; set; }
        public object range { get; set; } //This field is either a List of Integer or the String 'self' for spells that target one's own champion.
        public string rangeBurn { get; set; }
        public string resource { get; set; }
        public string sanitizedDescription { get; set; }
        public string sanitizedTooltip { get; set; }
        public int summonerLevel { get; set; }
        public string tooltip { get; set; }
        public List<SpellVarsDto> vars { get; set; }
    }

    public class LevelTipDto
    {
        public List<string> effect { get; set; }
        public List<string> label { get; set; }
    }

    #endregion
}
using Terraria;
using static Terraria.ID.ItemID;
using Terraria.ModLoader;

public class RecipeGroups : ModSystem
{
    public override void AddRecipeGroups()
    {
        // All types of goblin banners
        RecipeGroup.RegisterGroup("GoblinBanner", new RecipeGroup(() => "Any Goblin Banners", new int[]
        {
            GoblinArcherBanner,
            GoblinPeonBanner,
            GoblinScoutBanner,
            GoblinSorcererBanner,
            GoblinSummonerBanner,
            GoblinThiefBanner,
            GoblinWarriorBanner
        }));

        // All types of crowns
        RecipeGroup.RegisterGroup("Crown", new RecipeGroup(() => "Any Crowns", new int[]
        {
            GoldCrown,
            PlatinumCrown
        }));

        // All types of spider banners
        RecipeGroup.RegisterGroup("SpiderBanner", new RecipeGroup(() => "Any Spider Banners", new int[]
        {
            BlackRecluseBanner,
            BloodCrawlerBanner,
            JungleCreeperBanner,
            SpiderBanner
        }));

        // All anvil types
        RecipeGroup.RegisterGroup("Anvil", new RecipeGroup(() => "Any Anvils", new int[]
        {
            IronAnvil,
            LeadAnvil,
            MythrilAnvil,
            OrichalcumAnvil,
        }));

        // All types of souls
        RecipeGroup.RegisterGroup("Soul", new RecipeGroup(() => "Any Souls", new int[]
        { 
            SoulofFlight,
            SoulofFright,
            SoulofLight,
            SoulofMight,
            SoulofNight,
            SoulofSight
        }));

        // All Wooden hammers
        RecipeGroup.RegisterGroup("WoodenHammer", new RecipeGroup(() => "All Wooden Hammers", new int[]{
            WoodenHammer,
            PalmWoodHammer,
            BorealWoodHammer,
            RichMahoganyHammer,
            EbonwoodHammer,
            ShadewoodHammer,
            PearlwoodHammer
        }));

        // All Wooden bows
        RecipeGroup.RegisterGroup("WoodenBow", new RecipeGroup(() => "Any Wooden Similar Bows", new int[]{
            WoodenBow,
            PalmWoodBow,
            BorealWoodBow,
            RichMahoganyBow,
            EbonwoodBow,
            ShadewoodBow,
            PearlwoodBow,
        }));

        // Copper or Tin axes
        RecipeGroup.RegisterGroup("CTAxe", new RecipeGroup(() => "Copper or Tin Axes", new int[]
        {
            CopperAxe,
            TinAxe
        }));

        // Copper or Tin pickaxes
        RecipeGroup.RegisterGroup("CTPickaxe", new RecipeGroup(() => "Copper or Tin pickaxes", new int[]
        {
            CopperPickaxe,
            TinPickaxe
        }));

        // Copper or Tin
        RecipeGroup.RegisterGroup("CT", new RecipeGroup(() => "Copper or Tin", new int[]
        {
            CopperBar,
            TinBar
        }));

        // Iron or Lead
        RecipeGroup.RegisterGroup("IL", new RecipeGroup(() => "Iron or Lead", new int[]
        {
            IronBar,
            LeadBar
        }));

        // Silver or Tungsten
        RecipeGroup.RegisterGroup("ST", new RecipeGroup(() => "Silver or Tungsten", new int[]
        {
            SilverBar,
            TungstenBar
        }));

        // Gold or Platinum
        RecipeGroup.RegisterGroup("GP", new RecipeGroup(() => "Gold or Platinum", new int[]
        {
            GoldBar,
            PlatinumBar
        }));

        // Demonite or Crimtane
        RecipeGroup.RegisterGroup("DC", new RecipeGroup(() => "Demonite or Crimtane", new int[]
        {
            DemoniteBar,
            CrimtaneBar
        }));

        // Cobalt or Palladium
        RecipeGroup.RegisterGroup("CP", new RecipeGroup(() => "Cobalt or Palladium", new int[]
        {
            CobaltBar,
            PalladiumBar
        }));

        // Mythril or Orichalcum
        RecipeGroup.RegisterGroup("MO", new RecipeGroup(() => "Mythril or Orichalcum", new int[]
        {
            MythrilBar,
            OrichalcumBar
        }));

        // Adamantite or Titanium
        RecipeGroup.RegisterGroup("AT", new RecipeGroup(() => "Adamantite or Titanium", new int[]
        {
            AdamantiteBar,
            TitaniumBar
        }));

        // Crimtane or Demonite
        RecipeGroup.RegisterGroup("CD", new RecipeGroup(() => "Crimtane or Demonite", new int[]
        {
            CrimtaneOre,
            DemoniteOre
        }));

        // shadow scales or tissue samples
        RecipeGroup.RegisterGroup("SS", new RecipeGroup(() => "Shadow Scales or Tissue Samples", new int[]
        {
            ShadowScale,
            TissueSample
        }));
    }
}
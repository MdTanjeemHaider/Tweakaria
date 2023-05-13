using static Terraria.ID.ItemID;
using Terraria.ModLoader;

public class Exchanges : ModSystem
{
    public override void AddRecipes()
    {
        // Ore exchanges
        RecipeAdder.TwoWayExchange(CopperOre, TinOre);
        RecipeAdder.TwoWayExchange(IronOre, LeadOre);
        RecipeAdder.TwoWayExchange(SilverOre, TungstenOre);
        RecipeAdder.TwoWayExchange(GoldOre, PlatinumOre);
        RecipeAdder.TwoWayExchange(CrimtaneOre, DemoniteOre);
        RecipeAdder.TwoWayExchange(CobaltOre, PalladiumOre);
        RecipeAdder.TwoWayExchange(MythrilOre, OrichalcumOre);
        RecipeAdder.TwoWayExchange(AdamantiteOre, TitaniumOre);

        // Bar exchanges
        RecipeAdder.TwoWayExchange(CopperBar, TinBar);
        RecipeAdder.TwoWayExchange(IronBar, LeadBar);
        RecipeAdder.TwoWayExchange(SilverBar, TungstenBar);
        RecipeAdder.TwoWayExchange(GoldBar, PlatinumBar);
        RecipeAdder.TwoWayExchange(CrimtaneBar, DemoniteBar);
        RecipeAdder.TwoWayExchange(CobaltBar, PalladiumBar);
        RecipeAdder.TwoWayExchange(MythrilBar, OrichalcumBar);
        RecipeAdder.TwoWayExchange(AdamantiteBar, TitaniumBar);

        // Evil materials/blocks/orb & heart drops exchanges
        RecipeAdder.TwoWayExchange(Vertebrae, RottenChunk);
        RecipeAdder.TwoWayExchange(Ichor, CursedFlame);
        RecipeAdder.TwoWayExchange(TissueSample, ShadowScale);
        RecipeAdder.TwoWayExchange(ViciousMushroom, VileMushroom);
        RecipeAdder.TwoWayExchange(Ichor, CursedFlame);
        RecipeAdder.TwoWayExchange(CrimsonSeeds, CorruptSeeds);
        RecipeAdder.TwoWayExchange(CrimstoneBlock, EbonstoneBlock);
        RecipeAdder.TwoWayExchange(CrimsonKey, CorruptionKey);
        RecipeAdder.TwoWayExchange(CrimsonTigerfish, Ebonkoi);
        RecipeAdder.TwoWayExchange(Shadewood, Ebonwood);
        RecipeAdder.TwoWayExchange(CrimsonHeart, ShadowOrb);
        RecipeAdder.TwoWayExchange(CrimsonRod, Vilethorn);
        RecipeAdder.TwoWayExchange(TheRottedFork, BallOHurt);
        RecipeAdder.TwoWayExchange(BoneRattle,EatersBone);
        RecipeAdder.TwoWayExchange(BrainOfConfusion, WormScarf);
        RecipeAdder.TwoWayExchange(PanicNecklace, BandofStarpower);
        RecipeAdder.TwoWayExchange(TheUndertaker, Musket);

        // Mimic drops exchanges
        RecipeAdder.TwoWayExchange(DartPistol, DartRifle);
        RecipeAdder.TwoWayExchange(SoulDrain, ClingerStaff);
        RecipeAdder.TwoWayExchange(TendonHook, WormHook);
        RecipeAdder.TwoWayExchange(FetidBaghnakhs, ChainGuillotines);
        RecipeAdder.TwoWayExchange(FleshKnuckles, PutridScent);

        // Head armour exchanges
        RecipeAdder.ThreeWayExchange(CobaltHat, CobaltMask, CobaltHelmet);
        RecipeAdder.ThreeWayExchange(PalladiumHeadgear, PalladiumMask, PalladiumHelmet);
        RecipeAdder.ThreeWayExchange(MythrilHood, MythrilHat, MythrilHelmet);
        RecipeAdder.ThreeWayExchange(OrichalcumHeadgear, OrichalcumMask, OrichalcumHelmet);
        RecipeAdder.ThreeWayExchange(TitaniumHeadgear, TitaniumMask, TitaniumHelmet);
        RecipeAdder.ThreeWayExchange(AdamantiteHeadgear, AdamantiteMask, AdamantiteHelmet);
        RecipeAdder.FourWayExchange(HallowedHeadgear, HallowedMask, HallowedHelmet, HallowedHood);
        RecipeAdder.FourWayExchange(AncientHallowedHeadgear, AncientHallowedMask, AncientHallowedHelmet, AncientHallowedHood);
        RecipeAdder.ThreeWayExchange(ChlorophyteHeadgear, ChlorophyteMask, ChlorophyteHelmet);
        RecipeAdder.ThreeWayExchange(ShroomiteHeadgear, ShroomiteMask, ShroomiteHelmet);
        RecipeAdder.TwoWayExchange(SpectreHood, SpectreMask);
        RecipeAdder.TwoWayExchange(BeetleShell, BeetleScaleMail);
    }
}
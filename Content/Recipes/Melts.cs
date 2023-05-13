using static Terraria.ID.ItemID;
using Terraria.ModLoader;

public class Melts : ModSystem
{
    public override void AddRecipes()
    {
        // Will only refund 80% of bars used to craft the item, nothing else

        // Armours
        RecipeAdder.Melt(CopperHelmet, CopperBar, 9);
        RecipeAdder.Melt(CopperChainmail, CopperBar, 16);
        RecipeAdder.Melt(CopperGreaves, CopperBar, 12);
        RecipeAdder.Melt(TinHelmet, TinBar, 9);
        RecipeAdder.Melt(TinChainmail, TinBar, 16);
        RecipeAdder.Melt(TinGreaves, TinBar, 12);
        RecipeAdder.Melt(IronHelmet, IronBar, 12);
        RecipeAdder.Melt(IronChainmail, IronBar, 20);
        RecipeAdder.Melt(IronGreaves, IronBar, 16);
        RecipeAdder.Melt(LeadHelmet, LeadBar, 12);
        RecipeAdder.Melt(LeadChainmail, LeadBar, 20);
        RecipeAdder.Melt(LeadGreaves, LeadBar, 16);
        RecipeAdder.Melt(SilverHelmet, SilverBar, 12);
        RecipeAdder.Melt(SilverChainmail, SilverBar, 20);
        RecipeAdder.Melt(SilverGreaves, SilverBar, 16);
        RecipeAdder.Melt(TungstenHelmet, TungstenBar, 12);
        RecipeAdder.Melt(TungstenChainmail, TungstenBar, 20);
        RecipeAdder.Melt(TungstenGreaves, TungstenBar, 16);
        RecipeAdder.Melt(GoldHelmet, GoldBar, 16);
        RecipeAdder.Melt(GoldChainmail, GoldBar, 24);
        RecipeAdder.Melt(GoldGreaves, GoldBar, 20);
        RecipeAdder.Melt(PlatinumHelmet, PlatinumBar, 16);
        RecipeAdder.Melt(PlatinumChainmail, PlatinumBar, 24);
        RecipeAdder.Melt(PlatinumGreaves, PlatinumBar, 20);
        RecipeAdder.Melt(MeteorHelmet, MeteoriteBar, 10);
        RecipeAdder.Melt(MeteorSuit, MeteoriteBar, 16);
        RecipeAdder.Melt(MeteorLeggings, MeteoriteBar, 12);
        RecipeAdder.Melt(ShadowHelmet, DemoniteBar, 12);
        RecipeAdder.Melt(ShadowScalemail, DemoniteBar, 20);
        RecipeAdder.Melt(ShadowGreaves, DemoniteBar, 16);
        RecipeAdder.Melt(CrimsonHelmet, CrimtaneBar, 12);
        RecipeAdder.Melt(CrimsonScalemail, CrimtaneBar, 20);
        RecipeAdder.Melt(CrimsonGreaves, CrimtaneBar, 16);
        RecipeAdder.Melt(MoltenHelmet, HellstoneBar, 8);
        RecipeAdder.Melt(MoltenBreastplate, HellstoneBar, 16);
        RecipeAdder.Melt(MoltenGreaves, HellstoneBar, 12);
        RecipeAdder.Melt(CobaltHelmet, CobaltBar, 8);
        RecipeAdder.Melt(CobaltMask, CobaltBar, 8);
        RecipeAdder.Melt(CobaltHat, CobaltBar, 8);
        RecipeAdder.Melt(CobaltBreastplate, CobaltBar, 16);
        RecipeAdder.Melt(CobaltLeggings, CobaltBar, 12);
        RecipeAdder.Melt(PalladiumHelmet, PalladiumBar, 9);
        RecipeAdder.Melt(PalladiumMask, PalladiumBar, 9);
        RecipeAdder.Melt(PalladiumHeadgear, PalladiumBar, 9);
        RecipeAdder.Melt(PalladiumBreastplate, PalladiumBar, 19);
        RecipeAdder.Melt(PalladiumLeggings, PalladiumBar, 14);
        RecipeAdder.Melt(MythrilHelmet, MythrilBar, 8);
        RecipeAdder.Melt(MythrilHood, MythrilBar, 8);
        RecipeAdder.Melt(MythrilHat, MythrilBar, 8);
        RecipeAdder.Melt(MythrilChainmail, MythrilBar, 16);
        RecipeAdder.Melt(MythrilGreaves, MythrilBar, 12);
        RecipeAdder.Melt(OrichalcumHelmet, OrichalcumBar, 9);
        RecipeAdder.Melt(OrichalcumMask, OrichalcumBar, 9);
        RecipeAdder.Melt(OrichalcumHeadgear, OrichalcumBar, 9);
        RecipeAdder.Melt(OrichalcumBreastplate, OrichalcumBar, 19);
        RecipeAdder.Melt(OrichalcumLeggings, OrichalcumBar, 14);
        RecipeAdder.Melt(AdamantiteHelmet, AdamantiteBar, 9);
        RecipeAdder.Melt(AdamantiteHeadgear, AdamantiteBar, 9);
        RecipeAdder.Melt(AdamantiteMask, AdamantiteBar, 9);
        RecipeAdder.Melt(AdamantiteBreastplate, AdamantiteBar, 19);
        RecipeAdder.Melt(AdamantiteLeggings, AdamantiteBar, 14);
        RecipeAdder.Melt(TitaniumHelmet, TitaniumBar, 10);
        RecipeAdder.Melt(TitaniumHeadgear, TitaniumBar, 10);
        RecipeAdder.Melt(TitaniumMask, TitaniumBar, 10);
        RecipeAdder.Melt(TitaniumBreastplate, TitaniumBar, 20);
        RecipeAdder.Melt(TitaniumLeggings, TitaniumBar, 16);
        RecipeAdder.Melt(HallowedHelmet, HallowedBar, 9);
        RecipeAdder.Melt(HallowedHeadgear, HallowedBar, 9);
        RecipeAdder.Melt(HallowedMask, HallowedBar, 9);
        RecipeAdder.Melt(HallowedPlateMail, HallowedBar, 19);
        RecipeAdder.Melt(HallowedGreaves, HallowedBar, 14);
        RecipeAdder.Melt(AncientHallowedHelmet, HallowedBar, 9);
        RecipeAdder.Melt(AncientHallowedHeadgear, HallowedBar, 9);
        RecipeAdder.Melt(AncientHallowedMask, HallowedBar, 9);
        RecipeAdder.Melt(AncientHallowedPlateMail, HallowedBar, 19);
        RecipeAdder.Melt(AncientHallowedGreaves, HallowedBar, 14);
        RecipeAdder.Melt(ChlorophyteHelmet, ChlorophyteBar, 9);
        RecipeAdder.Melt(ChlorophyteHeadgear, ChlorophyteBar, 9);
        RecipeAdder.Melt(ChlorophyteMask, ChlorophyteBar, 9);
        RecipeAdder.Melt(ChlorophytePlateMail, ChlorophyteBar, 19);
        RecipeAdder.Melt(ChlorophyteGreaves, ChlorophyteBar, 14);
        RecipeAdder.Melt(ShroomiteHeadgear, ShroomiteBar, 9);
        RecipeAdder.Melt(ShroomiteHelmet, ShroomiteBar, 9);
        RecipeAdder.Melt(ShroomiteMask, ShroomiteBar, 9);
        RecipeAdder.Melt(ShroomiteBreastplate, ShroomiteBar, 19);
        RecipeAdder.Melt(ShroomiteLeggings, ShroomiteBar, 14);
        RecipeAdder.Melt(SpectreHood, SpectreBar, 9);
        RecipeAdder.Melt(SpectreMask, SpectreBar, 9);
        RecipeAdder.Melt(SpectreRobe, SpectreBar, 19);
        RecipeAdder.Melt(SpectrePants, SpectreBar, 14);
        RecipeAdder.Melt(TurtleHelmet, ChlorophyteBar, 9);
        RecipeAdder.Melt(TurtleScaleMail, ChlorophyteBar, 19);
        RecipeAdder.Melt(TurtleLeggings, ChlorophyteBar, 14);
        RecipeAdder.Melt(NebulaHelmet, LunarBar, 6);
        RecipeAdder.Melt(NebulaBreastplate, LunarBar, 12);
        RecipeAdder.Melt(NebulaLeggings, LunarBar, 9);
        RecipeAdder.Melt(SolarFlareHelmet, LunarBar, 6);
        RecipeAdder.Melt(SolarFlareBreastplate, LunarBar, 12);
        RecipeAdder.Melt(SolarFlareLeggings, LunarBar, 9);
        RecipeAdder.Melt(VortexHelmet, LunarBar, 6);
        RecipeAdder.Melt(VortexBreastplate, LunarBar, 12);
        RecipeAdder.Melt(VortexLeggings, LunarBar, 9);
        RecipeAdder.Melt(StardustHelmet, LunarBar, 6);
        RecipeAdder.Melt(StardustBreastplate, LunarBar, 12);
        RecipeAdder.Melt(StardustLeggings, LunarBar, 9);
        RecipeAdder.Melt(FlinxFurCoat, GoldBar, 6);
        RecipeAdder.Melt(FlinxFurCoat, PlatinumBar, 6);
        RecipeAdder.Melt(AncientBattleArmorHat, AdamantiteBar, 8);
        RecipeAdder.Melt(AncientBattleArmorShirt, AdamantiteBar, 16);
        RecipeAdder.Melt(AncientBattleArmorPants, AdamantiteBar, 12);
        RecipeAdder.Melt(AncientBattleArmorHat, TitaniumBar, 8);
        RecipeAdder.Melt(AncientBattleArmorShirt, TitaniumBar, 16);
        RecipeAdder.Melt(AncientBattleArmorPants, TitaniumBar, 12);
        RecipeAdder.Melt(FrostHelmet, AdamantiteBar, 8);
        RecipeAdder.Melt(FrostBreastplate, AdamantiteBar, 16);
        RecipeAdder.Melt(FrostLeggings, AdamantiteBar, 12);
        RecipeAdder.Melt(FrostHelmet, TitaniumBar, 8);
        RecipeAdder.Melt(FrostBreastplate, TitaniumBar, 16);
        RecipeAdder.Melt(FrostLeggings, TitaniumBar, 12);

        // Tools
        RecipeAdder.Melt(CopperAxe, CopperBar, 4);
        RecipeAdder.Melt(CopperHammer, CopperBar, 6);
        RecipeAdder.Melt(CopperPickaxe, CopperBar, 6);
        RecipeAdder.Melt(TinAxe, TinBar, 4);
        RecipeAdder.Melt(TinHammer, TinBar, 6);
        RecipeAdder.Melt(TinPickaxe, TinBar, 6);
        RecipeAdder.Melt(IronAxe, IronBar, 6);
        RecipeAdder.Melt(IronHammer, IronBar, 6);
        RecipeAdder.Melt(IronPickaxe, IronBar, 8);
        RecipeAdder.Melt(ReinforcedFishingPole, IronBar, 6);
        RecipeAdder.Melt(LeadAxe, LeadBar, 6);
        RecipeAdder.Melt(LeadHammer, LeadBar, 6);
        RecipeAdder.Melt(LeadPickaxe, LeadBar, 8);
        RecipeAdder.Melt(SilverAxe, SilverBar, 6);
        RecipeAdder.Melt(SilverHammer, SilverBar, 6);
        RecipeAdder.Melt(SilverPickaxe, SilverBar, 8);
        RecipeAdder.Melt(TungstenAxe, TungstenBar, 6);
        RecipeAdder.Melt(TungstenHammer, TungstenBar, 6);
        RecipeAdder.Melt(TungstenPickaxe, TungstenBar, 8);
        RecipeAdder.Melt(GoldAxe, GoldBar, 6);
        RecipeAdder.Melt(GoldHammer, GoldBar, 6);
        RecipeAdder.Melt(GoldPickaxe, GoldBar, 8);
        RecipeAdder.Melt(PlatinumAxe, PlatinumBar, 6);
        RecipeAdder.Melt(PlatinumHammer, PlatinumBar, 6);
        RecipeAdder.Melt(PlatinumPickaxe, PlatinumBar, 8);
        RecipeAdder.Melt(MeteorHamaxe, MeteoriteBar, 16);
        RecipeAdder.Melt(WarAxeoftheNight, DemoniteBar, 8);
        RecipeAdder.Melt(TheBreaker, DemoniteBar, 8);
        RecipeAdder.Melt(NightmarePickaxe, DemoniteBar, 9);
        RecipeAdder.Melt(FisherofSouls, DemoniteBar, 6);
        RecipeAdder.Melt(BloodLustCluster, CrimtaneBar, 8);
        RecipeAdder.Melt(FleshGrinder, CrimtaneBar, 8);
        RecipeAdder.Melt(DeathbringerPickaxe, CrimtaneBar, 9);
        RecipeAdder.Melt(Fleshcatcher, CrimtaneBar, 6);
        RecipeAdder.Melt(MoltenHamaxe, HellstoneBar, 12);
        RecipeAdder.Melt(MoltenPickaxe, HellstoneBar, 16);
        RecipeAdder.Melt(CobaltWaraxe, CobaltBar, 8);
        RecipeAdder.Melt(CobaltChainsaw, CobaltBar, 8);
        RecipeAdder.Melt(CobaltDrill, CobaltBar, 12);
        RecipeAdder.Melt(CobaltPickaxe, CobaltBar, 12);
        RecipeAdder.Melt(PalladiumWaraxe, PalladiumBar, 9);
        RecipeAdder.Melt(PalladiumChainsaw, PalladiumBar, 9);
        RecipeAdder.Melt(PalladiumDrill, PalladiumBar, 14);
        RecipeAdder.Melt(PalladiumPickaxe, PalladiumBar, 14);
        RecipeAdder.Melt(MythrilWaraxe, MythrilBar, 8);
        RecipeAdder.Melt(MythrilChainsaw, MythrilBar, 8);
        RecipeAdder.Melt(MythrilDrill, MythrilBar, 12);
        RecipeAdder.Melt(MythrilPickaxe, MythrilBar, 12);
        RecipeAdder.Melt(OrichalcumWaraxe, OrichalcumBar, 9);
        RecipeAdder.Melt(OrichalcumChainsaw, OrichalcumBar, 9);
        RecipeAdder.Melt(OrichalcumDrill, OrichalcumBar, 14);
        RecipeAdder.Melt(OrichalcumPickaxe, OrichalcumBar, 14);
        RecipeAdder.Melt(AdamantiteWaraxe, AdamantiteBar, 9);
        RecipeAdder.Melt(AdamantiteChainsaw, AdamantiteBar, 9);
        RecipeAdder.Melt(AdamantiteDrill, AdamantiteBar, 14);
        RecipeAdder.Melt(AdamantitePickaxe, AdamantiteBar, 14);
        RecipeAdder.Melt(TitaniumWaraxe, TitaniumBar, 10);
        RecipeAdder.Melt(TitaniumChainsaw, TitaniumBar, 10);
        RecipeAdder.Melt(TitaniumDrill, TitaniumBar, 16);
        RecipeAdder.Melt(TitaniumPickaxe, TitaniumBar, 16);
        RecipeAdder.Melt(PickaxeAxe, HallowedBar, 14);
        RecipeAdder.Melt(Drax, HallowedBar, 14);
        RecipeAdder.Melt(ChlorophyteGreataxe, ChlorophyteBar, 14);
        RecipeAdder.Melt(ChlorophyteChainsaw, ChlorophyteBar, 14);
        RecipeAdder.Melt(ChlorophyteDrill, ChlorophyteBar, 14);
        RecipeAdder.Melt(ChlorophytePickaxe, ChlorophyteBar, 14);
        RecipeAdder.Melt(ChlorophyteJackhammer, ChlorophyteBar, 14);
        RecipeAdder.Melt(ChlorophyteWarhammer, ChlorophyteBar, 14);
        RecipeAdder.Melt(ShroomiteDiggingClaw, ShroomiteBar, 14);
        RecipeAdder.Melt(SpectreHamaxe, SpectreBar, 14);
        RecipeAdder.Melt(SpectrePickaxe, SpectreBar, 14);
        RecipeAdder.Melt(LunarHamaxeNebula, LunarBar, 9);
        RecipeAdder.Melt(LunarHamaxeSolar, LunarBar, 9);
        RecipeAdder.Melt(LunarHamaxeStardust, LunarBar, 9);
        RecipeAdder.Melt(LunarHamaxeVortex, LunarBar, 9);
        RecipeAdder.Melt(NebulaPickaxe, LunarBar, 8);
        RecipeAdder.Melt(SolarFlarePickaxe, LunarBar, 8);
        RecipeAdder.Melt(StardustPickaxe, LunarBar, 8);
        RecipeAdder.Melt(VortexPickaxe, LunarBar, 8);
        RecipeAdder.Melt(NebulaDrill, LunarBar, 8);
        RecipeAdder.Melt(SolarFlareDrill, LunarBar, 8);
        RecipeAdder.Melt(StardustDrill, LunarBar, 8);
        RecipeAdder.Melt(VortexDrill, LunarBar, 8);

        // Weapons
        RecipeAdder.Melt(AmethystStaff, CopperBar, 8);
        RecipeAdder.Melt(CopperBow, CopperBar, 5);
        RecipeAdder.Melt(CopperShortsword, CopperBar, 4);
        RecipeAdder.Melt(CopperBroadsword, CopperBar, 4);
        RecipeAdder.Melt(TopazStaff, TinBar, 8);
        RecipeAdder.Melt(TinBow, TinBar, 5);
        RecipeAdder.Melt(TinShortsword, TinBar, 4);
        RecipeAdder.Melt(TinBroadsword, TinBar, 4);
        RecipeAdder.Melt(IronShortsword, IronBar, 4);
        RecipeAdder.Melt(IronBow, IronBar, 5);
        RecipeAdder.Melt(IronBroadsword, IronBar, 6);
        RecipeAdder.Melt(GravediggerShovel, IronBar, 9);
        RecipeAdder.Melt(Flamethrower, IronBar, 16);
        RecipeAdder.Melt(LeadShortsword, LeadBar, 4);
        RecipeAdder.Melt(LeadBow, LeadBar, 5);
        RecipeAdder.Melt(LeadBroadsword, LeadBar, 6);
        RecipeAdder.Melt(GravediggerShovel, LeadBar, 9);
        RecipeAdder.Melt(Flamethrower, LeadBar, 16);
        RecipeAdder.Melt(SilverShortsword, SilverBar, 4);
        RecipeAdder.Melt(SilverBow, SilverBar, 5);
        RecipeAdder.Melt(SilverBroadsword, SilverBar, 6);
        RecipeAdder.Melt(SapphireStaff, SilverBar, 8);
        RecipeAdder.Melt(TungstenShortsword, TungstenBar, 4);
        RecipeAdder.Melt(TungstenBow, TungstenBar, 5);
        RecipeAdder.Melt(TungstenBroadsword, TungstenBar, 6);
        RecipeAdder.Melt(EmeraldStaff, TungstenBar, 8);
        RecipeAdder.Melt(FlinxStaff, GoldBar, 8);
        RecipeAdder.Melt(GoldBow, GoldBar, 4);
        RecipeAdder.Melt(GoldShortsword, GoldBar, 5);
        RecipeAdder.Melt(GoldBroadsword, GoldBar, 6);
        RecipeAdder.Melt(RubyStaff, GoldBar, 8);
        RecipeAdder.Melt(FlinxStaff, PlatinumBar, 8);
        RecipeAdder.Melt(PlatinumBow, PlatinumBar, 4);
        RecipeAdder.Melt(PlatinumShortsword, PlatinumBar, 5);
        RecipeAdder.Melt(PlatinumBroadsword, PlatinumBar, 6);
        RecipeAdder.Melt(DiamondStaff, PlatinumBar, 8);
        RecipeAdder.Melt(SpaceGun, MeteoriteBar, 16);
        RecipeAdder.Melt(RedPhaseblade, MeteoriteBar, 12);
        RecipeAdder.Melt(BluePhaseblade, MeteoriteBar, 12);
        RecipeAdder.Melt(GreenPhaseblade, MeteoriteBar, 12);
        RecipeAdder.Melt(PurplePhaseblade, MeteoriteBar, 12);
        RecipeAdder.Melt(WhitePhaseblade, MeteoriteBar, 12);
        RecipeAdder.Melt(YellowPhaseblade, MeteoriteBar, 12);
        RecipeAdder.Melt(OrangePhaseblade, MeteoriteBar, 12);
        RecipeAdder.Melt(MeteorStaff, MeteoriteBar, 16);
        RecipeAdder.Melt(StarCannon, MeteoriteBar, 16);
        RecipeAdder.Melt(DemonBow, DemoniteBar, 6);
        RecipeAdder.Melt(LightsBane, DemoniteBar, 9);
        RecipeAdder.Melt(CorruptYoyo, DemoniteBar, 8);
        RecipeAdder.Melt(TheMeatball, CrimtaneBar, 8);
        RecipeAdder.Melt(CrimsonYoyo, CrimtaneBar, 9);
        RecipeAdder.Melt(TendonBow, CrimtaneBar, 6);
        RecipeAdder.Melt(BloodButcherer, CrimtaneBar, 8);
        RecipeAdder.Melt(ImpStaff, HellstoneBar, 13);
        RecipeAdder.Melt(PhoenixBlaster, HellstoneBar, 8);
        RecipeAdder.Melt(MoltenFury, HellstoneBar, 12);
        RecipeAdder.Melt(Flamarang, HellstoneBar, 8);
        RecipeAdder.Melt(FieryGreatsword, HellstoneBar, 16);
        RecipeAdder.Melt(CobaltNaginata, CobaltBar, 8);
        RecipeAdder.Melt(CobaltRepeater, CobaltBar, 8);
        RecipeAdder.Melt(CobaltSword, CobaltBar, 6);
        RecipeAdder.Melt(PalladiumPike, PalladiumBar, 9);
        RecipeAdder.Melt(PalladiumRepeater, PalladiumBar, 9);
        RecipeAdder.Melt(PalladiumSword, PalladiumBar, 8);
        RecipeAdder.Melt(MythrilHalberd, MythrilBar, 8);
        RecipeAdder.Melt(MythrilRepeater, MythrilBar, 8);
        RecipeAdder.Melt(MythrilSword, MythrilBar, 6);
        RecipeAdder.Melt(OrichalcumHalberd, OrichalcumBar, 9);
        RecipeAdder.Melt(OrichalcumRepeater, OrichalcumBar, 9);
        RecipeAdder.Melt(OrichalcumSword, OrichalcumBar, 8);
        RecipeAdder.Melt(AdamantiteGlaive, AdamantiteBar, 9);
        RecipeAdder.Melt(AdamantiteRepeater, AdamantiteBar, 9);
        RecipeAdder.Melt(AdamantiteSword, AdamantiteBar, 9);
        RecipeAdder.Melt(TitaniumTrident, TitaniumBar, 10);
        RecipeAdder.Melt(TitaniumRepeater, TitaniumBar, 10);
        RecipeAdder.Melt(TitaniumSword, TitaniumBar, 10);
        RecipeAdder.Melt(OpticStaff, HallowedBar, 9);
        RecipeAdder.Melt(Gungnir, HallowedBar, 9);
        RecipeAdder.Melt(HallowedRepeater, HallowedBar, 9);
        RecipeAdder.Melt(SwordWhip, HallowedBar, 9);
        RecipeAdder.Melt(LightDisc, HallowedBar, 3);
        RecipeAdder.Melt(StarCannon, HallowedBar, 9);
        RecipeAdder.Melt(Excalibur, HallowedBar, 9);
        RecipeAdder.Melt(JoustingLance, HallowedBar, 9);
        RecipeAdder.Melt(ChlorophyteShotbow, ChlorophyteBar, 9);
        RecipeAdder.Melt(ChlorophytePartisan, ChlorophyteBar, 9);
        RecipeAdder.Melt(ChlorophyteClaymore, ChlorophyteBar, 9);
        RecipeAdder.Melt(ChlorophyteSaber, ChlorophyteBar, 9);
        RecipeAdder.Melt(VenomStaff, ChlorophyteBar, 11);
        RecipeAdder.Melt(TrueExcalibur, ChlorophyteBar, 19);

        // Bars to ores (100% return)
        RecipeAdder.Melt(CopperBar, CopperOre, 3);
        RecipeAdder.Melt(TinBar, TinOre, 3);
        RecipeAdder.Melt(IronBar, IronOre, 3);
        RecipeAdder.Melt(LeadBar, LeadOre, 3);
        RecipeAdder.Melt(SilverBar, SilverOre, 4);
        RecipeAdder.Melt(TungstenBar, TungstenOre, 4);
        RecipeAdder.Melt(GoldBar, GoldOre, 4);
        RecipeAdder.Melt(PlatinumBar, PlatinumOre, 4);
        RecipeAdder.Melt(MeteoriteBar, Meteorite, 3);
        RecipeAdder.Melt(DemoniteBar, DemoniteOre, 3);
        RecipeAdder.Melt(CrimtaneBar, CrimtaneOre, 3);
        RecipeAdder.Melt(HellstoneBar, Hellstone, 3);
        RecipeAdder.Melt(CobaltBar, CobaltOre, 3);
        RecipeAdder.Melt(PalladiumBar, PalladiumOre, 3);
        RecipeAdder.Melt(MythrilBar, MythrilOre, 4);
        RecipeAdder.Melt(OrichalcumBar, OrichalcumOre, 4);
        RecipeAdder.Melt(AdamantiteBar, AdamantiteOre, 4);
        RecipeAdder.Melt(TitaniumBar, TitaniumOre, 4);
        RecipeAdder.Melt(ChlorophyteBar, ChlorophyteOre, 5);
        RecipeAdder.Melt(LunarOre, LunarBar, 4);
    }
}
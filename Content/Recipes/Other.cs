using static Terraria.ID.ItemID;
using Terraria.ID;
using Terraria.ModLoader;

public class Other : ModSystem
{
    public override void AddRecipes()
    {
        // Additional Recipes that don't fall under a specific category or are too small to warrant their own file

        // Chests with missing recipe
        RecipeAdder.Generic(GoldChest, 1, new [] {(Wood, 8)}, new [] {("GP", 2)}, TileID.Anvils);
        RecipeAdder.Generic(ShadowChest, 1, new [] {(Wood, 8)}, new [] {("CD", 2)}, TileID.Anvils);
        RecipeAdder.Generic(IvyChest, 1, new [] {(Wood, 8), (Vine, 2)}, new [] {("IL", 2)}, TileID.WorkBenches); 
        RecipeAdder.Generic(WebCoveredChest, 1, new [] {(ItemID.Chest, 1), (Cobweb, 8)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(WaterChest, 1, new [] {(ItemID.Chest, 1), (Coral, 8)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(GoldenChest, 1, new [] {(ItemID.Chest, 1), (GoldBar, 8)}, null, TileID.Anvils);

        // Biome Chests
        RecipeAdder.Generic(JungleChest, 1, new [] {(Wood, 8), (ChlorophyteBar, 2)}, null, TileID.MythrilAnvil);
        RecipeAdder.Generic(CorruptionChest, 1, new [] {(Wood, 8), (DemoniteBar, 2)}, null, TileID.Anvils);
        RecipeAdder.Generic(CrimsonChest, 1, new [] {(Wood, 8), (CrimtaneBar, 2)}, null, TileID.Anvils);
        RecipeAdder.Generic(HallowedChest, 1, new [] {(Wood, 8), (HallowedBar, 2)}, null, TileID.MythrilAnvil);
        RecipeAdder.Generic(IceChest, 1, new [] {(ItemID.Chest, 1), (IceBlock, 8)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(DesertChest, 1, new [] {(ItemID.Chest, 1), (SandBlock, 8)}, null, TileID.WorkBenches);

        // Craftable Biome keys
        RecipeAdder.Generic(JungleKey, 1, new [] {(TempleKey, 1), (ChlorophyteBar, 100)}, null, TileID.MythrilAnvil);
        RecipeAdder.Generic(CorruptionKey, 1, new [] {(TempleKey, 1), (DemoniteBar, 100)}, null, TileID.MythrilAnvil);
        RecipeAdder.Generic(CrimsonKey, 1, new [] {(TempleKey, 1), (CrimtaneBar, 100)}, null, TileID.MythrilAnvil);
        RecipeAdder.Generic(HallowedKey, 1, new [] {(TempleKey, 1), (HallowedBar, 100)}, null, TileID.MythrilAnvil);
        RecipeAdder.Generic(FrozenKey, 1, new [] {(TempleKey, 1), (IceBlock, 100)}, new [] {("IL", 100)}, TileID.MythrilAnvil);
        RecipeAdder.Generic(DungeonDesertKey, 1, new [] {(TempleKey, 1), (SandBlock, 100)}, new [] {("IL", 100)}, TileID.MythrilAnvil);

        // Craftable Traps
        RecipeAdder.Generic(DartTrap, 1, new [] {(StoneBlock, 10), (Wire, 2), (WoodenArrow, 10)}, null, TileID.Anvils);
        RecipeAdder.Generic(GeyserTrap, 1, new [] {(StoneBlock, 10), (Wire, 2), (Gel, 50)}, new [] {("IL", 2)}, TileID.Anvils);
        RecipeAdder.Generic(SuperDartTrap, 1, new [] {(LihzahrdBrick, 10), (Wire, 2), (PoisonDart, 10)}, null, TileID.Anvils);
        RecipeAdder.Generic(SpikyBallTrap, 1, new [] {(LihzahrdBrick, 10), (Wire, 2), (SpikyBall, 10)}, null, TileID.Anvils);
        RecipeAdder.Generic(SpearTrap, 1, new [] {(LihzahrdBrick, 10), (Wire, 2), (Chain, 10), (Spear, 1)}, null, TileID.Anvils);
        RecipeAdder.Generic(FlameTrap, 1, new [] {(LihzahrdBrick, 10), (Wire, 2), (Gel, 100)}, new [] {("IL", 2)}, TileID.Anvils);
        RecipeAdder.Generic(WoodenSpike, 4, new [] {(Wood, 1)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(Spike, 8, null, new [] {("IL", 1)}, TileID.Anvils); 

        // Craftable Chest loot
        RecipeAdder.Generic(Spear, 1, null, new [] {("CT", 8)}, TileID.Anvils);
        RecipeAdder.Generic(Mace, 1, new [] {(Wood, 2)}, new [] {("IL", 8)}, TileID.Anvils);
        RecipeAdder.Generic(Blowpipe, 1, new [] {(Wood, 4)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(ShoeSpikes, 1, new [] {(Chain, 2)}, new [] {("IL", 3)}, TileID.Anvils);
        RecipeAdder.Generic(ClimbingClaws, 1, new [] {(Chain, 2)}, new [] {("IL", 3)}, TileID.Anvils);
        RecipeAdder.Generic(FlareGun, 1, new [] {(Wood, 5), (IllegalGunParts, 1)}, null, TileID.Anvils);
        RecipeAdder.Generic(Flare, 10, new [] {(Torch, 1)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(BandofRegeneration, 1, new [] {(LifeCrystal, 1), (Silk, 5)}, null, TileID.Anvils);
        RecipeAdder.Generic(CloudinaBottle, 1, new [] {(ItemID.Cloud, 20), (Bottle, 1)}, null, TileID.Anvils);
        RecipeAdder.Generic(Aglet, 1, null, new [] {("GP", 2), ("IL", 1)}, TileID.Anvils);
        RecipeAdder.Generic(HermesBoots, 1, new [] {(Aglet, 1), (Feather, 2), (Silk, 5)}, null, TileID.Anvils);
        RecipeAdder.Generic(WoodenBoomerang, 1, new [] {(Wood, 20)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(EnchantedBoomerang, 1, new [] {(WoodenBoomerang, 1), (ItemID.FallenStar, 5)}, null, TileID.Anvils);
        RecipeAdder.Generic(WandofSparking, 1, new [] {(Wood, 8), (Gel, 3)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(MagicMirror, 1, new [] {(RecallPotion, 1)}, new [] {("ST", 10)}, TileID.Anvils);
        RecipeAdder.Generic(LavaCharm, 1, new [] {(ObsidianSkinPotion, 5), (Silk, 8)}, null, TileID.Anvils);
        RecipeAdder.Generic(FlyingCarpet, 1, new [] {(Silk, 20)}, new [] {("GP", 8)}, TileID.Anvils);
        RecipeAdder.Generic(SandstorminaBottle, 1, new [] {(SandBlock, 50), (Bottle, 1)}, null, TileID.Anvils);
        RecipeAdder.Generic(IceMirror, 1, new [] {(RecallPotion, 1), (IceBlock, 10)}, new [] {("ST", 10)}, TileID.Anvils);
        RecipeAdder.Generic(IceBoomerang, 1, new [] {(WoodenBoomerang, 1), (IceBlock, 10)}, null, TileID.Anvils);
        RecipeAdder.Generic(IceBlade, 1, new [] {(IceBlock, 20)}, new [] {("IL", 10)}, TileID.Anvils);
        RecipeAdder.Generic(SnowballCannon, 1, new [] {(IceBlock, 30), (IllegalGunParts, 1)}, new [] {("IL", 10)}, TileID.Anvils);
        RecipeAdder.Generic(BlizzardinaBottle, 1, new [] {(IceBlock, 25), (SnowBlock, 25), (CloudinaBottle, 1)}, null, TileID.Anvils);
        RecipeAdder.Generic(FlurryBoots, 1, new [] {(Aglet, 1), (Feather, 2), (Silk, 5), (IceBlock, 10)}, null, TileID.Anvils);
        RecipeAdder.Generic(IceMachine, 1, new [] {(IceBlock, 10), (SnowBlock, 10)}, new [] {("IL", 10)}, TileID.Anvils);
        RecipeAdder.Generic(LeafWand, 1, new [] {(Wood, 8)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(LivingWoodWand, 1, new [] {(Wood, 8)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(LivingMahoganyLeafWand, 1, new [] {(Wood, 8)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(LivingMahoganyWand, 1, new [] {(Wood, 8)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(HoneyDispenser, 1, new [] {(HoneyBlock, 10)}, new [] {("IL", 5)}, TileID.Anvils);
        RecipeAdder.Generic(FlowerBoots, 1, new [] {(Vine, 5), (Silk, 5), (Daybloom, 3)}, null, TileID.Anvils);
        RecipeAdder.Generic(LivingLoom, 1, new [] {(Wood, 12), (Chain, 4)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(Trident, 1, null, new [] {("GP", 8), ("IL", 3)}, TileID.Anvils);
        RecipeAdder.Generic(BreathingReed, 1, new [] {(Wood, 10)}, null, TileID.WorkBenches);
        RecipeAdder.Generic(Flipper, 1, new [] {(FlipperPotion, 5), (Silk, 5)}, null, TileID.Anvils);
        RecipeAdder.Generic(WaterWalkingBoots, 1, new [] {(WaterWalkingPotion, 5), (Silk, 5)}, null, TileID.Anvils);
        RecipeAdder.Generic(WebSlinger, 1, new [] {(Cobweb, 20)}, new [] {("IL", 5)}, TileID.Anvils);
        RecipeAdder.Generic(EncumberingStone, 1, new [] {(StoneBlock, 3996)}, null, TileID.Anvils);
        RecipeAdder.Generic(LihzahrdFurnace, 1, new [] {(LihzahrdBrick, 20), (HellstoneBar, 10), (Obsidian, 10), (Torch, 10)}, null, TileID.Anvils);
        RecipeAdder.Generic(SkyMill, 1, new [] {(SunplateBlock, 10), (ItemID.Cloud, 10)}, new [] {("IL", 5)}, TileID.Anvils);
        RecipeAdder.Generic(CelestialMagnet, 1, new [] {(SunplateBlock, 10), (FallenStar, 5)}, new [] {("IL", 5)}, TileID.Anvils);

        // Other
        RecipeAdder.Generic(Extractinator, 1, new [] {(Chain, 20)}, new [] {("IL", 10)}, TileID.Anvils);
        RecipeAdder.Generic(Hellforge, 1, new [] {(Furnace, 1), (HellstoneBar, 20)}, null, TileID.Anvils);
        RecipeAdder.Generic(AlchemyTable, 1, new [] {(BottledWater, 10), (Book, 1), (GoldenKey, 1)}, null, TileID.Anvils);
        RecipeAdder.Generic(ShadowKey, 1, new [] {(GoldenKey, 1), (ShadowScale, 10)}, null, TileID.Anvils);
    }
}

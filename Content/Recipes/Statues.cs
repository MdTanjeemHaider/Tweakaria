using Terraria;
using static Terraria.ID.ItemID;
using Terraria.ID;
using Terraria.ModLoader;

public class Statues : ModSystem
{
    // Recipes
    public override void AddRecipes()
    {
        // Goblin
        RecipeAdder.Statue(GoblinStatue, "GoblinBanner", 1);

        // Wall creeper
        RecipeAdder.Statue(WallCreeperStatue, "SpiderBanner", 1);

        // Hammer
        RecipeAdder.Statue(HammerStatue, "WoodenHammer", 1);

        // Bow
        RecipeAdder.Statue(BowStatue, "WoodenBow", 1);

        // Axe
        RecipeAdder.Statue(AxeStatue, "CTAxe", 1);

        // Anvil
        RecipeAdder.Statue(AnvilStatue, "Anvil", 1);

        // Pickaxe
        RecipeAdder.Statue(PickaxeStatue, "CTPickaxe", 1);

        // Gargoyle
        RecipeAdder.Statue(GargoyleStatue, 0, 0);
        
        // Gloom
        RecipeAdder.Statue(GloomStatue, 0, 0);

        // Pillar
        RecipeAdder.Statue(PillarStatue, 0, 0);

        // Cross
        RecipeAdder.Statue(CrossStatue, 0, 0);

        // Heart
        RecipeAdder.Statue(HeartStatue, LifeCrystal, 5);

        // Star/Mana
        RecipeAdder.Statue(StarStatue, ManaCrystal, 5);

        // Boomarang
        RecipeAdder.Statue(BoomerangStatue, WoodenBoomerang, 1);

        // Slime
        RecipeAdder.Statue(SlimeStatue, SlimeBanner, 1);

        // Skeleton
        RecipeAdder.Statue(SkeletonStatue, SkeletonBanner, 1);

        // Reaper
        RecipeAdder.Statue(ReaperStatue, ReaperBanner, 1);

        // Imp
        RecipeAdder.Statue(ImpStatue, FireImpBanner, 1);

        // Hornet
        RecipeAdder.Statue(HornetStatue, HornetBanner, 1);

        // Crab
        RecipeAdder.Statue(CrabStatue, CrabBanner, 1);

        // Jellyfish
        RecipeAdder.Statue(JellyfishStatue, JellyfishBanner, 1);

        // Corrupt
        RecipeAdder.Statue(CorruptStatue, CorruptorBanner, 1);

        // Chest
        RecipeAdder.Statue(ChestStatue, ItemID.Chest, 1);

        // Eyeball
        RecipeAdder.Statue(EyeballStatue, DemonEyeBanner, 1);

        // Piranha
        RecipeAdder.Statue(PiranhaStatue, PiranhaBanner, 1);

        // Shark
        RecipeAdder.Statue(SharkStatue, SharkBanner, 1);

        // Unicorn
        RecipeAdder.Statue(UnicornStatue, UnicornBanner, 1);

        // Drippler
        RecipeAdder.Statue(DripplerStatue, DripplerBanner, 1);

        // Wraith
        RecipeAdder.Statue(WraithStatue, WraithBanner, 1);

        // Undead viking
        RecipeAdder.Statue(UndeadVikingStatue, UndeadVikingBanner, 1);

        // Medusa
        RecipeAdder.Statue(MedusaStatue, MedusaBanner, 1);

        // Harpy
        RecipeAdder.Statue(HarpyStatue, HarpyBanner, 1);

        // Pigron
        RecipeAdder.Statue(PigronStatue, PigronBanner, 1);

        // Hoplite
        RecipeAdder.Statue(HopliteStatue, GreekSkeletonBanner, 1);

        // Granite golem
        RecipeAdder.Statue(GraniteGolemStatue, GraniteGolemBanner, 1);

        // Blood zombie
        RecipeAdder.Statue(BloodZombieStatue, BloodZombieBanner, 1);

        // Mushroom
        RecipeAdder.Statue(MushroomStatue, Mushroom, 5);

        // Bomb
        RecipeAdder.Statue(BombStatue, Bomb, 5);
        
        // Potion
        RecipeAdder.Statue(PotionStatue, HealingPotion, 5);
        
        // Spear
        RecipeAdder.Statue(SpearStatue, Spear, 1);
        
        // Boot
        RecipeAdder.Statue(BootStatue, HermesBoots, 1);

        // Tree
        RecipeAdder.Statue(TreeStatue, Acorn, 5);

        // Pot
        RecipeAdder.Statue(PotStatue, ClayPot, 5);
        
        // Sunflower 
        RecipeAdder.Statue(SunflowerStatue, Sunflower, 5);

        // Bone skeleton
        RecipeAdder.Statue(BoneSkeletonStatue, Bone, 50);

        // Armed zombie
        RecipeAdder.Statue(ZombieArmStatue, ZombieArm, 1);

        // Queen
        Recipe.Create(QueenStatue)
            .AddIngredient(Womannquin)
            .AddIngredient(Silk, 10)
            .AddRecipeGroup("Soul",5)
            .AddRecipeGroup("Crown", 1)
            .AddIngredient(StoneBlock, 50)
            .AddTile(TileID.HeavyWorkBench)
            .Register();

        // King
        Recipe.Create(KingStatue)
            .AddIngredient(Mannequin, 1)
            .AddIngredient(Silk, 10)
            .AddRecipeGroup("Soul",5)
            .AddRecipeGroup("Crown", 1)
            .AddIngredient(StoneBlock, 50)
            .AddTile(TileID.HeavyWorkBench)
            .Register();

        // Woman
        Recipe.Create(WomanStatue)
            .AddIngredient(Womannquin, 1)
            .AddIngredient(Silk, 10)
            .AddIngredient(StoneBlock, 50)
            .AddTile(TileID.HeavyWorkBench)
            .Register();

        // Lihzahrd
        Recipe.Create(LihzahrdStatue)
            .AddIngredient(LihzahrdBanner, 1)
            .AddIngredient(LihzahrdBrick, 50)
            .AddTile(TileID.HeavyWorkBench)
            .Register();

        // Lihzahrd guardian
        Recipe.Create(LihzahrdGuardianStatue)
            .AddIngredient(LihzahrdBanner, 1)
            .AddIngredient(LihzahrdBrick, 50)
            .AddTile(TileID.HeavyWorkBench)
            .Register();

        // Lihzahrd watcher
        Recipe.Create(LihzahrdWatcherStatue)
            .AddIngredient(LihzahrdBanner, 1)
            .AddIngredient(LihzahrdBrick, 50)
            .AddTile(TileID.HeavyWorkBench)
            .Register();
    }
}
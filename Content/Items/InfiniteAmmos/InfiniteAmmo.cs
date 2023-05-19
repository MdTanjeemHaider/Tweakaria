using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public abstract class InfiniteAmmo : ModItem
{
    public abstract int Ammo { get; }
    public abstract string TexturePath { get; }

    public override string Texture => "Tweakaria/Assets/Items/" + TexturePath;

    public override void SetDefaults()
    {
        Item.CloneDefaults(Ammo);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value *= 1000;
        Item.rare += 1;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(Ammo, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
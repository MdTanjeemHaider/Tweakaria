using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteCursedBullets : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Bullets/InfiniteCursedBullets";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.CursedBullet);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 5, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.CursedBullet, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
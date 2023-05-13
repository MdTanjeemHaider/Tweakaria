using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteChlorophyteBullets : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Bullets/InfiniteChlorophyteBullets";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.ChlorophyteBullet);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 10, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.ChlorophyteBullet, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
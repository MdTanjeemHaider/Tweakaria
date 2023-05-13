using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteVenomBullets : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Bullets/InfiniteVenomBullets";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.VenomBullet);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 5, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.VenomBullet, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
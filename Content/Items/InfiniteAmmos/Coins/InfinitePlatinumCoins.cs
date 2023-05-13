using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfinitePlatinumCoins : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Coins/InfinitePlatinumCoins";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.PlatinumCoin);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 50, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.PlatinumCoin, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }

    public override bool CanUseItem(Player player)
    {
        return false;
    }
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteCopperCoins : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Coins/InfiniteCopperCoins";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.CopperCoin);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 5, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.CopperCoin, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }

    public override bool CanUseItem(Player player)
    {
        return false;
    }
}
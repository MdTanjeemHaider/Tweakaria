using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteStakes : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Others/InfiniteStakes";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.Stake);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 1, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.Stake, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
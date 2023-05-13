using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteGreenSolutions : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Solutions/InfiniteGreenSolutions";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.GreenSolution);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 50, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.GreenSolution, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
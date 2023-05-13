using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteDarkBlueSolutions : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Solutions/InfiniteDarkBlueSolutions";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.DarkBlueSolution);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 50, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.DarkBlueSolution, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
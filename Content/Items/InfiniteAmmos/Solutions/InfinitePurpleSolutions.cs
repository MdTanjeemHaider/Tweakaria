using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfinitePurpleSolutions : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Solutions/InfinitePurpleSolutions";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.PurpleSolution);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 50, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.PurpleSolution, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
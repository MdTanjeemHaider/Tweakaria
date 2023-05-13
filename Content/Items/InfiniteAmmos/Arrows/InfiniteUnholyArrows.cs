using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteUnholyArrows : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Arrows/InfiniteUnholyArrows";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.UnholyArrow);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 3, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.UnholyArrow, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
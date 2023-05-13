using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteHolyArrows : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Arrows/InfiniteHolyArrows";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.HolyArrow);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 5, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.HolyArrow, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
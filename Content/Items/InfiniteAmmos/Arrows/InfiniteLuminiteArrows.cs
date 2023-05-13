using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteLuminiteArrows : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Arrows/InfiniteLuminiteArrows";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.MoonlordArrow);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 20, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.MoonlordArrow, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
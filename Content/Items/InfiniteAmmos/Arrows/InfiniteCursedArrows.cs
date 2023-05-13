using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteCursedArrows : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Arrows/InfiniteCursedArrows";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.CursedArrow);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 5, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.CursedArrow, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
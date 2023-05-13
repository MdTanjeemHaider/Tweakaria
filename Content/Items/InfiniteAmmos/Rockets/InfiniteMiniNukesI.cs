using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteMiniNukesI : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Rockets/InfiniteMiniNukesI";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.MiniNukeI);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 5, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.MiniNukeI, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
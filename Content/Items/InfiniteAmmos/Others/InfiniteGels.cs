using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteGels : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Others/InfiniteGels";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.Gel);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 1, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.Gel, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
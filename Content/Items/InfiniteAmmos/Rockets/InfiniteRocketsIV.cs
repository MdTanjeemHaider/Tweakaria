using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteRocketsIV : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Rockets/InfiniteRocketsIV";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.RocketIV);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 3, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.RocketIV, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
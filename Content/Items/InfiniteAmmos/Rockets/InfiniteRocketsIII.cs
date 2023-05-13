using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteRocketsIII : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Rockets/InfiniteRocketsIII";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.RocketIII);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 3, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.RocketIII, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
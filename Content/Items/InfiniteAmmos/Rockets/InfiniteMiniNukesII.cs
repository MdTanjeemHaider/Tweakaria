using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class InfiniteMiniNukesII : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Rockets/InfiniteMiniNukesII";

    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.MiniNukeII);
        Item.consumable = false;
        Item.maxStack = 1;
        Item.value = Item.buyPrice(0, 5, 0, 0);
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.MiniNukeII, 3996); // 999 x4 stacks
        recipe.AddTile(TileID.CrystalBall);
        recipe.Register();
    }
}
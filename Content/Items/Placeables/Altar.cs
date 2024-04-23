using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class Altar : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Placeables/Altar";

    public override void SetDefaults()
    {
        Item.width = 48;
        Item.height = 32;
        Item.maxStack = 99;
        Item.rare = 3;
        Item.DefaultToPlaceableTile(ModContent.TileType<AltarTile>()); 
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.Gel, 20);
        recipe.AddRecipeGroup("DC", 8);
        recipe.AddRecipeGroup("SS", 10);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();
    }
}
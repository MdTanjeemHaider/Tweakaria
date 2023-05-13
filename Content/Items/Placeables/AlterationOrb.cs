using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class AlterationOrb : ModItem
{
    public override string Texture => "Tweakaria/Assets/Items/Placeables/AlterationOrb";
    
    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.CrystalBall); // Clone the Crystal Ball item
        Item.buyPrice(0, 10, 0, 0);
        Item.DefaultToPlaceableTile(ModContent.TileType<AlterationOrbTile>());
    }
}
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;
using Terraria.Localization;

public class AltarTile : ModTile
{
    public override string Texture => "Tweakaria/Assets/Tiles/Altar";

    public override void SetStaticDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
        TileObjectData.addTile(Type);
        AddMapEntry(new Color(100, 0, 255), Language.GetText("Alter"));

        AdjTiles = new int[] { TileID.DemonAltar }; // Act as Demon Altar for crafting items
    }
}
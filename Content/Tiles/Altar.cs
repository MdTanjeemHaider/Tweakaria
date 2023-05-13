using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;

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
        AddMapEntry(new Color(100, 0, 255), CreateMapEntryName("Altar"));

        AdjTiles = new int[] { TileID.DemonAltar }; // Act as Demon Altar for crafting items
    }

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(new EntitySource_TileBreak(i, j), i*16, j*16, 48, 32, ModContent.ItemType<Altar>());
    }
}
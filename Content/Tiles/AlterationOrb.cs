using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;

public class AlterationOrbTile : ModTile
{
    public override string Texture => "Tweakaria/Assets/Tiles/AlterationOrb";

    public override void SetStaticDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
        TileObjectData.addTile(Type);
        AddMapEntry(new Color(100, 0, 255), CreateMapEntryName("AlterationOrb"));
    }

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(new EntitySource_TileBreak(i, j), i*16, j*16, 32, 32, ModContent.ItemType<AlterationOrb>());
    }
}
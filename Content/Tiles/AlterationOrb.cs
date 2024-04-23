using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
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
        AddMapEntry(new Color(100, 0, 255), Language.GetText("AlterationOrb"));
    }
}
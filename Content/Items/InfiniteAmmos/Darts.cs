using Terraria.ID;

public class InfiniteCrystalDarts : InfiniteAmmo
{
    public override int Ammo => ItemID.CrystalDart;
    public override string TexturePath => "Darts/InfiniteCrystalDarts";
}

public class InfiniteCursedDarts : InfiniteAmmo
{
    public override int Ammo => ItemID.CursedDart;
    public override string TexturePath => "Darts/InfiniteCursedDarts";
}

public class InfiniteIchorDarts : InfiniteAmmo
{
    public override int Ammo => ItemID.IchorDart;
    public override string TexturePath => "Darts/InfiniteIchorDarts";
}

public class InfinitePoisonDarts : InfiniteAmmo
{
    public override int Ammo => ItemID.PoisonDart;
    public override string TexturePath => "Darts/InfinitePoisonDarts";
}
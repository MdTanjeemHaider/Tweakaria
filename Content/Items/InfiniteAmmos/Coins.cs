using Terraria;
using Terraria.ID;

public class InfiniteCopperCoins : InfiniteAmmo
{
    public override int Ammo => ItemID.CopperCoin;
    public override string TexturePath => "Coins/InfiniteCopperCoins";
    public override bool CanUseItem(Player player) { return false; }
}

public class InfiniteSilverCoins : InfiniteAmmo
{
    public override int Ammo => ItemID.SilverCoin;
    public override string TexturePath => "Coins/InfiniteSilverCoins";
    public override bool CanUseItem(Player player) { return false; }
}

public class InfiniteGoldCoins : InfiniteAmmo
{
    public override int Ammo => ItemID.GoldCoin;
    public override string TexturePath => "Coins/InfiniteGoldCoins";
    public override bool CanUseItem(Player player) { return false; }
}

public class InfinitePlatinumCoins : InfiniteAmmo
{
    public override int Ammo => ItemID.PlatinumCoin;
    public override string TexturePath => "Coins/InfinitePlatinumCoins";
    public override bool CanUseItem(Player player) { return false; }
}
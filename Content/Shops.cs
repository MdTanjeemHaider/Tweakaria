using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class Shops : GlobalNPC
{
    public override void ModifyShop(NPCShop shop)
    {
        if (shop.NpcType == NPCID.Merchant)
        {
            shop.Add(new Item(ModContent.ItemType<AlterationOrb>()));
        }
    }
}
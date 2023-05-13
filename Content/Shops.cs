using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class Shops : GlobalNPC
{
    public override void SetupShop(int type, Chest shop, ref int nextSlot)
    {
        // Add the Alteration Orb to the Merchant's shop
        if (type == NPCID.Merchant)
        {
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<AlterationOrb>());
            nextSlot++;
        }
    }
}
using Terraria;
using Terraria.ModLoader;

namespace CoinMayhem
{
    public class CoinMayhemPlayer : ModPlayer
    {

        public float CopperModifier;
        public float SilverModifier;
        public float GoldModifier;
        public float PlatinumModifier;

        private float CopperCoinsInInventory;
        private float SilverCoinsInInventory;
        private float GoldCoinsInInventory;
        private float PlatinumCoinsInInventory;

        public override void ModifyWeaponDamage(Item item, ref float add, ref float mult, ref float flat)
        {
            CountCoins();
            CalculateModifiers();
            add *= 0.5f + CombineModifiers();
            base.ModifyWeaponDamage(item, ref add, ref mult, ref flat);
        }

        private void CountCoins()
        {
            CopperCoinsInInventory = player.CountItem(71);
            SilverCoinsInInventory = player.CountItem(72);
            GoldCoinsInInventory = player.CountItem(73);
            PlatinumCoinsInInventory = player.CountItem(74);
        }

        private void CalculateModifiers()
        {
            CopperModifier = CopperCoinsInInventory * 0.000001f;
            SilverModifier = SilverCoinsInInventory * 0.0001f;
            GoldModifier = GoldCoinsInInventory * 0.01f;
            PlatinumModifier = PlatinumCoinsInInventory * 1f;
        }

        private float CombineModifiers()
        {
            return CopperModifier + SilverModifier + GoldModifier + PlatinumModifier;
        }
    }
}

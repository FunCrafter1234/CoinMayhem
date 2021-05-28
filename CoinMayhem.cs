using Terraria.ModLoader;

namespace CoinMayhem
{
    public class CoinMayhem : Mod
    {
        public CoinMayhem()
        {
            ModProperties properties = default(ModProperties);
            properties.Autoload = true;
            properties.AutoloadGores = true;
            properties.AutoloadSounds = true;
            base.Properties = properties;
        }
	}
}

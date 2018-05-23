using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace coolstuff.Items
{
    public class moonthrower : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Adamantite Boulder");
            Tooltip.SetDefault("20% Increased throwing damage, velocity and throwing speed");
		}

        		public override void SetDefaults()
		{
        item.accessory = true


        }
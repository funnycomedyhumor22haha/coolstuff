using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace coolstuff.Items
{
    public class boulderthrower : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Adamantite Boulder");
            Tooltip.SetDefault("20% Increased throwing damage, velocity and throwing speed");
		}

        		public override void SetDefaults()
		{
        item.accessory = true;
        item.value = 0001000;
        item.rare = 4;
        item.thrown = true;
        }

        
           public override void UpdateAccessory(Player player, bool hideVisual)
            {
                
              player.thrownDamage += 0.20f; 
              player.thrownVelocity += 0.20f;
              player.thrownSpeed += 0.20f;
            }




	}
}

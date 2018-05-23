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
            Tooltip.SetDefault("20% Increased throwing damage and velocity");
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
            }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(366, 28);
            recipe.AddIngredient(3, 50);
            recipe.AddIngredient(520, 5);
			recipe.AddTile(134);
			recipe.SetResult(this);
        }


	}
}

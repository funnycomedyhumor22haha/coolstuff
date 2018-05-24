using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace coolstuff.Items
{
    public class boulderthrower2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Titanium Boulder");
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
			recipe.AddIngredient(1106, 28);
            recipe.AddIngredient(3, 50);
            recipe.AddIngredient(521, 5);
			recipe.AddTile(134);
			recipe.SetResult(this);
            recipe.AddRecipe();
        }


	}
}

using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace coolstuff.Items
{
    public class rockthrower : ModItem
    {
        public override void SetStaticDefaults()
       
        {            DisplayName.SetDefault("A Rock");
            Tooltip.SetDefault("5% Increased throwing damage and velocity");
		}
        


		public override void SetDefaults()
		{
			item.value = 0000000;
			item.rare = 0;
            item.accessory = true;
            item.thrown = true;
            item.defense = 1;
           
		}
        
            public override void UpdateAccessory(Player player, bool hideVisual)
        {
                
              player.thrownDamage += 0.05f; 
              player.thrownVelocity += 0.05f;

            }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3, 5);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
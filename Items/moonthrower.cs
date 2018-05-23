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
            DisplayName.SetDefault("The Moon");
            Tooltip.SetDefault("40% Increased throwing damage, velocity and all weapons inflict celled debuff");
		}
        


		public override void SetDefaults()
		{
			item.value = 480202;
			item.rare = 11;
            item.accessory = true;
            item.thrown = true;
            item.defense = 2;
           
		}
        
            public override void UpdateAccessory(Player player, bool hideVisual)
        {
                
              player.thrownDamage += 0.40f; 
              player.thrownVelocity += 0.40f;

            }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
            recipe.AddIngredient(561, 5);
            recipe.AddIngredient(3054);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(182, 5 * 60);
        }
	}
}
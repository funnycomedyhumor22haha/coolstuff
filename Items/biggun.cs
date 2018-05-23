using Terraria.ID;
using Terraria.ModLoader;

namespace coolstuff.Items
{
	public class biggun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("uzi guy ahahah");
			Tooltip.SetDefault("big gun do damage haha");
		}
		public override void SetDefaults()
		{
			item.damage = 458;
			item.ranged = true;
			item.width = 2;
			item.height = 6;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 12;
			item.UseSound = SoundID.Item2;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1265);
			recipe.AddIngredient(3456, 13);
			recipe.AddIngredient(3467, 9);
			recipe.AddIngredient(3567, 333);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

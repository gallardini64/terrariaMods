using Terraria.ID;
using Terraria.ModLoader;

namespace troloradosMod.Items
{
	public class espadaEjemplo : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("espadaEjemplo"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("esta es la espada de la putisima madre");
		}

		public override void SetDefaults() 
		{
			item.damage = 2000;
			item.melee = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 20000;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
using Terraria.ID;
using Terraria.ModLoader;

namespace troloradosMod.Items
{
	public class espadaEjemplo : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Aguijón antiguo"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Un arma tradicional de Hallownest. Su hoja roma es muestra de su antigüedad y desgaste.");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.melee = true;
			item.width = 60;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
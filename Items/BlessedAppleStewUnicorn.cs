using Terraria.ID;
using Terraria.ModLoader;

namespace CentaurMount.Items
{
	public class BlessedAppleStewUnicorn : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blessed Apple Stew (Unicorn)");
			Tooltip.SetDefault("This Apple Stew is glowing with energy. I wonder what happens when you eat it.");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = 100000;
			item.rare = 8;
			item.UseSound = SoundID.Item25;
			item.noMelee = true;
			item.mountType = mod.MountType("CentaurMountUnicorn");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlessedApple, 1);
			recipe.AddIngredient(ItemID.UnicornHorn, 1);
			recipe.AddTile(TileID.CookingPots);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

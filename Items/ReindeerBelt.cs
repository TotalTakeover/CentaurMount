using Terraria.ID;
using Terraria.ModLoader;

namespace CentaurMount.Items
{
	public class ReindeerBelt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reindeer Belt");
			Tooltip.SetDefault("This belt contains the Spirit of Christmas, although it seems to manifest differently than it usually does.");
		}
		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = 100000;
			item.rare = 8;
			item.UseSound = SoundID.Item25;
			item.noMelee = true;
			item.mountType = mod.MountType("CentaurMountReindeer");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ReindeerBells, 1);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.Holly, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

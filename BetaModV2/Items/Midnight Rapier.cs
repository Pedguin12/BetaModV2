using Terraria.ID;
using Terraria.ModLoader;

namespace BetaModV2.Items
{
	public class MidnightRapier : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Midnight Rapier"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Used by those who praise the moon and fear the sun");
		}

		public override void SetDefaults() 
		{
			item.damage = 63;
			item.melee = true;
			item.width = 50;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = ItemRarityID.Pink;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Muramasa, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 7);
			recipe.AddIngredient(ItemID.Bone, 45);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
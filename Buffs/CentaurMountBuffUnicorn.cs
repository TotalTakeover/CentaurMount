using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CentaurMount.Buffs
{
	public class CentaurMountBuffUnicorn : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Centaur");
			Description.SetDefault("You are a Centaur!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(mod.MountType<Mounts.CentaurMountUnicorn>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
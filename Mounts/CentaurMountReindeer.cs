using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CentaurMount.Mounts
{
	public class CentaurMountReindeer : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = 57;
			mountData.spawnDustNoGravity = false;
			mountData.buff = mod.BuffType("CentaurMountBuffReindeer");
			mountData.heightBoost = 20;
			mountData.flightTimeMax = 160;
			mountData.runSpeed = 5.5f;
			mountData.dashSpeed = 12f;
			mountData.acceleration = 0.09f;
			mountData.jumpHeight = 17;
			mountData.jumpSpeed = 5.31f;
			mountData.totalFrames = 12;
			int[] array = new int[mountData.totalFrames];
			for (int index = 0; index < array.Length; ++index)
				array[index] = 30;
			array[1] += 2;
			array[6] += 2;
			array[7] += 2;
			array[8] += 2;
			array[11] += 2;
			mountData.playerYOffsets = array;
			mountData.xOffset = -7;
			mountData.bodyFrame = 6;
			mountData.yOffset = -9;
			mountData.playerHeadOffset = 22;
			mountData.standingFrameCount = 1;
			mountData.standingFrameDelay = 12;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 6;
			mountData.runningFrameDelay = 12;
			mountData.runningFrameStart = 6;
			mountData.flyingFrameCount = 6;
			mountData.flyingFrameDelay = 6;
			mountData.flyingFrameStart = 6;
			mountData.inAirFrameCount = 1;
			mountData.inAirFrameDelay = 12;
			mountData.inAirFrameStart = 1;
			mountData.idleFrameCount = 0;
			mountData.idleFrameDelay = 0;
			mountData.idleFrameStart = 0;
			mountData.idleFrameLoop = true;
			mountData.swimFrameCount = mountData.inAirFrameCount;
			mountData.swimFrameDelay = mountData.inAirFrameDelay;
			mountData.swimFrameStart = mountData.inAirFrameStart;
			if (Main.netMode != 2)
			{
				mountData.textureWidth = mountData.backTexture.Width;
				mountData.textureHeight = mountData.backTexture.Height;
			}
		}
	}
}
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
	public class CentaurMountUnicorn : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = 15;
			mountData.buff = mod.BuffType("CentaurMountBuffUnicorn");
			mountData.heightBoost = 34;
			mountData.flightTimeMax = 0;
			mountData.fallDamage = 0.2f;
			mountData.runSpeed = 4f;
			mountData.dashSpeed = 12f;
			mountData.acceleration = 0.3f;
			mountData.jumpHeight = 10;
			mountData.jumpSpeed = 8.01f;
			mountData.totalFrames = 16;
			int[] array = new int[mountData.totalFrames];
			for (int index = 0; index < array.Length; ++index)
				array[index] = 28;
			array[15] += 2;
			mountData.playerYOffsets = array;
			mountData.xOffset = -17;
			mountData.bodyFrame = 6;
			mountData.yOffset = 3;
			mountData.playerHeadOffset = 31;
			mountData.standingFrameCount = 1;
			mountData.standingFrameDelay = 12;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 7;
			mountData.runningFrameDelay = 15;
			mountData.runningFrameStart = 1;
			mountData.dashingFrameCount = 6;
			mountData.dashingFrameDelay = 40;
			mountData.dashingFrameStart = 9;
			mountData.flyingFrameCount = 6;
			mountData.flyingFrameDelay = 6;
			mountData.flyingFrameStart = 1;
			mountData.inAirFrameCount = 1;
			mountData.inAirFrameDelay = 12;
			mountData.inAirFrameStart = 15;
			mountData.idleFrameCount = 0;
			mountData.idleFrameDelay = 0;
			mountData.idleFrameStart = 0;
			mountData.idleFrameLoop = false;
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
using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using SkatteverketCards.Extensions;
using UnityEngine;

/*
 private void StartStun()
	{
		this.player.data.playerVel.velocity *= 0f;
		this.player.data.playerVel.isKinematic = true;
		this.player.data.input.stunnedInput = true;
		this.codeAnim.PlayIn();
		this.data.isStunned = true;
    }
 */

namespace SkatteverketCards.Patches
{
	// Hijack StartStun; replace it with our own kinder version
	[HarmonyPatch(typeof(StunHandler), nameof(StunHandler.AddStun))]
	class StartStunPatch_StatusResist
	{
		static bool Prefix(StunHandler __instance, Player ___player)
		{

			float statusResist = UnityEngine.Mathf.Clamp(___player.data.stats.SkatteverketStats().StatusResist, -5, 1);
			

			var playerVelTrav = Traverse.Create(___player.data.playerVel);     
			playerVelTrav.Field<Vector2>("velocity").Value *= (statusResist * 0.01f);  // this.player.data.playerVel.velocity *= 0f;

			if (statusResist < 0.05) // only disable movement if very low status resist
			{
				playerVelTrav.Field<bool>("isKinematic").Value = true;  //this.player.data.playerVel.isKinematic = true;
			}
			playerVelTrav.Field<bool>("stunnedInput").Value = true; //this.player.data.input.stunnedInput = true;
			
			__instance.codeAnim.PlayIn();
			___player.data.isStunned = true; //this.data.isStunned = true; -- unchanged
			return false;

		}
	}
}

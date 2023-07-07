using System;
using System.Collections.Generic;
using System.Text;
//using CustomStatExtension.Extensions;
using HarmonyLib;
using ModdingUtils.Extensions;
using SkatteverketCards.Extensions;

namespace SkatteverketCards.Patches
{
	[HarmonyPatch(typeof(StunHandler), nameof(StunHandler.AddStun))]
	class AddStunPatch_StatusResist
	{
		static void Prefix(StunHandler __instance, Player ___player, ref float __0)
		{
			UnityEngine.Debug.Log($"prefix stunhandler called");
			float fMult = 1f - UnityEngine.Mathf.Clamp(___player.data.stats.SkatteverketStats().StatusResist, 0,1);
			UnityEngine.Debug.Log($"fMult: {fMult}, f * fMult = {__0} * {fMult} = {__0 * fMult}");
			
			UnityEngine.Debug.Log($"Old Duration: {__0}");
			float newRetVal = __0 * fMult;
			__0 = newRetVal;
			UnityEngine.Debug.Log($"New Duration: {__0}");
		}
	}
}
/*
		//[HarmonyPatch(typeof(StunHandler), nameof(StunHandler.AddStun))]
		//static void Prefix(StunHandler __instance, Player ___player, ref float f)
		//{
			//UnityEngine.Debug.Log($"player status resist: {___player.data.stats.SkatteverketStats().StatusResist}");
		//}


		public static class ChatSendMessagePatch
		{
			public static bool Prefix(DevConsole __instance, string message)
			{
				Player sender = ChatCMDModUtilities.GetPlayerWithActorID(PhotonNetwork.LocalPlayer.ActorNumber);

				UnityEngine.Debug.Log(message);
				UnityEngine.Debug.Log(sender);
				if (message.StartsWith("!"))
				{
					OnChatSendCmd(sender, message);
					return false; // stop RPCA_SendChat from executing
				};
				return true;
			}

		
*/


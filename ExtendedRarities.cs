using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;
using RarityLib.Utils;
using UnityEngine;

namespace SkatteverketCards
{
    static class ExtendedRarities
    {
		/// <summary>
		/// Small bonuses and are easily replaced
		/// </summary>
		public static CardInfo.Rarity Trinket => RarityUtils.GetRarity(nameof(Trinket));

		/// <summary>
		/// Can be found all over the place, but they aren't anything special.
		/// </summary>
		public static CardInfo.Rarity Common => RarityUtils.GetRarity(nameof(Common));

		/// <summary>
		/// Scarce abilities are harder to come by, but they offer a little more power than common abilities.
		/// </summary>
		public static CardInfo.Rarity Scarce => RarityUtils.GetRarity(nameof(Scarce));

		/// <summary>
		/// Uncommon abilities are not quite as common as their name suggests. They offer a noticeable boost in power.
		/// </summary>
		public static CardInfo.Rarity Uncommon => RarityUtils.GetRarity(nameof(Uncommon));

		/// <summary>
		/// Exotic abilities are the stuff of legend. They are highly sought after and can turn the tide of battle in your favor.
		/// </summary>
		public static CardInfo.Rarity Exotic => RarityUtils.GetRarity(nameof(Exotic));

		/// <summary>
		/// Rare abilities are extremely hard to come by and are only possessed by a select few. They offer a significant increase in power.
		/// </summary>
		public static CardInfo.Rarity Rare => RarityUtils.GetRarity(nameof(Rare));

		/// <summary>
		/// Epic abilities are almost mythical in nature. They are extremely powerful and can change the course of the game.
		/// </summary>
		public static CardInfo.Rarity Epic => RarityUtils.GetRarity(nameof(Epic));

		/// <summary>
		/// They are extremely rare and offer god-like power.
		/// </summary>
		public static CardInfo.Rarity Legendary => RarityUtils.GetRarity(nameof(Legendary));

		/// <summary>
		/// Mythical abilities are the pinnacle of power.They are so rare that many people don't even believe they exist.
		/// </summary>
		public static CardInfo.Rarity Mythical => RarityUtils.GetRarity(nameof(Mythical));
		/// <summary>
		/// Divine abilities are gifted by the gods themselves. They offer power beyond measure and can bend the very fabric of reality.
		/// </summary>
		public static CardInfo.Rarity Divine => RarityUtils.GetRarity(nameof(Divine));

	}
}

//using CustomStatExtension.Extensions;
//using CustomStatExtension.Utils;
using UnityEngine;
using RarityLib;
using ModsPlus;
using RarityLib.Utils;
using SkatteverketCards.Extensions;

namespace SkatteverketCards.Cards
{


	public class RememberTheName : SimpleCard
	{
		public override CardDetails Details => new CardDetails
		{
			Title = "Remember the name",
			Description = null,
			ModName = SkatteverketCards.ModNameOnCard,
			Art = null,
			Rarity = ExtendedRarities.Rare,
			Theme = CardThemeColor.CardThemeColorType.DefensiveBlue,
			Stats = new CardInfoStat[] {
				new CardInfoStat()
				{
					positive = true,
					stat = "Luck",
					amount = "10%",
					simepleAmount = CardInfoStat.SimpleAmount.notAssigned
				},
				new CardInfoStat()
				{
					positive = true,
					stat = "Skill",
					amount = "20%",
					simepleAmount = CardInfoStat.SimpleAmount.notAssigned
				},
				new CardInfoStat()
				{
					positive = true,
					stat = "concentrated",
					amount = "15%",
					simepleAmount = CardInfoStat.SimpleAmount.notAssigned
				},
				new CardInfoStat()
				{
					stat = "power of will",
				},
				new CardInfoStat()
				{
					positive = true,
					stat = "Pleasure",
					amount = "5%",
					simepleAmount = CardInfoStat.SimpleAmount.notAssigned
				},
				new CardInfoStat() // start with 50% hp
				{
					positive = false,
					stat = "pain",
					amount = "50%",
					simepleAmount = CardInfoStat.SimpleAmount.notAssigned
				},
				new CardInfoStat()
				{
					positive = true,
					stat = "reason to",
					amount = "100%",
					simepleAmount = CardInfoStat.SimpleAmount.notAssigned
				},
				new CardInfoStat()
				{
					stat = "remember the name",
				}
			}
		};

		public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
		{
			UnityEngine.Debug.Log($"[{SkatteverketCards.ModInitials}][Card] {GetTitle()} has been setup.");

			// 10% luck
			// TODO

			// 20% skill
			// +20% Damage
			gun.damage = 1.2f;

			// 15% concentrated power of will
			//statModifiers.GetCustomStats().stats["StatusResist"] = 1.15f;
			//statModifiers.SkatteverketStats().StatusResist = 1.15f;

			// 5% Pleasure

			// 50% pain
			statModifiers.health = 1.5f;

			// 100% reason to remember the name

		}

		protected override void Added(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
		{
			base.Added(player, gun, gunAmmo, data, health, gravity, block, characterStats);
			UnityEngine.Debug.Log("Remember Added");
			player.data.stats.SkatteverketStats().StatusResist += 0.15f;
			UnityEngine.Debug.Log(player.data.stats.SkatteverketStats().StatusResist);
		}

	}
}

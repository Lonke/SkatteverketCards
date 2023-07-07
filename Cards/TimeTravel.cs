using UnityEngine;
using ModsPlus;


namespace SkatteverketCards.Cards
{
	public class TimeTravel : SimpleCard
	{
		public override CardDetails Details => new CardDetails
		{
			Title = "Time Travel",
			Description = "Last 4 Cards... gone.",
			ModName = SkatteverketCards.ModNameOnCard,
			Rarity = ExtendedRarities.Exotic,

			Art = null,
			Theme = CardThemeColor.CardThemeColorType.DefensiveBlue,

			Stats = new CardInfoStat[] {
				new CardInfoStat()
				{
					positive = true,
					stat = "Hindsight",
					amount = "+400%",
					simepleAmount = CardInfoStat.SimpleAmount.notAssigned
				}
			}
		};

		public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
		{
			UnityEngine.Debug.Log($"[{SkatteverketCards.ModInitials}][Card] {GetTitle()} has been setup.");

		}

		protected override void Added(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
		{
			foreach (var p in PlayerManager.instance.players)
			{
				UnityEngine.Debug.Log($"Player {p}");
				for (var i = 0; i < 4; i++)
				{
					UnityEngine.Debug.Log($"i = {i}");
					UnityEngine.Debug.Log($"Card Count: {p.data.currentCards.Count}");
					if (p.data.currentCards.Count - i > 1)
					{
						ModdingUtils.Utils.Cards.instance.RemoveCardFromPlayer(p, p.data.currentCards.Count - i);
					}
				}
			}

		}
	}
}

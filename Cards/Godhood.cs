using ModsPlus;
using RarityLib;

namespace SkatteverketCards.Cards
{
	public class GodHood : SimpleCard
	{
		public override CardDetails Details => new CardDetails
		{
			Title = "Godhood",
			Description = "<color=\"purple\">Omnipotence</color> within reach",
			ModName = SkatteverketCards.ModNameOnCard,
			Rarity = ExtendedRarities.Divine,

			Art = null,
			Theme = CardThemeColor.CardThemeColorType.FirepowerYellow,

			Stats = new CardInfoStat[] {
				new CardInfoStat
				{
					positive = true,
					stat = "Stat",
					amount = "100%",
					simepleAmount = CardInfoStat.SimpleAmount.notAssigned
				}
			}
		};

		protected override void Added(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity,
			Block block, CharacterStatModifiers characterStats)
		{
			base.Added(player, gun, gunAmmo, data, health, gravity, block, characterStats);

			//player.data.
		}
	}
}

using System;
using System.Runtime.CompilerServices;


namespace SkatteverketCards.Extensions
{
	public static class CharacterStatsSkatteverketExtension
	{
		public static readonly ConditionalWeakTable<CharacterStatModifiers, SkatteverketStatsData> data = new ConditionalWeakTable<CharacterStatModifiers, SkatteverketStatsData>();

		public class SkatteverketStatsData
		{
			public float StatusResist;

			public SkatteverketStatsData() => this.StatusResist = 0;
		}

		public static SkatteverketStatsData SkatteverketStats(this CharacterStatModifiers characterStatModifiers)
		{
			return data.GetOrCreateValue(characterStatModifiers);
		}

		//public static void AddSkatteverketStat(this CharacterStatModifiers characterStatModifiers,
		//	SkatteverketStatsData value)
		//{
		//	try
		//	{
		//		CharacterStatsSkatteverketExtension.data.Add(characterStatModifiers, value);
		//	}
		//	catch (Exception e)
		//	{
		//		// ignored
		//	}
		//}


	}
}

namespace SkatteverketCards.CustomStats
{
	public static class StatusResist
	{

		// Func<object currentValue, object incomingValue, object finalValue>
		public static object ApplyStat(object @base, object change) => ((float)@base + (float)change);

	}
	
}

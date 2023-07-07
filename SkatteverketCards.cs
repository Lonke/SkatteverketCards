using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using SkatteverketCards.Cards;
using HarmonyLib;
using ModsPlus;

using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using SkatteverketCards.CustomStats;

namespace SkatteverketCards
{
	// These are the mods required for our mod to work
	[BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency("com.willis.rounds.modsplus", BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
	// Declares our mod to Bepin
	[BepInPlugin(ModId, ModName, Version)]
	// The game our mod is associated with
	[BepInProcess("Rounds.exe")]
	public class SkatteverketCards : BaseUnityPlugin
	{
		private const string ModId = "com.lonke.rounds.SkatteverketCards";
		private const string ModName = "SkatteverketCards";
		public const string Version = "0.1.0"; // What version are we on (major.minor.patch)?

		public const string ModNameOnCard = "SKTVRKT";
		public const string ModInitials = "SKTV";

		#pragma warning disable CS8618
		public static SkatteverketCards instance { get; private set; }

		void Awake()
		{
			// Use this to call any harmony patch files your mod may have
			var harmony = new Harmony(ModId);
			harmony.PatchAll();
		}
		void Start()
		{
			instance = this;

			CustomCard.BuildCard<RememberTheName>();
			CustomCard.BuildCard<TimeTravel>();
			CustomCard.BuildCard<GodHood>();

			// Func<object currentValue, object incomingValue, object finalValue>
			//CustomStatExtension.Utils.CustomStatManager.instance.RegisterStat("StatusResist", 0f, StatusResist.ApplyStat);
			//ModdingUtils.Utils.

		}
	}
}

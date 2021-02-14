using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogStats2
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk15
	{
		public const int Size = 14;

		// Overall boost to Attack statistic from alchemy/items/statuses
		public UInt16 DogOverallAttackBoost; // [226|xE4] (2 bytes)

		// Overall boost to Defense statistic from alchemy/items/statuses
		public UInt16 DogOverallDefenseBoost; // [228|xE6] (2 bytes)

		// Overall boost to Evade % statistic from alchemy/items/statuses
		public UInt16 DogOverallEvadeBoost; // [230|xE8] (2 bytes)

		// Overall boost to Hit % statistic from alchemy/items/statuses
		public UInt16 DogOverallHitBoost; // [232|xE8] (2 bytes)

		// Overall boost to Magic Defense statistic from alchemy/items/statuses(unused)
		public UInt16 DogOverallMagicDefenseBoost; // [234|xFA] (2 bytes)

		// Last damage taken.  Used by time Warp (Horace).
		public UInt16 DogLastDamageTaken; // [236|xEC] (2 bytes)

		// Regenerate (Horace) or Pixie Dust protection in effect (0001 = yes, 0000 = no)
		public UInt16 DogRegenerateOrPixieDustInEffect; // [238|xEE] (2 bytes)
	}
}
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Models.Structs;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogStats1
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk13
	{
		public const int Size = 13;

		public UInt16 DogAttack; // [209|xD1] (2 bytes)
		public UInt16 DogDefense;// [211|xD3] (2 bytes)
		public UInt16 DogMagicDefense;// [213|xD5] (2 bytes)
		public UInt16 DogEvadePercent;// [215|xD7] (2 bytes)
		public UInt16 DogHitPercent;// [217|x9D9] (2 bytes)
		public UInt24 DogExperience; // [219|xDB] (3 bytes)
	}
}
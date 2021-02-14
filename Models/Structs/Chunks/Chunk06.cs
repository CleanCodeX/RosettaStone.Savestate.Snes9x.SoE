using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Models.Structs;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyStats1
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk06
	{
		public const int Size = 13;

		public UInt16 BoyAttack; // [144|x90] (2 bytes)
		public UInt16 BoyDefense;// [146|x92] (2 bytes)
		public UInt16 BoyMagicDefense;// [148|x94] (2 bytes)
		public UInt16 BoyEvadePercent;// [150|x96] (2 bytes)
		public UInt16 BoyHitPercent;// [152|x98] (2 bytes)
		public UInt24 BoyExperience; // [154|x9A] (3 bytes)
	}
}
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyCurrentHp
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[HasToStringOverride]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk02
	{
		public const int Size = 2; // (x2) 

		public UInt16 BoyCurrentHp; // [110|x69] (2 bytes)

		public override string ToString() => BoyCurrentHp.ToString();
	}
}
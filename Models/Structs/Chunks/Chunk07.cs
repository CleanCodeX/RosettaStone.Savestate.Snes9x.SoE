using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyLevel
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Chunk07
	{
		public const int Size = 4;

		public UInt16 BoyLevel; // [157|x9D] (2 bytes)
		public UInt16 BoyMaxChargeup; // [159|x9F] (2 bytes)
	}
}
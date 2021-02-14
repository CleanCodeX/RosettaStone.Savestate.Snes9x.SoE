using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogLevel
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Chunk14
	{
		public const int Size = 4;

		public UInt16 DogLevel; // [222|xDE] (2 bytes)
		public UInt16 DogMaxChargeup; // [224|xE0] (2 bytes)
	}
}
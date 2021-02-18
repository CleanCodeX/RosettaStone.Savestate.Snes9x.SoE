using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogMaxHp
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk12
	{
		public const int Size = 2;

		public UInt16 DogMaxHp; // [207|xCF] (2 bytes)
	}
}
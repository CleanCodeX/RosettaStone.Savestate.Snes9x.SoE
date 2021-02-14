using System.Diagnostics;
using System.Runtime.InteropServices;
using SoE;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Chunk11
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk11
	{
		public const int Size = 6;

		// Unknown 7
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown7)]
		public byte[] Unknown7; // [201|xC9] (6 bytes)
	}
}
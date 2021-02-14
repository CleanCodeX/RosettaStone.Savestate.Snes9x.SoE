using System.Diagnostics;
using System.Runtime.InteropServices;
using SoE;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Unknown4
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk04
	{
		public const int Size = 6;

		// Unknown 4
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown4)]
		public byte[] Unknown4; // [136|x88] (6 bytes)
	}
}
using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;
using RosettaStone.Savestate.Snes9x.SoE.Constants;

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk09
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Chunk9)]
		public byte[] Data;

		public char[] AsChars => Data.GetChars();
		
		public override string ToString() => new(AsChars);
	}
}
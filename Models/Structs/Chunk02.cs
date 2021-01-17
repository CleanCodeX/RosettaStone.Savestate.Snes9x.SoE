using System.Diagnostics;
using System.Runtime.InteropServices;
using RosettaStone.Savestate.Snes9x.SoE.Constants;
using RosettaStone.Savestate.Snes9x.SoE.Extensions;

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk02
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Chunk2)]
		public byte[] Data;
		public char[] AsChars => Data.GetChars();
		
		public override string ToString() => new(AsChars);
	}
}
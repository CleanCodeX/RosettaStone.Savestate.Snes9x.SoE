using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using RosettaStone.Savestate.Snes9x.SoE.Constants;

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk09
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk09)]
		public byte[] Data;

		public char[] AsChars => Encoding.ASCII.GetChars(Data);
		public string AsString => new(AsChars);

		public override string ToString() => AsString;
	}
}
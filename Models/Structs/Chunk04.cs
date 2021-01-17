using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using RosettaStone.Savestate.Snes9x.SoE.Extensions;
using RosettaStone.Savestate.Snes9x.SoE.Constants;

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk04
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Chunk4)]
		public byte[] Data;

		public char[] AsChars => Data.GetChars();
		public ushort AsNumber => BitConverter.ToUInt16(Data);
		public ushort AsReversedNumber => BitConverter.ToUInt16(Data.Reverse().ToArray());

		public override string ToString() => new (AsChars);
	}
}
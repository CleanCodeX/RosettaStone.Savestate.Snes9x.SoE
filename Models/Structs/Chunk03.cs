using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using RosettaStone.Savestate.Snes9x.SoE.Constants;
using RosettaStone.Savestate.Snes9x.SoE.Extensions;

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk03
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Chunk3)]
		public byte[] Data;

		public char[] AsChars => Data.GetChars();
		public uint AsNumber => BitConverter.ToUInt32(Data);
		public uint AsReversedNumber => BitConverter.ToUInt32(Data.Reverse().ToArray());

		public override string ToString() => new(AsChars);
	}
}
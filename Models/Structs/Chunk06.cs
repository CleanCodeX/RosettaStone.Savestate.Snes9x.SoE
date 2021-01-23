using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using SramCommons.Extensions;
using RosettaStone.Savestate.Snes9x.SoE.Constants;

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk06
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Chunk6)]
		public byte[] Data;

		public char[] AsChars => Data.GetChars();
		public uint AsNumber => BitConverter.ToUInt32(Data);
		public uint AsReversedNumber => BitConverter.ToUInt32(Data.Reverse().ToArray());

		public override string ToString() => new(AsChars);
	}
}
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using RosettaStone.Savestate.Snes9x.SoE.Constants;

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk01
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk01)]
		public byte[] Data;

		public char[] AsChars => Encoding.ASCII.GetChars(Data);
		public string AsString => new(AsChars);
		public ushort AsNumber => BitConverter.ToUInt16(Data);
		public ushort AsNumberReversed => BitConverter.ToUInt16(Data.Reverse().ToArray());

		public override string ToString() => AsString;
	}
}
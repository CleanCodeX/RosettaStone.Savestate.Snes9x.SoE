using System.Runtime.InteropServices;
using RosettaStone.Savestate.Snes9x.SoE.Constants;

// ReSharper disable BuiltInTypeReferenceStyle

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)] 
	public struct WramSoE
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown1)]
		public byte[] Unknown1; // Offset 0 (2613 bytes)

		public WramSramAreaSoE SramArea; // Offset [2613|xA35] (17_840 bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown2)]
		public byte[] Unknown2; // Offset [20_453|x4FE5] (110_619 bytes)
	}
}
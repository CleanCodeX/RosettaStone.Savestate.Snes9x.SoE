using System;
using System.Runtime.InteropServices;
using RosettaStone.Savestate.Snes9x.SoE.Constants;
// ReSharper disable BuiltInTypeReferenceStyle

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)] // 8192
	public struct WramSoE
	{
		public byte StereoMono; // Offset 0 (1 byte)
		public byte LastSaveslot; // Offset 1 (1 byte)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public WramSaveSlotSoE[] SaveSlots; // Offset 2 (3268 = 4* 817 bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.WramUnknown1)]
		public byte[] Unknown1; // Offset 3270 [xCC6] (4922 bytes)
	}
}
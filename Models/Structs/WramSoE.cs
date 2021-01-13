using System.Runtime.InteropServices;
using RosettaStone.Savestate.Snes9x.SoE.Constants;
using RosettaStone.Sram.SoE.Models.Structs;

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WramSoE
	{
		public ushort Checksum; // Offset 0 (2 Bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
		public SaveSlotSoE[] SaveSlots; // Offset 2 (3268 = 4* 817 Bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SramUnknown1)]
		public byte[] Unknown1; // Offset 3270 (4922 Bytes)
	}
}
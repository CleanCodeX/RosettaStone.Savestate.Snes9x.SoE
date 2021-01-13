#define USE_STRUCTURES

using System;
using System.Runtime.InteropServices;
using System.Text;
#if !USE_STRUCTURES
using RosettaStone.Savestate.Snes9x.SoE.Constants;
#endif
using RosettaStone.Sram.SoE.Models.Structs;

// ReSharper disable InconsistentNaming

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WramSaveSlotSoE
	{
		public ushort SaveSlotChecksum; // (2 bytes)

		public CharacterName LastSavePointName; // [2] (34 bytes)
		public UInt16 Unknown1; // [36|x24] (2 bytes)

		public CharacterName BoyName; // [38|x26] (34 bytes)
		public UInt16 Unknown2; // [72|x48] (2 bytes)

		public CharacterName DogName; // [74|x4A] (34 bytes)
		public UInt16 Unknown3; // [108|x6C] (2 bytes)

#if USE_STRUCTURES

		public Chunk01 Chunk01; // [110|x6E] (2 bytes)
		public Chunk02 Chunk02; // [112|x70] (26 bytes)
		public Chunk03 Chunk03; // [138|x8A] (4 bytes)
		public Chunk04 Chunk04; // [142|x8E] (2 bytes)
		public Chunk05 Chunk05; // [144|x90] (13 bytes)
		public Chunk06 Chunk06; // [157|x9D] (4 bytes)
		public Chunk07 Chunk07; // [161|xA1] (14 bytes)
		public Chunk08 Chunk08; // [175|xAf] (2 bytes)
		public Chunk09 Chunk09; // [177|xB1] (26 bytes)
		public Chunk10 Chunk10; // [203|xCB] (4 bytes)
		public Chunk11 Chunk11; // [207|xCF] (2 bytes)
		public Chunk12 Chunk12; // [209|xD1] (13 bytes)
		public Chunk13 Chunk13; // [222|xDE] (4 bytes)
		public Chunk14 Chunk14; // [226|xE2] (14 bytes)
		public Chunk15 Chunk15; // [240|xF0] (101 bytes)
		public Chunk16 Chunk16; // [341|x155] (162 bytes)
		public Chunk17 Chunk17; // [503|x1F7] (146 bytes)
		public Chunk18 Chunk18; // [649|x289] (92 bytes)
		public Chunk19 Chunk19; // [741|x2E5] (44 bytes)
		public Chunk20 Chunk20; // [785|x311] (32 bytes)

#else
		// Chunk 1
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk01)]
		public byte[] Chunk01; // (2|x2) offset [110|x6E]

		// Chunk 2
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk02)]
		public byte[] Chunk02; // (26|x1A) offset [112|x70]

		// Chunk 3
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk03)]
		public byte[] Chunk03; // (4|x4) offset [138|x8A]

		// Chunk 4
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk04)]
		public byte[] Chunk04; // (2|x2) offset [142|x8E]

		// Chunk 5
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk05)]
		public byte[] Chunk05; // (13|xD) offset [144|x90]

		// Chunk 6
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk06)]
		public byte[] Chunk06; // (4|x4) offset [157|x9D]

		// Chunk 7
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk07)]
		public byte[] Chunk07; // (14|xE) offset [161|xA1]

		// Chunk 8
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk08)]
		public byte[] Chunk08; // (2|x2) offset [175|xAF]

		// Chunk 9
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk09)]
		public byte[] Chunk09; // (26|x1A) offset [177|xB1]

		// Chunk 10
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk10)]
		public byte[] Chunk10; // (4|x4) offset [203|xCB]

		// Chunk 11
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk11)]
		public byte[] Chunk11; // (2|x2) offset [207|xCF]

		// Chunk 12
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk12)]
		public byte[] Chunk12; // (13|xD) offset [209|xD1]

		// Chunk 13
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk13)]
		public byte[] Chunk13; // (4|x4) offset [222|xDE]

		// Chunk 14
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk14)]
		public byte[] Chunk14; // (14|xE) offset [226|xE2]

		// Chunk 15
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk15)]
		public byte[] Chunk15; // (101|x65) offset [240|xF0]

		// Chunk 16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk16)]
		public byte[] Chunk16; // (162|xA2) offset [341|x155]

		// Chunk 17
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk17)]
		public byte[] Chunk17; // (146|x92) offset [503|x1F7]

		// Chunk 18
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk18)]
		public byte[] Chunk18; // (92|x5C) offset [649|x289]

		// Chunk 19
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk19)]
		public byte[] Chunk19; // (44|x2C) offset [741|x2E5]

		// Chunk 20
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk20)]
		public byte[] Chunk20; // (32|x20) offset [785|x311]
#endif

		public override string ToString()
		{
			var sb = new StringBuilder();

			sb.AppendLine($"{nameof(Unknown1)}: {Unknown1}");
			sb.AppendLine($"{nameof(BoyName)}: {BoyName}");
			sb.AppendLine($"{nameof(Unknown2)}: {Unknown2}");
			sb.AppendLine($"{nameof(DogName)}: {DogName}");
			sb.AppendLine($"{nameof(Unknown3)}: {Unknown3}");
			sb.AppendLine($"{nameof(Chunk01)}: {Chunk01}");
			sb.AppendLine($"{nameof(Chunk02)}: {Chunk02}");
			sb.AppendLine($"{nameof(Chunk03)}: {Chunk03}");
			sb.AppendLine($"{nameof(Chunk04)}: {Chunk04}");
			sb.AppendLine($"{nameof(Chunk05)}: {Chunk05}");
			sb.AppendLine($"{nameof(Chunk06)}: {Chunk06}");
			sb.AppendLine($"{nameof(Chunk07)}: {Chunk07}");
			sb.AppendLine($"{nameof(Chunk08)}: {Chunk08}");
			sb.AppendLine($"{nameof(Chunk09)}: {Chunk09}");
			sb.AppendLine($"{nameof(Chunk10)}: {Chunk10}");
			sb.AppendLine($"{nameof(Chunk11)}: {Chunk11}");
			sb.AppendLine($"{nameof(Chunk12)}: {Chunk12}");
			sb.AppendLine($"{nameof(Chunk13)}: {Chunk13}");
			sb.AppendLine($"{nameof(Chunk14)}: {Chunk14}");
			sb.AppendLine($"{nameof(Chunk15)}: {Chunk15}");
			sb.AppendLine($"{nameof(Chunk16)}: {Chunk16}");
			sb.AppendLine($"{nameof(Chunk17)}: {Chunk17}");
			sb.AppendLine($"{nameof(Chunk18)}: {Chunk18}");
			sb.AppendLine($"{nameof(Chunk19)}: {Chunk19}");
			sb.AppendLine($"{nameof(Chunk20)}: {Chunk20}");

			return sb.ToString();
		}
	}
}
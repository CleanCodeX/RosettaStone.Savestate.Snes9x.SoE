using System.Runtime.InteropServices;
using System.Text;
using RosettaStone.Savestate.Snes9x.SoE.Constants;
using RosettaStone.Sram.SoE.Models.Structs;

// ReSharper disable InconsistentNaming

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WramSramAreaSoE
	{
		// Chunk1
		public Chunk1 Chunk1; // [2613|xA35] (2 bytes) 

		// Unknown1
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown1)]
		public byte[] Unknown1; // [2615|xA37] (8 Bytes)

		// Chunk2
		public Chunk02 Chunk2; // [2623|xA3F] (13 bytes) 

		// Unknown2
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown2)]
		public byte[] Unknown2; // [2636|xA4C] (4 Bytes)

		// Chunk3
		public Chunk03 Chunk3; // [2640|xA50] (4 bytes)

		// Unknown3
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown3)]
		public byte[] Unknown3; // [2644|xA54] (34 Bytes)

		// Chunk4
		public Chunk04 Chunk4; // [2687|xA7F] (2 bytes)

		// Unknown4
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown4)]
		public byte[] Unknown4; // [2689|xA81] (8 Bytes)

		// Chunk5
		public Chunk05 Chunk5; // [2697|xA89] (13 bytes)

		// Unknown5
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown5)]
		public byte[] Unknown5; // [2710|xA96] (4 Bytes)

		// Chunk6
		public Chunk06 Chunk6; // [2714|xA9A] (4 bytes)

		// Unknown6
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown6)]
		public byte[] Unknown6; // [2718|xA9E] (28 Bytes)

		// Chunk7
		public Chunk07 Chunk7; // [2746|xABA] (101 bytes)

		// Unknown7
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown7)]
		public byte[] Unknown7; // [2847|xB1F] (5873 Bytes)

		// BoyName
		public FixedLengthString BoyName; // [8720|x2210] (36 bytes)
		// DogName
		public FixedLengthString DogName; // [8756|x2234] (36 bytes)
		// Chunk8
		public Chunk08 Chunk8; // [8792|x2258] (146 bytes)

		// Unknown8
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown8)]
		public byte[] Unknown8; // [8938|x22EA] (21 Bytes)

		// Chunk9
		public Chunk09 Chunk9; // [8959|x22FF] (92 bytes)

		// Unknown9
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown9)]
		public byte[] Unknown9; // [9051|x235B] (6 Bytes)

		// Chunk10
		public Chunk10 Chunk10; // [9057|x2361] (44 bytes)

		// Unknown10
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown10)]
		public byte[] Unknown10; // [9101|x238D] (390 Bytes)

		// Chunk11
		public Chunk11 Chunk11; // [9491|x2513] (32 bytes)

		// Unknown11
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown11)]
		public byte[] Unknown11; // [9523|x2533] (2591 Bytes)

		// Chunk12
		public Chunk12 Chunk12; // [12114|x2F52] (162 bytes)

		// Unknown12
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown12)]
		public byte[] Unknown12; // [22276|x5704] (7871 Bytes)

		// Chunk13
		public Chunk13 Chunk13; // [20147|x6E] (2 bytes)

		// Unknown13
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown13)]
		public byte[] Unknown13; // [20149|x4EB5] (26 Bytes)

		// Chunk14
		public Chunk14 Chunk14; // [20175|x4EB3] (24 bytes)

		// Unknown14
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown14)]
		public byte[] Unknown14; // [20199|x4EE7] (60 Bytes)

		// Chunk15
		public Chunk15 Chunk15; // [20259|x4ECF] (6 bytes)
		// Chunk16
		public Chunk16 Chunk16; // [20265|x4F23] (14 bytes)

		// Unknown15
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown15)]
		public byte[] Unknown15; // [20279|x4F37] (42 Bytes)

		// Chunk17
		public Chunk18 Chunk17; // [20321|x4F61] (2 bytes)

		// Unknown16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown16)]
		public byte[] Unknown16; // [20323|x4F63] (26 Bytes)

		// Chunk18
		public Chunk19 Chunk18; // [20349|x4F7D] (24 bytes)

		// Unknown17
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Sram.Unknown17)]
		public byte[] Unknown17; // [20373|x4F95] (60 Bytes)

		// Chunk19
		public Chunk20 Chunk19; // [20433|x4FD1] (6 bytes)
		// Chunk20
		public Chunk20 Chunk20; // [20439|x4FD7] (14 bytes)

		public override string ToString()
		{
			var sb = new StringBuilder();

			sb.AppendLine($"{nameof(Chunk1)}: {Chunk1}");
			sb.AppendLine($"{nameof(Chunk2)}: {Chunk2}");
			sb.AppendLine($"{nameof(Chunk3)}: {Chunk3}");
			sb.AppendLine($"{nameof(Chunk4)}: {Chunk4}");
			sb.AppendLine($"{nameof(Chunk5)}: {Chunk5}");
			sb.AppendLine($"{nameof(Chunk6)}: {Chunk6}");
			sb.AppendLine($"{nameof(Chunk7)}: {Chunk7}");

			sb.AppendLine($"{nameof(BoyName)}: {BoyName}");
			sb.AppendLine($"{nameof(DogName)}: {DogName}");
			sb.AppendLine($"{nameof(Chunk8)}: {Chunk8}");

			sb.AppendLine($"{nameof(Chunk9)}: {Chunk9}");
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
using System.Runtime.InteropServices;
using System.Text;
using RosettaStone.Sram.SoE.Models.Structs;

// ReSharper disable InconsistentNaming

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WramSaveSlotSoE
	{
		public FixedString LastSavePointName; // [2] (36 bytes)
		public FixedString BoyName; // [38|x26] (36 bytes)
		public FixedString DogName; // [74|x4A] (36 bytes)

		public Chunk01 Chunk01; // [110|x6E] (2 bytes)
		public Chunk02 Chunk02; // [112|x70] (24 bytes)
		public Chunk03 Chunk03; // [138|x8A] (6 bytes)
		public Chunk04 Chunk04; // [142|x8E] (2 bytes)
		public Chunk05 Chunk05; // [144|x90] (13 bytes)
		public Chunk06 Chunk06; // [157|x9D] (4 bytes)
		public Chunk07 Chunk07; // [161|xA1] (14 bytes)
		public Chunk08 Chunk08; // [175|xAf] (2 bytes)
		public Chunk09 Chunk09; // [177|xB1] (24 bytes)
		public Chunk10 Chunk10; // [203|xCB] (6 bytes)
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

		public override string ToString()
		{
			var sb = new StringBuilder();

			sb.AppendLine($"{nameof(LastSavePointName)}: {LastSavePointName}");
			sb.AppendLine($"{nameof(BoyName)}: {BoyName}");
			sb.AppendLine($"{nameof(DogName)}: {DogName}");
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
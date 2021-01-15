using System.Runtime.InteropServices;
using System.Text;
using RosettaStone.Sram.SoE.Models.Structs;

// ReSharper disable InconsistentNaming

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WramSaveSlotSoE
	{
		public FixedString LastSavePointName; // [0] (36 bytes)
		public FixedString BoyName; // [36|x24] (36 bytes)
		public FixedString DogName; // [72|x48] (36 bytes)

		public Chunk01 Chunk01; // [108|x6C] (2 bytes)
		public Chunk02 Chunk02; // [110|x6E] (26 bytes)
		public Chunk03 Chunk03; // [136|x88] (4 bytes)
		public Chunk04 Chunk04; // [140|x8C] (2 bytes)
		public Chunk05 Chunk05; // [142|x8E] (13 bytes)
		public Chunk06 Chunk06; // [155|x9B] (4 bytes)
		public Chunk07 Chunk07; // [159|x9F] (14 bytes)
		public Chunk08 Chunk08; // [173|xAD] (2 bytes)
		public Chunk09 Chunk09; // [175|xAF] (26 bytes)
		public Chunk10 Chunk10; // [201|xC9] (4 bytes)
		public Chunk11 Chunk11; // [205|xCD] (2 bytes)
		public Chunk12 Chunk12; // [207|xCF] (13 bytes)
		public Chunk13 Chunk13; // [220|xDC] (4 bytes)
		public Chunk14 Chunk14; // [224|xE0] (14 bytes)
		public Chunk15 Chunk15; // [238|xEE] (101 bytes)
		public Chunk16 Chunk16; // [339|x153] (162 bytes)
		public Chunk17 Chunk17; // [501|x1F5] (146 bytes)
		public Chunk18 Chunk18; // [647|x287] (92 bytes)
		public Chunk19 Chunk19; // [739|x2E3] (44 bytes)
		public Chunk20 Chunk20; // [783|x30F] (32 bytes)

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
// ReSharper disable InconsistentNaming

namespace RosettaStone.Savestate.Snes9x.SoE.Constants
{
	/// <summary>
	/// Known sizes of SoE's W-RAM buffer
	/// </summary>
	public class WramSizes
	{
		/// Size of the SRAM file
		public const int Wram = 8_184;
		
		/// <summary>Sizes of save slot buffers</summary>
		public class SaveSlot
		{
			public const int LastSavePointName = 36; // (x24) offset [0]
			public const int BoyName = 36; // (x24) offset [36|x24]
			public const int DogName = 36; // (x24) offset [72|x48]

			public const int Chunk01 = 2; // (x2) offset [108|x6C]
			public const int Chunk02 = 26; // (x1A) offset [110|x6E]
			public const int Chunk03 = 4; // (x4) offset [136|x88]
			public const int Chunk04 = 2; // (x2) offset [140|x8C]
			public const int Chunk05 = 13; // (xD) offset [142|x8E]
			public const int Chunk06 = 4; // (x4) offset [155|x9B]
			public const int Chunk07 = 14; // (xE) offset [159|x9F]
			public const int Chunk08 = 2; // (x2) offset [173|xAD]
			public const int Chunk09 = 26; // (x1A) offset [175|xAF]
			public const int Chunk10 = 4; // (x4) offset [201|xC9]
			public const int Chunk11 = 2; // (x2) offset [205|xCD]
			public const int Chunk12 = 13; // (xD) offset [207|xCF]
			public const int Chunk13 = 4; // (x4) offset [220|xDC]
			public const int Chunk14 = 14; // (xE) offset [224|xE0]
			public const int Chunk15 = 101; // (x65) offset [238|xEE]
			public const int Chunk16 = 162; // (xA2) offset [339|x153]
			public const int Chunk17 = 146; // (x92) offset [501|x1F5]
			public const int Chunk18 = 92; // (x5C) offset [647|x287]
			public const int Chunk19 = 44; // (x2C) offset [739|x2E3]
			public const int Chunk20 = 32; // (x20) offset [783|x30F]

			public const int AllChunks = Chunk01 + Chunk02 + Chunk03 + Chunk04 + Chunk05 +
										  Chunk06 + Chunk07 + Chunk08 + Chunk09 + Chunk10 +
										  Chunk11 + Chunk12 + Chunk13 + Chunk14 + Chunk15 +
										  Chunk16 + Chunk17 + Chunk18 + Chunk19 + Chunk20;

			public const int AllNonChunk = LastSavePointName + BoyName + DogName;

			public const int All = 815;
		}

		/// Size of the SRAM's unknown buffer
		public const int WramUnknown1 = 4_922;
	}
}
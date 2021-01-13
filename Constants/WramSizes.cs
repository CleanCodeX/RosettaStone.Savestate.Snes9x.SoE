// ReSharper disable InconsistentNaming

namespace RosettaStone.Savestate.Snes9x.SoE.Constants
{
	/// <summary>
	/// Known sizes of SoE's W-RAM buffer
	/// </summary>
	public class WramSizes
	{
		/// Size of the SRAM file
		public const int Wram = 8_192;
		
		/// <summary>Sizes of save slot buffers</summary>
		public class SaveSlot
		{
			public const int SaveSlotChecksum = 2; // (x2) offset [0]

			public const int LastSavePointName = 34; // (x24) offset [2]
			public const int Unknown1 = 2; // (x2) offset [36|x24]

			public const int BoyName = 34; // (x22) offset [38|x26]
			public const int Unknown2 = 2; // (x2) offset [40|x26]

			public const int DogName = 34; // (x22) offset [74|x26]
			public const int Unknown3 = 2; // (x2) offset [38|x26]

			public const int Chunk01 = 2; // (x2) offset [110|x6E]
			public const int Chunk02 = 26; // (x1A) offset [112|x70]
			public const int Chunk03 = 4; // (x4) offset [138|x8A]
			public const int Chunk04 = 2; // (x2) offset [142|x8E]
			public const int Chunk05 = 13; // (xD) offset [144|x90]
			public const int Chunk06 = 4; // (x4) offset [157|x9D]
			public const int Chunk07 = 14; // (xE) offset [161|xA1]
			public const int Chunk08 = 2; // (x2) offset [175|xAF]
			public const int Chunk09 = 26; // (x1A) offset [177|xB1]
			public const int Chunk10 = 4; // (x4) offset [203|xCB]
			public const int Chunk11 = 2; // (x2) offset [207|xCF]
			public const int Chunk12 = 13; // (xD) offset [209|xD1]
			public const int Chunk13 = 4; // (x4) offset [222|xDE]
			public const int Chunk14 = 14; // (xE) offset [226|xE2]
			public const int Chunk15 = 101; // (x65) offset [240|xF0]
			public const int Chunk16 = 162; // (xA2) offset [341|x155]
			public const int Chunk17 = 146; // (x92) offset [503|x1F7]
			public const int Chunk18 = 92; // (x5C) offset [649|x289]
			public const int Chunk19 = 44; // (x2C) offset [741|x2E5]
			public const int Chunk20 = 32; // (x20) offset [785|x311]

			public const int AllChunks = Chunk01 + Chunk02 + Chunk03 + Chunk04 + Chunk05 +
										  Chunk06 + Chunk07 + Chunk08 + Chunk09 + Chunk10 +
										  Chunk11 + Chunk12 + Chunk13 + Chunk14 + Chunk15 +
										  Chunk16 + Chunk17 + Chunk18 + Chunk19 + Chunk20;

			public const int AllNonChunk = SaveSlotChecksum + LastSavePointName + Unknown1 + BoyName + Unknown2 + DogName + Unknown3;

			public const int All = 817;
		}

		/// Size of the SRAM's unknown buffer
		public const int WramUnknown1 = 4_922;
	}
}
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
			public const int BoyAndDogName = 72; // (x24) 

			public const int Chunk01 = 2; // (x2) 
			public const int Chunk02 = 24; // (x18) 
			public const int Chunk03 = 6; // (x6) 
			public const int Chunk04 = 2; // (x2) 
			public const int Chunk05 = 13; // (xD) 
			public const int Chunk06 = 4; // (x4) 
			public const int Chunk07 = 14; // (xE) 
			public const int Chunk08 = 2; // (x2) 
			public const int Chunk09 = 24; // (x18) 
			public const int Chunk10 = 6; // (x6) 
			public const int Chunk11 = 2; // (x2) 
			public const int Chunk12 = 13; // (xD)
			public const int Chunk13 = 4; // (x4) 
			public const int Chunk14 = 14; // (xE)
			public const int Chunk15 = 101; // (x65)
			public const int Chunk16 = 162; // (xA2) 
			public const int Chunk17 = 146; // (x92)
			public const int Chunk18 = 92; // (x5C) 
			public const int Chunk19 = 44; // (x2C) 
			public const int Chunk20 = 32; // (x20)

			public const int AllChunks = Chunk01 + Chunk02 + Chunk03 + Chunk04 + Chunk05 +
										  Chunk06 + Chunk07 + Chunk08 + Chunk09 + Chunk10 +
										  Chunk11 + Chunk12 + Chunk13 + Chunk14 + Chunk15 +
										  Chunk16 + Chunk17 + Chunk18 + Chunk19 + Chunk20;

			public const int AllNonChunk = LastSavePointName + BoyAndDogName;

			public const int All = 815;
		}

		/// Size of the SRAM's unknown buffer
		public const int WramUnknown1 = 4_922;
	}
}
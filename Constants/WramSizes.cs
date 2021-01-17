// ReSharper disable InconsistentNaming

// ReSharper disable MemberHidesStaticFromOuterClass
namespace RosettaStone.Savestate.Snes9x.SoE.Constants
{
	/// <summary>
	/// Known sizes of SoE's W-RAM buffer
	/// </summary>
	public class WramSizes
	{
		public const int Unknown1 = 2_613;
		/// Size of the SRAM file
		public const int SramArea = 17_840;
		public const int Unknown2 = 110_619;

		public const int All = 128 * 1024;

		public const bool IsValid = Unknown1 + SramArea + Unknown2 == All;

		/// <summary>Sizes of save slot buffers</summary>
		public class Sram
		{
			public const int BoyAndDogName = 72; // (x24) 

			public const int Chunk1 = 2; // (x2) 
			public const int Chunk2 = 13; // (xD) 
			public const int Chunk3 = 4; // (x4) 
			public const int Chunk4 = 2; // (x2) 
			public const int Chunk5 = 13; // (xD)
			public const int Chunk6 = 4; // (x4) 
			public const int Chunk7 = 101; // (x65)

			public const int Chunk8 = 146; // (x92)
			public const int Chunk9 = 92; // (x5C) 
			public const int Chunk10 = 44; // (x2C) 
			public const int Chunk11 = 32; // (x20)

			public const int Chunk12 = 162; // (xA2) 

			public const int Chunk13 = 2; // (x2) 
			public const int Chunk14 = 24; // (x18) 
			public const int Chunk15 = 6; // (x6) 
			
			public const int Chunk16 = 14; // (xE) 
			public const int Chunk17 = 2; // (x2) 
			public const int Chunk18 = 24; // (x18) 
			public const int Chunk19 = 6; // (x6) 
			public const int Chunk20 = 14; // (xE)

			public const int AllChunks = Chunk1 + Chunk2 + Chunk3 + Chunk4 + Chunk5 +
			                             Chunk6 + Chunk7 + Chunk8 + Chunk9 + Chunk10 +
			                             Chunk11 + Chunk12 + Chunk13 + Chunk14 + Chunk15 +
			                             Chunk16 + Chunk17 + Chunk18 + Chunk19 + Chunk20;

			public const int AllNonChunk = BoyAndDogName;

			public const int Unknown1 = 8; // (x)
			public const int Unknown2 = 4; // (x)
			public const int Unknown3 = 34; // (x)
			public const int Unknown4 = 8; // (x)
			public const int Unknown5 = 4; // (x)
			public const int Unknown6 = 28; // (x)
			public const int Unknown7 = 5873; // (x16F1)
			public const int Unknown8 = 21; // (x)
			public const int Unknown9 = 6; // (x)
			public const int Unknown10 = 390; // (x)
			public const int Unknown11 = 2591; // (xA1F)
			public const int Unknown12 = 7871; // (x1EBF)
			public const int Unknown13 = 26; // (x)
			public const int Unknown14 = 60; // (x)
			public const int Unknown15 = 42; // (x)
			public const int Unknown16 = 26; // (x)
			public const int Unknown17 = 60; // (x)

			public const int AllUnknown = Unknown1 + Unknown2 + Unknown3 + Unknown4 + Unknown5 + 
										  Unknown6 + Unknown7 + Unknown8 + Unknown9 + Unknown10 +
			                              Unknown11 + Unknown12 + Unknown13 + Unknown14 + Unknown15 +
			                              Unknown16 + Unknown17;

			public const int All = 17_840;

			public const int UnknownPercentage = AllUnknown * 100 / All;
			public const int ChunkPercentage = AllChunks * 100 / All;
			public const int KnownPercentage = (AllChunks + AllNonChunk) * 100 / All;
			
			public const bool IsValid = AllChunks + AllNonChunk + AllUnknown == All;
		}
	}
}
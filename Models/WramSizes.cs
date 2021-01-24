namespace RosettaStone.Savestate.Snes9x.SoE.Models
{
	/// <summary>
	/// Known sizes of SoE's W-RAM buffer
	/// </summary>
	public class WramSizes
	{
		public const int All = 128 * 1024;
		public const bool IsValid = AllChunks + AllUnknown == All;

		#region Chunks

		public const int Chunk1 = 72; // (x24) 

		public const int Chunk2 = 2; // (x2) 
		public const int Chunk3 = 13; // (xD) 
		public const int Chunk4 = 4; // (x4) 
		public const int Chunk5 = 2; // (x2) 
		public const int Chunk6 = 13; // (xD)
		public const int Chunk7 = 4; // (x4) 
		public const int Chunk8 = 101; // (x65)

		public const int Chunk9 = 146; // (x92)
		public const int Chunk10 = 92; // (x5C) 
		public const int Chunk11 = 44; // (x2C) 
		public const int Chunk12 = 32; // (x20)

		public const int Chunk13 = 162; // (xA2) 

		public const int Chunk14 = 2; // (x2) 
		public const int Chunk15 = 24; // (x18) 
		public const int Chunk16 = 6; // (x6) 

		public const int Chunk17 = 14; // (xE) 
		public const int Chunk18 = 2; // (x2) 
		public const int Chunk19 = 24; // (x18) 
		public const int Chunk20 = 6; // (x6) 
		public const int Chunk21 = 14; // (xE)

		public const int AllChunks = Chunk1 + Chunk2 + Chunk3 + Chunk4 + Chunk5 +
									 Chunk6 + Chunk7 + Chunk8 + Chunk9 + Chunk10 +
									 Chunk11 + Chunk12 + Chunk13 + Chunk14 + Chunk15 +
									 Chunk16 + Chunk17 + Chunk18 + Chunk19 + Chunk20 +
									 Chunk21;

		public const int ChunkPercentage = AllChunks * 100 / All;

		#endregion

		#region Unknowns

		public const int Unknown1 = 2_613;

		#region S-RAM area
		public const int Unknown2 = 8; // (x)
		public const int Unknown3 = 4; // (x)
		public const int Unknown4 = 34; // (x)
		public const int Unknown5 = 8; // (x)
		public const int Unknown6 = 4; // (x)
		public const int Unknown7 = 28; // (x)
		public const int Unknown8 = 5873; // (x16F1)
		public const int Unknown9 = 21; // (x)
		public const int Unknown10 = 6; // (x)
		public const int Unknown11 = 390; // (x)
		public const int Unknown12 = 2591; // (xA1F)
		public const int Unknown13 = 7871; // (x1EBF)
		public const int Unknown14 = 26; // (x)
		public const int Unknown15 = 60; // (x)
		public const int Unknown16 = 42; // (x)
		public const int Unknown17 = 26; // (x)
		public const int Unknown18 = 60; // (x)
#endregion

		public const int Unknown19 = 110_619;

		public const int AllUnknown = Unknown1 + Unknown2 + Unknown3 + Unknown4 + Unknown5 +
		                              Unknown6 + Unknown7 + Unknown8 + Unknown9 + Unknown10 +
		                              Unknown11 + Unknown12 + Unknown13 + Unknown14 + Unknown15 +
		                              Unknown16 + Unknown17 + Unknown18 + Unknown19;

		public const int UnknownPercentage = AllUnknown * 100 / All;

		#endregion
	}
}
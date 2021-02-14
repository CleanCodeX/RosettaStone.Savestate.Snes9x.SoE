// ReSharper disable InconsistentNaming

namespace WRAM.Snes9x.SoE.Models
{
	/// <summary>
	/// Known offsets of SoE's W-RAM format
	/// </summary>
	public class WramOffsets
	{
		public const int Unknown1 = 0;
		public const int SramArea = 2613; // [xA35];
		public const int Unknown19 = 20_453; // [x4FE5]

		public const int Chunk05 = 2613; // [xA35] (2 bytes)
		public const int Chunk06 = 2623; // [xA3F] (13 bytes)
		public const int Chunk07 = 2640; // [xA50] (4 bytes)
		public const int Chunk12 = 2687; // [xA7F] (2 bytes)
		public const int Chunk13 = 2697; // [xA89] (13 bytes)
		public const int Chunk14 = 2714; // [xA9A] (4 bytes)
		public const int Chunk16 = 2746; // [xABA] (101 bytes)
		public const int Chunk01 = 8720; // [x2210] (72 bytes)

		public const int Chunk18 = 8792; // [x2258] (146 bytes)
		public const int Chunk19 = 8959; // [x22FF] (92 bytes)
		public const int Chunk20 = 9057; // [x2361] (44 bytes)
		public const int Chunk21 = 9491; // [x2513] (32 bytes)

		public const int Chunk17 = 12114; // [x2F52] (162 bytes)

		public const int Chunk02 = 20147; // [x4EB3] (2 bytes)
		public const int Chunk03 = 20175; // [x4ECF] (24 bytes)

		public const int Chunk04 = 20259; // [x4F23] (6 bytes)
		public const int Chunk08 = 20265; // [x4F29] (14 bytes)
		public const int Chunk09 = 20321; // [x4F61] (2 bytes)
		public const int Chunk10 = 20349; // [x4F7D] (24 bytes)
		public const int Chunk11 = 20433; // [x4FD1] (6 bytes)
		public const int Chunk15 = 20439; // [x4FD7] (14 bytes)
	}
}
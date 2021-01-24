// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using System.Linq;
using IO.Extensions;
using ChunkSizes = SRAM.SoE.Models.SramSizes.SaveSlot;

namespace WRAM.Snes9x.SoE.Models
{
	/// <summary>
	/// Known offsets of SoE's W-RAM format
	/// </summary>
	public class WramOffsets
	{
		public static readonly Dictionary<int, (int SramOffset, int Size)> SramMappings = new()
		{
			[Chunk01] = (38, ChunkSizes.Chunk01), // [x26]

			[Chunk02] = (110, ChunkSizes.Chunk02), // [x6E] (2)
			[Chunk03] = (112, ChunkSizes.Chunk03), // [x70] (24)
			[Chunk04] = (136, ChunkSizes.Chunk04), // [x88] (6)
			[Chunk05] = (142, ChunkSizes.Chunk05), // [x8E] (2)
			[Chunk06] = (144, ChunkSizes.Chunk06), // [x90] (13) 
			[Chunk07] = (157, ChunkSizes.Chunk07), // [x9D] (4)
			[Chunk08] = (161, ChunkSizes.Chunk08), // [xA1] (14)

			[Chunk09] = (175, ChunkSizes.Chunk09), // [xAF] (2)
			[Chunk10] = (177, ChunkSizes.Chunk10), // [xB1] (24)
			[Chunk11] = (201, ChunkSizes.Chunk11), // [xC9] (6)
			[Chunk12] = (207, ChunkSizes.Chunk12), // [xCF] (2)
			[Chunk13] = (209, ChunkSizes.Chunk13), // [xD1] (13)
			[Chunk14] = (222, ChunkSizes.Chunk14), // [xDE] (4)
			[Chunk15] = (226, ChunkSizes.Chunk15), // [xE2] (14)

			[Chunk16] = (240, ChunkSizes.Chunk16), // [xF0] (101)

			[Chunk17] = (341, ChunkSizes.Chunk17), // [x155] (162)

			[Chunk18] = (503, ChunkSizes.Chunk18), // [x1F7] (146)
			[Chunk19] = (649, ChunkSizes.Chunk19), // [x289] (92)
			[Chunk20] = (741, ChunkSizes.Chunk20), // [x2E5] (44)
			[Chunk21] = (785, ChunkSizes.Chunk21), // [x311] (32)
		};

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

		public static string? GetNameFromOffset(int offset)
		{
			var constants = typeof(WramOffsets).GetPublicConstants<int>().OrderBy(e => e.Value);

			return (from kvp in constants
				where offset >= kvp.Value
				select kvp.Key).LastOrDefault();
		}
	}
}
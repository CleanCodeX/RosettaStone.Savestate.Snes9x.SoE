// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using System.Linq;
using SramCommons.Extensions;

namespace RosettaStone.Savestate.Snes9x.SoE.Models
{
	/// <summary>
	/// Known offsets of SoE's W-RAM format
	/// </summary>
	public class WramOffsets
	{
		public const int Unknown1 = 0;
		public const int SramArea = 2613; // [xA35];
		public const int Unknown19 = 20_453; // [x4FE5]

		public class Sram
		{
			public static readonly Dictionary<int, (int SramOffset, int Size)> WramSramMappings = new()
			{
				[Chunk1] = (38, WramSizes.Chunk1), // [x26]

				[Chunk2] = (110, WramSizes.Chunk2), // [x6E] (2)
				[Chunk3] = (112, WramSizes.Chunk3), // [x70] (24)
				[Chunk4] = (136, WramSizes.Chunk4), // [x88] (6)
				[Chunk5] = (142, WramSizes.Chunk5), // [x8E] (2)
				[Chunk6] = (144, WramSizes.Chunk6), // [x90] (13) 
				[Chunk7] = (157, WramSizes.Chunk7), // [x9D] (4)
				[Chunk8] = (161, WramSizes.Chunk8), // [xA1] (14)

				[Chunk9] = (175, WramSizes.Chunk9), // [xAF] (2)
				[Chunk10] = (177, WramSizes.Chunk10), // [xB1] (24)
				[Chunk11] = (201, WramSizes.Chunk11), // [xC9] (6)
				[Chunk12] = (207, WramSizes.Chunk12), // [xCF] (2)
				[Chunk13] = (209, WramSizes.Chunk13), // [xD1] (13)
				[Chunk14] = (222, WramSizes.Chunk14), // [xDE] (4)
				[Chunk15] = (226, WramSizes.Chunk15), // [xE2] (14)

				[Chunk16] = (240, WramSizes.Chunk16), // [xF0] (101)

				[Chunk17] = (341, WramSizes.Chunk17), // [x155] (162)

				[Chunk18] = (503, WramSizes.Chunk18), // [x1F7] (146)
				[Chunk19] = (649, WramSizes.Chunk19), // [x289] (92)
				[Chunk20] = (741, WramSizes.Chunk20), // [x2E5] (44)
				[Chunk21] = (785, WramSizes.Chunk21), // [x311] (32)
			};

			public const int Chunk2 = 2613; // [xA35] (2 bytes)
			public const int Chunk3 = 2623; // [xA3F] (13 bytes)
			public const int Chunk4 = 2640; // [xA50] (4 bytes)
			public const int Chunk5 = 2687; // [xA7F] (2 bytes)
			public const int Chunk6 = 2697; // [xA89] (13 bytes)
			public const int Chunk7 = 2714; // [xA9A] (4 bytes)
			public const int Chunk8 = 2746; // [xABA] (101 bytes)
			public const int Chunk1 = 8720; // [x2210] (72 bytes)

			public const int Chunk9 = 8792; // [x2258] (146 bytes)
			public const int Chunk10 = 8959; // [x22FF] (92 bytes)
			public const int Chunk11 = 9057; // [x2361] (44 bytes)
			public const int Chunk12 = 9491; // [x2513] (32 bytes)

			public const int Chunk13 = 12114; // [x2F52] (162 bytes)

			public const int Chunk14 = 20147; // [x4EB3] (2 bytes)
			public const int Chunk15 = 20175; // [x4ECF] (24 bytes)
			public const int Chunk16 = 20259; // [x4F23] (6 bytes)

			public const int Chunk17 = 20265; // [x4F29] (14 bytes)
			public const int Chunk18 = 20321; // [x4F61] (2 bytes)
			public const int Chunk19 = 20349; // [x4F7D] (24 bytes)
			public const int Chunk20 = 20433; // [x4FD1] (6 bytes)
			public const int Chunk21 = 20439; // [x4FD7] (14 bytes)

			public static string? GetNameFromOffset(int offset)
			{
				var constants = typeof(Sram).GetPublicConstants<int>().OrderBy(e => e.Value);

				return (from kvp in constants
					where offset >= kvp.Value
					select kvp.Key).LastOrDefault();
			}
		}
	}
}
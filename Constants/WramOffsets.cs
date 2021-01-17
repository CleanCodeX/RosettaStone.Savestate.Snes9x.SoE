// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using System.Linq;
using SramCommons.Extensions;

namespace RosettaStone.Savestate.Snes9x.SoE.Constants
{
	/// <summary>
	/// Known offsets of SoE's W-RAM format
	/// </summary>
	public class WramOffsets
	{
		public const int Unknown1 = 0;
		public const int SramArea = 2613; // [xA35];
		public const int Unknown2 = 20_453; // [x4FE5]

		public class Sram
		{
			public static readonly Dictionary<int, (int SramOffset, int Size)> WramSramMappings = new()
			{
				[Chunk1] = (142, WramSizes.Sram.Chunk1), // [x8E] 
				[Chunk2] = (144, WramSizes.Sram.Chunk2), // [x90] 
				[Chunk3] = (157, WramSizes.Sram.Chunk3), // [x9D] 
				[Chunk4] = (207, WramSizes.Sram.Chunk4), // [xCF] 
				[Chunk5] = (209, WramSizes.Sram.Chunk5), // [xD1]
				[Chunk6] = (222, WramSizes.Sram.Chunk6), // [xDE]
				[Chunk7] = (240, WramSizes.Sram.Chunk7), // [xF0]
				[BoyAndDogName] = (38, WramSizes.Sram.BoyAndDogName), // [x26]

				[Chunk8] = (503, WramSizes.Sram.Chunk8), // [x1F7]
				[Chunk9] = (649, WramSizes.Sram.Chunk9), // [x289] 
				[Chunk10] = (741, WramSizes.Sram.Chunk10), // [x2E5] 
				[Chunk11] = (785, WramSizes.Sram.Chunk11), // [x311]

				[Chunk12] = (341, WramSizes.Sram.Chunk12), // [x155]

				[Chunk13] = (110, WramSizes.Sram.Chunk13), // [x6E]
				[Chunk14] = (112, WramSizes.Sram.Chunk14), // [x70] 
				[Chunk15] = (136, WramSizes.Sram.Chunk15), // [x88] 

				[Chunk16] = (161, WramSizes.Sram.Chunk16), // [xA1] 
				[Chunk17] = (175, WramSizes.Sram.Chunk17), // [xAF] 
				[Chunk18] = (177, WramSizes.Sram.Chunk18), // [xB1] 
				[Chunk19] = (201, WramSizes.Sram.Chunk19), // [xC9] 
				[Chunk20] = (226, WramSizes.Sram.Chunk20), // [xE2]
			};

			public const int Chunk1 = 2613; // [xA35] (2 bytes)
			public const int Chunk2 = 2623; // [xA3F] (13 bytes)
			public const int Chunk3 = 2640; // [xA50] (4 bytes)
			public const int Chunk4 = 2687; // [xA7F] (2 bytes)
			public const int Chunk5 = 2697; // [xA89] (13 bytes)
			public const int Chunk6 = 2714; // [xA9A] (4 bytes)
			public const int Chunk7 = 2746; // [xABA] (101 bytes)
			public const int BoyAndDogName = 8720; // [x2210] (36 bytes)

			public const int Chunk8 = 8792; // [x2258] (146 bytes)
			public const int Chunk9 = 8959; // [x22FF] (92 bytes)
			public const int Chunk10 = 9057; // [x2361] (44 bytes)
			public const int Chunk11 = 9491; // [x2513] (32 bytes)

			public const int Chunk12 = 12114; // [x2F52] (162 bytes)

			public const int Chunk13 = 20147; // [x4EB3] (2 bytes)
			public const int Chunk14 = 20175; // [x4ECF] (24 bytes)
			public const int Chunk15 = 20259; // [x4F23] (6 bytes)

			public const int Chunk16 = 20265; // [x4F29] (14 bytes)
			public const int Chunk17 = 20321; // [x4F61] (2 bytes)
			public const int Chunk18 = 20349; // [x4F7D] (24 bytes)
			public const int Chunk19 = 20433; // [x4FD1] (6 bytes)
			public const int Chunk20 = 20439; // [x4FD7] (14 bytes)

			// Unknown
			public const int LastSavePointName = -1; // (36 bytes)

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
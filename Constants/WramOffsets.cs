// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using System.Linq;
using SramCommons.Extensions;
using Sizes = RosettaStone.Savestate.Snes9x.SoE.Constants.WramSizes.SaveSlot;

namespace RosettaStone.Savestate.Snes9x.SoE.Constants
{
	/// <summary>
	/// Known offsets of SoE's W-RAM format
	/// </summary>
	public class WramOffsets
	{
		public const int WramSramOffset = 8682; // [x21EA];

		/// base offset of the game data in the S-RAM
		public const int FirstSaveSlot = 0;

		public class SaveSlot
		{
			public static readonly Dictionary<int, (int SOffset, int Size)> WramSramMappings = new()
			{
				[BoyAndDogName] = (38, Sizes.BoyAndDogName),
				[Chunk01] = (110, Sizes.Chunk01), // (x2) 
				[Chunk02] = (112, Sizes.Chunk02), // (x18) 
				[Chunk03] = (136, Sizes.Chunk03), // (x6) 
				[Chunk04] = (142, Sizes.Chunk04), // (x2) 
				[Chunk05] = (144, Sizes.Chunk05), // (xD) 
				[Chunk06] = (157, Sizes.Chunk06), // (x4) 
				[Chunk07] = (161, Sizes.Chunk07), // (xE) 
				[Chunk08] = (175, Sizes.Chunk08), // (x2) 
				[Chunk09] = (177, Sizes.Chunk09), // (x18) 
				[Chunk10] = (201, Sizes.Chunk10), // (x6) 
				[Chunk11] = (207, Sizes.Chunk11), // (x2) 
				[Chunk12] = (209, Sizes.Chunk12), // (xD)
				[Chunk13] = (222, Sizes.Chunk13), // (x4)
				[Chunk14] = (226, Sizes.Chunk14), // (xE)
				[Chunk15] = (240, Sizes.Chunk15), // (x65)
				[Chunk16] = (341, Sizes.Chunk16), // (xA2) 
				[Chunk17] = (503, Sizes.Chunk17), // (x92)
				[Chunk18] = (649, Sizes.Chunk18), // (x5C) 
				[Chunk19] = (741, Sizes.Chunk19), // (x2C) 
				[Chunk20] = (785, Sizes.Chunk20) // (x20)
			};

			public const int LastSavePointName = 0; // [0] (36 bytes)
			public const int BoyAndDogName = 8720; // [x2210] (36 bytes)

			public const int Chunk01 = 20147; // [x4EB3] (2 bytes)
			public const int Chunk02 = 20175; // [x4ECF] (24 bytes)
			public const int Chunk03 = 20259; // [x4F23] (6 bytes)
			public const int Chunk04 = 2613; // [xA35] (2 bytes)
			public const int Chunk05 = 2623; // [xA3F] (13 bytes)
			public const int Chunk06 = 2640; // [xA50] (4 bytes)
			public const int Chunk07 = 20265; // (14 bytes)
			public const int Chunk08 = 20321; // [x4F61] (2 bytes)
			public const int Chunk09 = 20349; // [x4F7D] (24 bytes)
			public const int Chunk10 = 20433; // [x4FD1] (6 bytes)
			public const int Chunk11 = 2687; // [xA7F] (2 bytes)
			public const int Chunk12 = 2697; // [xA89] (13 bytes)
			public const int Chunk13 = 2714; // [xA9A] (4 bytes)
			public const int Chunk14 = 20439; // (14 bytes)
			public const int Chunk15 = 2746; // [xABA] (101 bytes)
			public const int Chunk16 = 12114; // [x2F52] (162 bytes)
			public const int Chunk17 = 8792; // [x2258] (146 bytes)
			public const int Chunk18 = 8959; // [x22FF] (92 bytes)
			public const int Chunk19 = 9057; // [x2361] (44 bytes)
			public const int Chunk20 = 9491; // [x2513] (32 bytes)

			public static string? GetNameFromOffset(int offset)
			{
				var constants = typeof(SaveSlot).GetPublicConstants<int>().OrderBy(e => e.Value);

				return (from kvp in constants
					where offset >= kvp.Value
					select kvp.Key).LastOrDefault();
			}
		}

		public const int WramUnknown1 = 3_270;
	}
}
// ReSharper disable InconsistentNaming

using System.Linq;
using SramCommons.Extensions;

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
			public static string? GetNameFromOffset(int offset)
			{
				var constants = typeof(SaveSlot).GetPublicConstants<int>().OrderBy(e => e.Value);

				return (from kvp in constants 
					where offset >= kvp.Value
						select kvp.Key).LastOrDefault();
			}

			public const int LastSavePointName = 0; // [0] (36 bytes)
			public const int BoyName = 36; // [x24] (36 bytes)
			public const int DogName = 72; // [x48] (36 bytes)

			public const int Chunk01 = 108; // [x6C] (2 bytes)
			public const int Chunk02 = 110; // [x6E] (26 bytes)
			public const int Chunk03 = 136; // [x88] (4 bytes)
			public const int Chunk04 = 140; // [x8C] (2 bytes)
			public const int Chunk05 = 142; // [x8E] (13 bytes)
			public const int Chunk06 = 155; // [x9B] (4 bytes)
			public const int Chunk07 = 159; // [x9F] (14 bytes)
			public const int Chunk08 = 173; // [xAD] (2 bytes)
			public const int Chunk09 = 175; // [xAF] (26 bytes)
			public const int Chunk10 = 201; // [xC9] (4 bytes)
			public const int Chunk11 = 205; // [xCD] (2 bytes)
			public const int Chunk12 = 207; // [xCF] (13 bytes)
			public const int Chunk13 = 220; // [xDC] (4 bytes)
			public const int Chunk14 = 224; // [xE0] (14 bytes)
			public const int Chunk15 = 238; // [xEE] (101 bytes)
			public const int Chunk16 = 339; // [x153] (162 bytes)
			public const int Chunk17 = 501; // [x1F5] (146 bytes)
			public const int Chunk18 = 647; // [x287] (92 bytes)
			public const int Chunk19 = 739; // [x2E3] (44 bytes)
			public const int Chunk20 = 783; // [x30F] (32 bytes)
		}

		public const int WramUnknown1 = 3_270;
	}
}
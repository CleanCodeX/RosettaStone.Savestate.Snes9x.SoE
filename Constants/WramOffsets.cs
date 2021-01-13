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
		public const int FirstSaveSlot = 2;
		public const int WramChecksum = 0;

		public class SaveSlot
		{
			public static string? GetNameFromOffset(int offset)
			{
				var constants = typeof(SaveSlot).GetPublicConstants<int>().OrderBy(e => e.Value);

				return (from kvp in constants 
					where offset >= kvp.Value
						select kvp.Key).LastOrDefault();
			}

			public const int SaveSlotChecksum = 0; // (2 bytes)

			public const int LastSavePointName = 2; // (34 bytes)
			public const int Unknown1 = 36; // [x24] (2 bytes)

			public const int BoyName = 38; // [x26] (34 bytes)
			public const int Unknown2 = 72; // [x48] (2 bytes)

			public const int DogName = 74; // [x4A] (34 bytes)
			public const int Unknown3 = 108; // [x6C] (2 bytes)

			public const int Chunk01 = 110; // [x6E] (2 bytes)
			public const int Chunk02 = 112; // [x70] (26 bytes)
			public const int Chunk03 = 138; // [x8A] (4 bytes)
			public const int Chunk04 = 142; // [x8E] (2 bytes)
			public const int Chunk05 = 144; // [x90] (13 bytes)
			public const int Chunk06 = 157; // [x9D] (4 bytes)
			public const int Chunk07 = 161; // [xA1] (14 bytes)
			public const int Chunk08 = 175; // [xAf] (2 bytes)
			public const int Chunk09 = 177; // [xB1] (26 bytes)
			public const int Chunk10 = 203; // [xCB] (4 bytes)
			public const int Chunk11 = 207; // [xCF] (2 bytes)
			public const int Chunk12 = 209; // [xD1] (13 bytes)
			public const int Chunk13 = 222; // [xDE] (4 bytes)
			public const int Chunk14 = 226; // [xE2] (14 bytes)
			public const int Chunk15 = 240; // [xF0] (101 bytes)
			public const int Chunk16 = 341; // [x155] (162 bytes)
			public const int Chunk17 = 503; // [x1F7] (146 bytes)
			public const int Chunk18 = 649; // [x289] (92 bytes)
			public const int Chunk19 = 741; // [x2E5] (44 bytes)
			public const int Chunk20 = 785; // [x311] (32 bytes)
		}

		public const int WramUnknown1 = 3_270;
	}
}
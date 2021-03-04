using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;
using SoE;
using SoE.Models.Enums;
using SoE.Models.Enums.Unknown;
using SoE.Models.Structs;
using SoE.Models.Structs.Unknown;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Alchemies_Charms_Spots_Weapons
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[HasOffsetMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk18
	{
		public const int Size = 146;

		// Alchemies
		public Alchemies Alchemies; // [503|x1F7] (6 bytes)

		// Unknown 14
		public Unknown14 Unknown14; // [509|x1FB] (2 bytes) 
		public byte Unknown14B; // [511|x1FD] (1 byte) 

		// Charms
		public CharmsAndRareItems CharmsAndRareItems; // [512|x200] (4 bytes)

		public GourdSpots GourdSpots; // [516|x204] (4 bytes)

		public IngredientSniffSpots IngredientSniffSpots; // [520|x208] (89 bytes)

		// Unknown 15 (Ingredients sniff spots?)
		public Unknown15 Unknown15; // [609|x261] (24 bytes)

		// Weapons
		public Weapons Weapons; // [633|x279] (2 bytes)

		// Unknown 16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown16A)]
		public byte[] Unknown16A; // [635|x27B] (4 bytes) 

		public Unknown16B Unknown16B; // [639|x27F] (4 bytes)

		public Unknown16C Unknown16C; // [643|x283] (6 bytes) 
	}
}
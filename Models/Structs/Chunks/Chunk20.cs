using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;
using SoE;
using SoE.Models.Enums;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// LastLanding_CurrentWeapon
	/// </summary>
	/// <remarks><see cref="Size"/> W-RAM [$7E:235D23A0]</remarks>
	[HasOffsetMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk20
	{
		public const int Size = 44;

		public UInt16 Unknown17C; // [741|x2DD] [$7E:235D]

		public EquippedWeapon CurrentEquippedWeapon;// [743|x2E7] [$7E:235F] (2 bytes)

		public UInt16 Unknown17D; // [745|x2E9]

		public DogAppearance DogAppearance; // [747|x2EB] [$7E:2363] (2 bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown17E)]
		public byte[] Unknown17E; // [749|x2ED] (16 bytes)

		public LandingLocation LastLandingLocation; // [765|x2FD] [$7E:237B] (2 byte)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown17F)]
		public byte[] Unknown17F; // [767|x2FF] (14 bytes) 

		// ID of prize you're currently retrieving
		public UInt16 PrizeId; // [781|x30D] [$7E:2391] 

		// Quantity of prize you're currently retrieving  (seems to be quickly decremented to 1, though)
		public UInt16 PrizeQuantity; // [783|x30F] [$7E:2393] 
	}
}
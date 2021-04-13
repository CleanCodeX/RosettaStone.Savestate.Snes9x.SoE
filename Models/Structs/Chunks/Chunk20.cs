using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;
using SoE;
using SoE.Models.Enums;
using SoE.Models.Structs;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// CurrentWeapon_LastLanding
	/// </summary>
	/// <remarks><see cref="Size"/> W-RAM [$7E:235D23A0]</remarks>
	[HasOffsetMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk20
	{
		public const int Size = 44;

		public UInt16 UnknownFireEyesState1; // [741|x2E5] [$7E:2361]

		public EquippedWeapon CurrentEquippedWeapon;// [743|x2E7] [$7E:235F] (2 bytes)

		public UInt16 Unknown17D; // [745|x2E9]

		public DogAppearance DogAppearance; // [747|x2EB] [$7E:2363] (2 bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown17E1)]
		public byte[] Unknown17E1; // [749|x2ED] (4 bytes)

		public ColorCode AlarmCode; // [753|x2F1] [$7E:236D] (6 bytes)
		public ColorCode SecretCode; // [759|x2F7] [$7E:2373] (6 bytes)

		public UInt16 Unknown17E2; // [765|x2FD] 

		public LandingLocation LastLandingLocation; // [767|x2FF] [$7E:237B] (2 bytes)
		public LandingLocation NewLandingLocation; // [769|x2301] [$7E:237D] (2 bytes)

		public SandwhirlProgress SandwhirlProgress;  // [771|x303] [$7E:237F] (2 bytes)	
		public Coordinates DogTeleportationCoordinates; // [773|x305] [$7E:2381] (4 bytes)		
		public Coordinates BoyTeleportationCoordinates; // [777|x309] [$7E:2385] (4 bytes)		

		// ID of prize you're currently retrieving
		public UInt16 PrizeId; // [781|x30D] [$7E:2391] 

		// Quantity of prize you're currently retrieving  (seems to be quickly decremented to 1, though)
		public UInt16 PrizeQuantity; // [783|x30F] [$7E:2393] 
	}
}
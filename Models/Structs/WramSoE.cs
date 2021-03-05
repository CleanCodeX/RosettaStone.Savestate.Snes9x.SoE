using System;
using System.Runtime.InteropServices;
using WRAM.Snes9x.SoE.Models.Structs.Chunks;

// ReSharper disable BuiltInTypeReferenceStyle

namespace WRAM.Snes9x.SoE.Models.Structs
{
	/// <summary>
	/// W-RAM format of SoE
	/// </summary>
	/// <remarks>128 * 1024 bytes (128 KiB)</remarks>
	/// <remarks>For W-RAM Offsets [$7E:XXXX] see "https://datacrystal.romhacking.net/wiki/Secret_of_Evermore:RAM_map"</remarks>
	[StructLayout(LayoutKind.Sequential, Pack = 1)] 
	public struct WramSoE
	{
		// Unknown1
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown1)]
		public byte[] Unknown1; // [0] (2613 bytes)

		#region S-RAM Area Offset [2613|xA35] (17_840 bytes)

		// BoyMaxHp
		public Chunk05 BoyMaxHp; // [xA35|2613] [$7E:4EB3] (2 bytes) 

		public UInt16 Unknown2A; // [xA37|2615] 
		public UInt16 CurrentWeaponChargingLevel; // [2617|xA39] [$7E:4EB7]
		public UInt16 Unknown2B; // [xA3B|2619] 
		public UInt16 Unknown2C; // [xA3D|2621] 

		// BoyStats1
		public Chunk06 BoyStats1; // [xA3F|2623] [$7E:4ECF-4EE6] (13 bytes) 

		// Unknown3
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown3)]
		public byte[] Unknown3; // [xA4C|2636] (4 bytes)

		// BoyLevel
		public Chunk07 BoyLevel; // [xA50|2640] (4 bytes)

		// Unknown4
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown4)]
		public byte[] Unknown4; // [xA54|2644] (34 bytes)

		// DogMaxHp
		public Chunk12 DogMaxHp; // [xA7F|2687] (2 bytes)

		// Unknown5
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown5)]
		public byte[] Unknown5; // [xA81|2689] (8 bytes)

		// DogStats1
		public Chunk13 DogStats1; // [xA89|2697] (13 bytes)

		// Unknown6
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown6)]
		public byte[] Unknown6; // [xA96|2710] (4 bytes)

		// DogLevel
		public Chunk14 DogLevel; // [xA9A|2714] (4 bytes)

		// Unknown7
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown7)]
		public byte[] Unknown7; // [xA9E|2718] (28 bytes)

		// EquippedStuff_Moneys_Levels
		public Chunk16 EquippedStuff_Moneys_Levels; // [xABA|2746] (101 bytes)

		// Unknown8
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown8)]
		public byte[] Unknown8; // [xB1F|2847] (5873 bytes)

		// BoyNameDogName
		public Chunk01 BoyNameDogName; // [x2210|8720] (72 bytes)

		// Unknown8
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown9)]
		public byte[] Unknown9; // [x22EA|8938] (21 bytes)

		// Collectables_Spots
		public Chunk18 Collectables_Spots; // [x22FF|8959] (146 bytes)

		// Unknown10
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown10)]
		public byte[] Unknown10; // [x235B|9051] (6 bytes)

		// PossessedStuff
		public Chunk19 PossessedStuff; // [x2361|9057] (92 bytes)

		// Unknown11
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown11)]
		public byte[] Unknown11; // [x238D|9101] (390 bytes)

		// CurrentWeapon_LastLanding
		public Chunk20 CurrentWeapon_LastLanding; // [x2513|9491] (44 bytes)

		// Unknown12
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown12)]
		public byte[] Unknown12; // [x2533|9523] (2591 bytes)

		// TradeGoods
		public Chunk21 TradeGoods; // [x2F52|12114] (32 bytes)

		// Unknown13
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown13)]
		public byte[] Unknown13; // [x5704|22276] (7871 bytes)

		// AlchemyLevels
		public Chunk17 AlchemyLevels; // [x4EB3|20147] (162 bytes)

		// Unknown14
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown14)]
		public byte[] Unknown14; // [x4EB5|20149] (26 bytes)

		// BoyCurrentHp
		public Chunk02 BoyCurrentHp; // [x4EB3|20175] (2 bytes)

		// Unknown15
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown15)]
		public byte[] Unknown15; // [x4EE7|20199] (60 bytes)

		// BoyStatusBuffs
		public Chunk03 BoyStatusBuffs; // [x4ECF|20259] (24 bytes)

		// Chunk4
		public Chunk04 Chunk4; // [x4F23|20265] (101 bytes)

		// Unknown16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown16)]
		public byte[] Unknown16; // [x4F37|20279] (42 bytes)

		// BoyStats2
		public Chunk08 BoyStats2; // [x4F61|20321] (14 bytes)

		// Unknown17
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown17)]
		public byte[] Unknown17; // [x4F63|20323] (26 bytes)

		// DogCurrentHp
		public Chunk09 DogCurrentHp; // [x4F7D|20349] (2 bytes)

		// Unknown18
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown18)]
		public byte[] Unknown18; // [x4F95|20373] (60 bytes)

		// DogStatusBuffs
		public Chunk10 DogStatusBuffs; // [x4FD1|20433] (24 bytes)

		// Chunk11
		public Chunk11 Chunk11; // [x4FD1|20433] (6 bytes)

		// DogStats2
		public Chunk15 DogStats2; // [x4FD1|20433] (14 bytes)

		#endregion

		// Unknown19
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown19)]
		public byte[] Unknown19; // [x4FE5|20_453] (110_619 bytes)
	}
}
using System.Runtime.InteropServices;
using SRAM.SoE.Models.Structs.Chunks;

// ReSharper disable BuiltInTypeReferenceStyle

namespace WRAM.Snes9x.SoE.Models.Structs
{
	/// <summary>
	/// W-RAM format of SoE
	/// </summary>
	/// <remarks>128 * 1024 bytes (128 KiB)</remarks>
	[StructLayout(LayoutKind.Sequential, Pack = 1)] 
	public struct WramSoE
	{
		// Unknown1
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown1)]
		public byte[] Unknown1; // [0] (2613 bytes)

		#region S-RAM Area Offset [2613|xA35] (17_840 bytes)

		// BoyCurrentHp
		public Chunk02 BoyCurrentHp; // [2613|xA35] (2 bytes) 

		// Unknown2
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown2)]
		public byte[] Unknown2; // [2615|xA37] (8 Bytes)

		// BoyStatusBuffs
		public Chunk03 BoyStatusBuffs; // [2623|xA3F] (24 bytes) 

		// Unknown3
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown3)]
		public byte[] Unknown3; // [2636|xA4C] (4 Bytes)

		// Chunk04
		public Chunk04 Chunk04; // [2640|xA50] (6 bytes)

		// Unknown4
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown4)]
		public byte[] Unknown4; // [2644|xA54] (34 Bytes)

		// BoyMaxHp
		public Chunk05 BoyMaxHp; // [2687|xA7F] (2 bytes)

		// Unknown5
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown5)]
		public byte[] Unknown5; // [2689|xA81] (8 Bytes)

		// BoyStats1
		public Chunk06 BoyStats1; // [2697|xA89] (13 bytes)

		// Unknown6
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown6)]
		public byte[] Unknown6; // [2710|xA96] (4 Bytes)

		// BoyLevel
		public Chunk07 BoyLevel; // [2714|xA9A] (2 bytes)

		// Unknown7
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown7)]
		public byte[] Unknown7; // [2718|xA9E] (28 Bytes)

		// BoyStats2
		public Chunk08 BoyStats2; // [2746|xABA] (14 bytes)

		// Unknown8
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown8)]
		public byte[] Unknown8; // [2847|xB1F] (5873 Bytes)

		// BoyNameDogName
		public Chunk01 BoyNameDogName; // [8720|x2210] (72 bytes)
	
		// Unknown8
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown9)]
		public byte[] Unknown9; // [8938|x22EA] (21 Bytes)

		// DogCurrentHp
		public Chunk09 DogCurrentHp; // [8959|x22FF] (2 bytes)

		// Unknown10
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown10)]
		public byte[] Unknown10; // [9051|x235B] (6 Bytes)

		// DogStatusBuffs
		public Chunk10 DogStatusBuffs; // [9057|x2361] (24 bytes)

		// Unknown11
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown11)]
		public byte[] Unknown11; // [9101|x238D] (390 Bytes)

		// Chunk11
		public Chunk11 Chunk11; // [9491|x2513] (6 bytes)

		// Unknown12
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown12)]
		public byte[] Unknown12; // [9523|x2533] (2591 Bytes)

		// DogMaxHp
		public Chunk12 DogMaxHp; // [12114|x2F52] (2 bytes)

		// Unknown13
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown13)]
		public byte[] Unknown13; // [22276|x5704] (7871 Bytes)

		// DogStats1
		public Chunk13 DogStats1; // [20147|x6E] (13 bytes)

		// Unknown14
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown14)]
		public byte[] Unknown14; // [20149|x4EB5] (26 Bytes)

		// Chunk15_BoyStatuDogLevelsBuffs
		public Chunk14 DogLevel; // [20175|x4EB3] (4 bytes)

		// Unknown15
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown15)]
		public byte[] Unknown15; // [20199|x4EE7] (60 Bytes)

		// DogStats2
		public Chunk15 DogStats2; // [20259|x4ECF] (14 bytes)
		
		// EquippedStuff_Moneys_Levels
		public Chunk16 EquippedStuff_Moneys_Levels; // [20265|x4F23] (101 bytes)

		// Unknown16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown16)]
		public byte[] Unknown16; // [20279|x4F37] (42 Bytes)

		// AlchemyLevels
		public Chunk17 AlchemyLevels; // [20321|x4F61] (162 bytes)

		// Unknown17
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown17)]
		public byte[] Unknown17; // [20323|x4F63] (26 Bytes)

		// Collectables_Spots
		public Chunk18 Collectables_Spots; // [20349|x4F7D] (146 bytes)

		// Unknown18
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown18)]
		public byte[] Unknown18; // [20373|x4F95] (60 Bytes)

		// PossessedStuff
		public Chunk19 PossessedStuff; // [20433|x4FD1] (92 bytes)

		// LastLanding_CurrentWeapon
		public Chunk20 LastLanding_CurrentWeapon; // [20433|x4FD1] (44 bytes)

		// TradeGoods
		public Chunk21 TradeGoods; // [20433|x4FD1] (32 bytes)

		#endregion

		// Unknown19
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.Unknown19)]
		public byte[] Unknown19; // [20_453|x4FE5] (110_619 bytes)
	}
}
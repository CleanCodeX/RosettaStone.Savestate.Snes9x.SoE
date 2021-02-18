// ReSharper disable InconsistentNaming

namespace WRAM.Snes9x.SoE.Models
{
	/// <summary>
	/// Known offsets of SoE's W-RAM format
	/// </summary>
	public static class WramOffsets
	{
		public const int Unknown1 = 0;
		public const int SramArea = 0x0A35; // [2613] [$7E:0A35]
		public const int Unknown19 = 0x4FE5; // [20_453] [$7E:4FE5]

		public const int Chunk05  = 0xA35; // [2613] [$7E:0A35] (2 bytes)
		public const int Chunk06  = 0xA3F; // [2623] [$7E:0A3F] (13 bytes)
		public const int Chunk07  = 0xA50; // [2640] [$7E:0A50] (4 bytes)
		public const int Chunk12  = 0xA7F; // [2687] [$7E:0A7F] (2 bytes)
		public const int Chunk13  = 0xA89; // [2697] [$7E:0A89] (13 bytes)
		public const int Chunk14  = 0xA9A; // [2714] [$7E:0A9A] (4 bytes)
		public const int Chunk16  = 0xABA; // [2746] [$7E:0ABA] (101 bytes)
		public const int Chunk01  = 0x2210; // [8720] [$7E:2210] (72 bytes)

		public const int Chunk18  = 0x2258; // [8792] [$7E:2258] (146 bytes)
		public const int Chunk19  = 0x22FF; // [8959] [$7E:22FF] (92 bytes)
		public const int Chunk20  = 0x2361; // [9057] [$7E:2361] (44 bytes)
		public const int Chunk21  = 0x2513; // [9491] [$7E:2513] (32 bytes)

		public const int Chunk17  = 0x2F52; // [12114] [$7E:2F52] (162 bytes)

		public const int Chunk02  = 0x4EB3; // [20147] [$7E:4EB3] (2 bytes)
		public const int Chunk03  = 0x4ECF; // [20175] [$7E:4ECF] (24 bytes)

		public const int Chunk04  = 0x4F23; // [20259] [$7E:4F23] (6 bytes)
		public const int Chunk08  = 0x4F29; // [20265] [$7E:4F29] (14 bytes)
		public const int Chunk09  = 0x4F61; // [20321] [$7E:4F61] (2 bytes)
		public const int Chunk10  = 0x4F7D; // [20349] [$7E:4F7D] (24 bytes)
		public const int Chunk11  = 0x4FD1; // [20433] [$7E:4FD1] (6 bytes)
		public const int Chunk15  = 0x4FD7; // [20439] [$7E:4FD7] (14 bytes)

		public struct Chunk16Offsets
		{
			public const int CurrentEquippedWeapon = 240; // [S:240|xF0] [$7E:0ABA] (2 bytes)

			// Unknown 9
			public const int Unknown9 = 242; // [S:242|xF2] [$7E:0ABC]

			public const int DogCollarStatsPointer = 244; // [S:244|xF4] [$7E:0ABE]
			public const int BoyVestsStatsPointer = 246; // [S:246|xF6] [$7E:0AC0]
			public const int BoyHatsStatsPointer = 248; // [S:248|xF8] [$7E:0AC2]
			public const int BoyBraceletStatsPointer = 250; // [S:250|xFA] [$7E:0AC4]

			// Money
			public const int Moneys = 252; // [252|xFC] [$7E:0AC6-0AD1] (12 bytes)

			// Equipped Alchemies
			public const int EquippedAlchemies = 264; // [S:264|x108] [$7E:0AD2-0ADA] (9 bytes)

			public const int CurrentMapId = 273;// [S:273|x111] [$7E:0ADB]

			// Weapon Levels
			public const int WeaponLevels = 275; // [S:275|x113] [$7E:0ADD-0AF8] (28 bytes)

			// Unknown 11
			public const int Unknown11 = 303; // [S:303|x12F] (14 bytes)

			public const int DogAttackLevel = 317; // [S:317|x13D] [$7E:0B07] (2 bytes)

			// Action screen (8 bytes)
			public const int BoyCombativeness = 319; // [S:319|x13F] [$7E:0B09] 0-6 
			public const int BoyAIWeaponCharging = 321; // [S:321|x142] [$7E:0B0B] Even numbers 0,2,4,6
			public const int DogCombativeness = 323; // [S:323|x144] [$7E:0B0D] 0-6
			public const int DogAIWeaponCharging = 325; // [S:325|x146] [$7E:0B0F] Even numbers 0,2,4,6

			// Window Prefs screen (4 bytes)
			public const int WindowPrefs_Pattern = 327; // [S:327|x148] [$7E:0B15] 24, 34, ... A4
			public const int WindowPrefs_Border = 329; // [S:329|x14A] [$7E:0B17] Even numbers 0-14, inclusive

			public const int ScriptedEventTimer = 331; // [S:331|x14B] [$7E:0B19]

			// Control Prefs screen
			public const int ControlsPrefs_Configuration = 335; // [S:335|x14F] [$7E:0B21] 0, 2
			public const int ControlPrefs_RunButton = 337; // [S:337|x151] [$7E:0B23]
			public const int ControlPrefs_AttackButton = 339; // [S:339|x153] [$7E:0B25]
		}
	}
}
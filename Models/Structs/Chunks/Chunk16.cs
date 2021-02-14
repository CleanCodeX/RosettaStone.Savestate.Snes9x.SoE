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
	/// EquWeapon_Moneys_EquAlchemies_WeaponLvls_DogAtkLvl
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[HasComplexMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk16
	{
		public const int Size = 101;

		public EquippedWeapon CurrentEquippedWeapon; // [S:240|xF0] [$7E:0ABA] (2 bytes)

		// Unknown 9
		public UInt16 Unknown9; // [S:242|xF2] [$7E:0ABC]

		public UInt16 DogCollarStatsPointer; // [S:244|xF4] [$7E:0ABE]
		public UInt16 BoyVestsStatsPointer; // [S:246|xF6] [$7E:0AC0]
		public UInt16 BoyHatsStatsPointer; // [S:248|xF8] [$7E:0AC2]
		public UInt16 BoyBraceletStatsPointer; // [S:250|xFA] [$7E:0AC4]

		// Money
		public Moneys Moneys; // [252|xFC] [$7E:0AC6-0AD1] (12 bytes)

		// Equipped Alchemies
		public EquippedAlchemies EquippedAlchemies; // [S:264|x108] [$7E:0AD2-0ADA] (9 bytes)

		public UInt16 CurrentMapId;// [S:273|x111] [$7E:0ADB]

		// Weapon Levels
		public WeaponLevels WeaponLevels; // [S:275|x113] [$7E:0ADD-0AF8] (28 bytes)

		// Unknown 11
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown11)]
		public byte[] Unknown11; // [S:303|x12F] (14 bytes)

		public WeaponLevel DogAttackLevel; // [S:317|x13D] [$7E:0B07] (2 bytes)

		// Action screen (8 bytes)
		public UInt16 BoyCombativeness; // [S:319|x13F] [$7E:0B09] 0-6 
		public UInt16 BoyAIWeaponCharging; // [S:321|x142] [$7E:0B0B] Even numbers 0,2,4,6
		public UInt16 DogCombativeness; // [S:323|x144] [$7E:0B0D] 0-6
		public UInt16 DogAIWeaponCharging; // [S:325|x146] [$7E:0B0F] Even numbers 0,2,4,6

		// Window Prefs screen (4 bytes)
		public UInt16 WindowPrefs_Pattern; // [S:327|x148] [$7E:0B15] 24, 34, ... A4
		public UInt16 WindowPrefs_Border; // [S:329|x14A] [$7E:0B17] Even numbers 0-14, inclusive

		public UInt32 ScriptedEventTimer; // [S:331|x14B] [$7E:0B19]

		// Control Prefs screen
		public UInt16 ControlsPrefs_Configuration; // [S:335|x14F] [$7E:0B21] 0, 2
		public UInt16 ControlPrefs_RunButton; // [S:337|x151] [$7E:0B23]
		public UInt16 ControlPrefs_AttackButton; // [S:339|x153] [$7E:0B25]
	}
}
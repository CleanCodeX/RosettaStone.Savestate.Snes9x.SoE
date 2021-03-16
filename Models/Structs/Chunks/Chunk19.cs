using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;
using SoE.Models.Enums;
using SoE.Models.Structs;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Ingredients_Items_Armors_Ammo_FlyingMachine
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[HasOffsetMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk19
	{
		public const int Size = 92;

		// [649|x289] [$7E:22FF2314] (22 bytes)
		public Ingredients Ingredients; 

		// [671|x29F] [$7E:2315231C] (8 bytes)
		public Items Items; 

		// [679|x2A7] [$7E:231D2344] (40 bytes)
		public Armors Armors; 

		// [719|x2CF] [$7E:2345-2347] (3 bytes)
		public BazookaAmmunitions BazookaAmmunitions; 

		// [722|x2D2] [$7E:2348] (1 byte)
		public Act CurrentAct; 

		// [723|x2D3] [$7E:2349] (1 byte)
		public BazookaAmmunition CurrentAmmunitionType;

		// [724|x2D4] [$7E:234A]
		public byte MaximumCallbeadAmount; // Used by infinite callbead cheat and when looting callbeads

		// [725|x2D5] [$7E:234B]
		public byte HouseToEnterAct1; // Used if a map change has multiple targets

		// [726|x2D6] [$7E:234C]
		public byte HouseToEnterCrustacia;

		// [727|x2D7] [$7E:234D]
		public UInt16 HouseToEnterSandpitsBugmuck;

		// [729|x2D9] [$7E:234F]
		public byte EbonKeepPrisonTownExit;

		// [730|x2DA] [$7E:2350]
		public byte Act2UnknownState1; 

		// [731|x2DB] [$7E:2351]
		public byte IvorTowerPrisonSewerExit;

		// [732|x2DC] [$7E:2352] 
		public byte QueensKeyOnDog;

		// [733|x2DD] [$7E:2353] 
		public byte QueensKeyOnBoy;

		// [734|x2DE] [$7E:2354]
		public byte Act2UnknownState2;

		// [735|x2DF] [$7E:2355] (1 byte)
		public FlyingMachineType FlyingMachineType;

		// [736|x2E0] [$7E:2356]
		public byte TinkersStateMaybe; // Unsure

		// [737|x2E1] [$7E:2357]
		public byte UnknownPyramidState1;

		// [738|x2E2] [$7E:2358]
		public UInt16 UnknownPyramidState2;

		// [740|x2E4] [$7E:2360]
		public byte Unknown17B;
	}
}
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;
using SoE;
using SoE.Models.Enums;
using SoE.Models.Structs;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Ingredients_Items_Armors_Ammo_FlyingMachine
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[HasComplexMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk19
	{
		public const int Size = 92;

		public Ingredients Ingredients; // [649|x289] [$7E:22FF2314]  (22 bytes)
		public Items Items; // [671|x29F] [$7E:2315231C] (8 bytes)
		public Armors Armors; // [679|x2A7] [$7E:231D2344] (40 bytes)
		public BazookaAmmunitions BazookaAmmunitions; // [719|x2CF] [$7E:23452348] (4 bytes)

		public Act CurrentAct; // [722|x2D2] [$7E:2349] (2 bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown17A)]
		public byte[] Unknown17A; // [724|x2D4] (10 bytes) 

		public FlyingMachineType FlyingMachineType; // [734|x2DE] [$7E:2355] (2 bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown17B)]
		public byte[] Unknown17B; // [736|x2DE] (4 bytes) 
	}
}
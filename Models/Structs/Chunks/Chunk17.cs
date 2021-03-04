using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;
using SoE;
using SoE.Models.Structs;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// AlchemyLevels
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[HasOffsetMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk17
	{
		public const int Size = 162;

		// Alchemy Levels
		public AlchemyLevels AlchemyMinorLevels; // [341|x155] [$7E:2F52-2F97] (70 bytes)

		public AlchemyLevels AlchemyMajorLevels; // [411|x19B] [$7E:2F98-2FDD] (70 bytes)

		// Unknown 13
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown13)]
		public byte[] Unknown13; // [481|x1E1] (22 bytes)
	}
}
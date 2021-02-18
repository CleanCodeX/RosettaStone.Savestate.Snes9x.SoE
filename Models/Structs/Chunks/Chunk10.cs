using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;
using SoE.Models.Structs;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogStatusBuffs
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[HasOffsetMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk10
	{
		public const int Size = 24;

		// Dog Status Buffs 1-4
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public CharacterBuffStatus[] Status; // [177|xB1] (24 bytes)
	}
}
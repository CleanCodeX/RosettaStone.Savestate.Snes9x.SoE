using System.Diagnostics;
using System.Runtime.InteropServices;
using SoE.Models.Structs;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyNameDogName
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Chunk01
	{
		public const int Size = 72;

		public FixedLengthString BoyName; // [36|x26] (36 bytes)
		public FixedLengthString DogName; // [74|x4A] (36 bytes)
	}
}
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;
using SoE;
using SoE.Models.Structs;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Trade Goods
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[HasComplexMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk21
	{
		public const int Size = 32;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.Unknown17G)]
		public byte[] Unknown17G; // [785|x311] (4 bytes) 

		// Trade Goods
		public TradeGoods TradeGoods; // [789|x315] [$7E:25172530] (26 bytes)

		// Unknown 18 (List / stack of 20 active scripts?? Doubtable...)
		public UInt16 Unknown18; // [815|x32F] [$7E:28FC] 
	}
}
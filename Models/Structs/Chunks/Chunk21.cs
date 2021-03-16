using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;
using SoE.Models.Structs;

namespace WRAM.Snes9x.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Trade Goods
	/// </summary>
	/// <remarks><see cref="Size"/></remarks>
	[HasOffsetMembers]
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk21
	{
		public const int Size = 32;

		public UInt16 MarketTimer; // [785|x311] [$7E:2513]  
		public UInt16 RemainingMinutes; // [787|x313] [$7E:2515]  

		// Trade Goods
		public TradeGoods TradeGoods; // [789|x315] [$7E:25172530] (26 bytes)

		// Unknown 18 (will be used for extended Market Timer)
		public UInt16 Unknown18; // [815|x32F] [$7E:2531] 
	}
}
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Common.Shared.Min.Helpers;
using RosettaStone.Savestate.Snes9x.SoE.Constants;
using RosettaStone.Savestate.Snes9x.SoE.Models.Structs;
using RosettaStone.Sram.SoE.Enums;
using SramCommons.Extensions;
using SramCommons.Models;

namespace RosettaStone.Savestate.Snes9x.SoE.Models
{
	/// <summary>
	/// SramFile implementation for <see cref="WramSoE"/> and <see cref="WramSramAreaSoE"/>
	/// </summary>
	public class WSramFileSoE : SegmentFile<WramSoE, WramSramAreaSoE>
	{
		/// <summary>
		/// The S-RAM's file gameRegion 
		/// </summary>
		public GameRegion GameRegion { get; }

		/// <summary>
		/// Creates an instance of <see cref="WSramFileSoE" />
		/// </summary>
		/// <param name="buffer">The buffer from which the W-RAM buffer and W-RAM structure will be loaded from</param>
		/// <param name="gameRegion">The S-RAM's file gameRegion</param>
		public WSramFileSoE(byte[] buffer, GameRegion gameRegion) : base(buffer, WramOffsets.SramArea)
		{
			SizeChecks();
			GameRegion = gameRegion;
		}

		/// <summary>
		/// Creates an instance of <see cref="WSramFileSoE" />
		/// </summary>
		/// <param name="stream">The (opened) stream from which the W-RAM buffer and W-RAM structure will be loaded from</param>
		/// <param name="gameRegion">The S-RAM's file gameRegion</param>
		public WSramFileSoE(Stream stream, GameRegion gameRegion) : base(stream, WramOffsets.SramArea)
		{
			SizeChecks();
			GameRegion = gameRegion;
		}

		private void SizeChecks()
		{
			Debug.Assert(WramSizes.IsValid);
			Debug.Assert(WramSizes.Sram.IsValid);

			Requires.Equal(Marshal.SizeOf<WramSoE>(), WramSizes.All, nameof(Size));
			Requires.Equal(Marshal.SizeOf<WramSramAreaSoE>(), WramSizes.Sram.All, nameof(SegmentSize));
		}

		/// <summary>
		/// Gets the savegame from Wram structure for the given save slot index
		/// </summary>
		/// <returns></returns>
		public override WramSramAreaSoE GetSegment()
		{
			var data = Struct.SramArea;
#if DEBUG
			if (Debugger.IsAttached)
			{
#pragma warning disable IDE0059 // Unnötige Zuweisung eines Werts.
				// ReSharper disable UnusedVariable

				var boyName = data.BoyName.AsString;
				var dogName = data.DogName.AsString;

				var chunk01 = data.Chunk13.Data.FormatAsString();
				var chunk02 = data.Chunk14.Data.FormatAsString();
				var chunk03 = data.Chunk15.Data.FormatAsString();
				var chunk04 = data.Chunk1.Data.FormatAsString();
				var chunk05 = data.Chunk2.Data.FormatAsString();
				var chunk06 = data.Chunk3.Data.FormatAsString();
				var chunk07 = data.Chunk4.Data.FormatAsString();
				var chunk08 = data.Chunk17.Data.FormatAsString();
				var chunk09 = data.Chunk18.Data.FormatAsString();
				var chunk10 = data.Chunk19.Data.FormatAsString();
				var chunk11 = data.Chunk4.Data.FormatAsString();
				var chunk12 = data.Chunk5.Data.FormatAsString();
				var chunk13 = data.Chunk6.Data.FormatAsString();
				var chunk14 = data.Chunk20.Data.FormatAsString();
				var chunk15 = data.Chunk7.Data.FormatAsString();
				var chunk16 = data.Chunk12.Data.FormatAsString();
				var chunk17 = data.Chunk8.Data.FormatAsString();
				var chunk18 = data.Chunk9.Data.FormatAsString();
				var chunk19 = data.Chunk10.Data.FormatAsString();
				var chunk20 = data.Chunk11.Data.FormatAsString();

				// ReSharper restore UnusedVariable
#pragma warning restore IDE0059 // Unnötige Zuweisung eines Werts.
			}
#endif
			return data;
		}

		/// <summary>
		/// Saves the data of Sram structure to Sram buffer.
		/// </summary>
		/// <param name="stream"></param>
		public override void Save(Stream stream)
		{
			base.SetSegment(Struct.SramArea);
			base.Save(stream);
		}
	}
}
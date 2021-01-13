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
	/// SramFile implementation for <see cref="WramSoE"/> and <see cref="WramSaveSlotSoE"/>
	/// </summary>
	public class WSramFileSoE : SramFile<WramSoE, WramSaveSlotSoE>
	{
		/// <summary>
		/// The SRAM's file gameRegion 
		/// </summary>
		public GameRegion GameRegion { get; }

		/// <summary>
		/// Creates an instance of <see cref="WSramFileSoE" />
		/// </summary>
		/// <param name="buffer">The buffer from which the W-RAM buffer and W-RAM structure will be loaded from</param>
		/// <param name="gameRegion">The SRAM's file gameRegion</param>
		public WSramFileSoE(byte[] buffer, GameRegion gameRegion) : base(buffer, WramOffsets.FirstSaveSlot, 3)
		{
			SizeChecks();
			GameRegion = gameRegion;
		}

		/// <summary>
		/// Creates an instance of <see cref="WSramFileSoE" />
		/// </summary>
		/// <param name="stream">The (opened) stream from which the W-RAM buffer and W-RAM structure will be loaded from</param>
		/// <param name="gameRegion">The SRAM's file gameRegion</param>
		public WSramFileSoE(Stream stream, GameRegion gameRegion) : base(stream, WramOffsets.FirstSaveSlot, 3)
		{
			SizeChecks();
			GameRegion = gameRegion;
		}

		private void SizeChecks()
		{
			Debug.Assert(WramSizes.SaveSlot.All == WramSizes.SaveSlot.AllNonChunk + WramSizes.SaveSlot.AllChunks);

			Requires.Equal(Marshal.SizeOf<WramSoE>(), WramSizes.Wram, nameof(BufferSize));
			Requires.Equal(Marshal.SizeOf<WramSaveSlotSoE>(), WramSizes.SaveSlot.All, nameof(SaveSlotSize));
		}

		/// <summary>
		/// Gets the savegame from Wram structure for the given save slot index
		/// </summary>
		/// <param name="slotIndex"></param>
		/// <returns></returns>
		public override WramSaveSlotSoE GetSaveSlot(int slotIndex)
		{
			ref var saveSlot = ref Sram.SaveSlots[slotIndex];
#if DEBUG
			if (Debugger.IsAttached)
			{
#pragma warning disable IDE0059 // Unnötige Zuweisung eines Werts.
				// ReSharper disable UnusedVariable

				ref var data = ref saveSlot;

				var unknown1 = data.Unknown1;
				var boyName = data.BoyName;
				var unknown2 = data.Unknown2;
				var dogName = data.DogName;
				var unknown3 = data.Unknown3;

				var chunk01 = data.Chunk01.Data.FormatAsString();
				var chunk02 = data.Chunk02.Data.FormatAsString();
				var chunk03 = data.Chunk03.Data.FormatAsString();
				var chunk04 = data.Chunk04.Data.FormatAsString();
				var chunk05 = data.Chunk05.Data.FormatAsString();
				var chunk06 = data.Chunk06.Data.FormatAsString();
				var chunk07 = data.Chunk07.Data.FormatAsString();
				var chunk08 = data.Chunk08.Data.FormatAsString();
				var chunk09 = data.Chunk09.Data.FormatAsString();
				var chunk10 = data.Chunk10.Data.FormatAsString();
				var chunk11 = data.Chunk11.Data.FormatAsString();
				var chunk12 = data.Chunk12.Data.FormatAsString();
				var chunk13 = data.Chunk13.Data.FormatAsString();
				var chunk14 = data.Chunk14.Data.FormatAsString();
				var chunk15 = data.Chunk15.Data.FormatAsString();
				var chunk16 = data.Chunk16.Data.FormatAsString();
				var chunk17 = data.Chunk17.Data.FormatAsString();
				var chunk18 = data.Chunk18.Data.FormatAsString();
				var chunk19 = data.Chunk19.Data.FormatAsString();
				var chunk20 = data.Chunk20.Data.FormatAsString();

				// ReSharper restore UnusedVariable
#pragma warning restore IDE0059 // Unnötige Zuweisung eines Werts.
			}
#endif
			return saveSlot;
		}

		/// <summary>
		/// Saves savegame to SaveSlot structure, not not to Sram buffer. To save to sram buffer call Save method.
		/// </summary>
		/// <param name="slotIndex">The target save slot index the game is saved to</param>
		/// <param name="slot">The game to be saved</param>
		public override void SetSaveSlot(int slotIndex, WramSaveSlotSoE slot) => Sram.SaveSlots[slotIndex] = slot;

		/// <summary>
		/// Saves the data of Sram structure to Sram buffer.
		/// </summary>
		/// <param name="stream"></param>
		public override void Save(Stream stream)
		{
			for (var slotIndex = 0; slotIndex <= 3; ++slotIndex)
				if (IsValid(slotIndex))
					base.SetSaveSlot(slotIndex, Sram.SaveSlots[slotIndex]);

			base.Save(stream);
		}
	}
}
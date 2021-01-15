using System;
using RosettaStone.Savestate.Snes9x.Models.Structs;
using RosettaStone.Savestate.Snes9x.SoE.Constants;
using RosettaStone.Sram.SoE.Enums;
using RosettaStone.Sram.SoE.Models;

namespace RosettaStone.Savestate.Snes9x.SoE.Helpers
{
	public static class SavestateWramHelper
	{
		internal static int WramSramOffset = WramOffsets.WramSramOffset; // 8682

		internal static SramFileSoE GetSramFileFromSavestate(SavestateSnex9x savestate)
		{
			const GameRegion region = GameRegion.EnglishNtsc;
	
			var sramFile = new SramFileSoE(savestate.SRA.Data, region);
			var slotIndex = sramFile.Sram.LastSaveslot / 2;

			var dataW = savestate.RAM.Data;
			var dataS = sramFile.GetSaveSlotBytes(slotIndex);

			foreach (var (wOffset, (sOffset, size)) in WramOffsets.SaveSlot.WramSramMappings)
				Array.Copy(dataW, wOffset, dataS, sOffset, size);

			sramFile.SetSaveSlotBytes(slotIndex, dataS);

			return sramFile;
		}
	}
}
using System;
using RosettaStone.Savestate.Snes9x.Models.Structs;
using RosettaStone.Savestate.Snes9x.SoE.Constants;
using RosettaStone.Sram.SoE.Enums;
using RosettaStone.Sram.SoE.Models;

namespace RosettaStone.Savestate.Snes9x.SoE.Helpers
{
	public static class SavestateWramHelper
	{
		internal static SramFileSoE GetSramFileFromSavestate(SavestateSnex9x savestate)
		{
			const GameRegion region = GameRegion.EnglishNtsc;
	
			var sramFile = new SramFileSoE(savestate.SRA.Data, region);
			var saveslotId = sramFile.Struct.LastSaveslotId / 2;

			var dataW = savestate.RAM.Data;
			var dataS = sramFile.GetSegmentBytes(saveslotId);

			foreach (var (wramOffset, (sramOffset, size)) in WramOffsets.Sram.WramSramMappings)
				Array.Copy(dataW, wramOffset, dataS, sramOffset, size);

			sramFile.SetSegmentBytes(saveslotId, dataS);

			return sramFile;
		}
	}
}
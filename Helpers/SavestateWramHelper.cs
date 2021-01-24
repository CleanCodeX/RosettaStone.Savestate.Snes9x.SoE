using System;
using Savestate.Snes9x.Models.Structs;
using SoE.Models.Enums;
using SRAM.SoE.Models;
using WRAM.Snes9x.SoE.Models;

namespace WRAM.Snes9x.SoE.Helpers
{
	public static class SavestateWramHelper
	{
		internal static SramFileSoE GetSramFileFromSavestate(SavestateSnex9x savestate, GameRegion region)
		{
			var sramFile = new SramFileSoE(savestate.SRA.Data, region);
			var saveSlotId = sramFile.Struct.LastSaveslotId / 2;

			var dataW = savestate.RAM.Data;
			var dataS = sramFile.GetSegmentBytes(saveSlotId);

			foreach (var (wramOffset, (sramOffset, size)) in WramOffsets.SramMappings)
				Array.Copy(dataW, wramOffset, dataS, sramOffset, size);

			sramFile.SetSegmentBytes(saveSlotId, dataS);

			return sramFile;
		}
	}
}
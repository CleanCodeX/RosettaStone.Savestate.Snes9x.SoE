using System.Diagnostics;
using System.Text;
using RosettaStone.Savestate.Snes9x.SoE.Constants;
using RosettaStone.Sram.SoE;
using RosettaStone.Sram.SoE.Constants;
using RosettaStone.Sram.SoE.Enums;

namespace RosettaStone.Savestate.Snes9x.SoE.Helpers
{
	public static class SavestateWramExtractor
	{
		public static byte[] ExtractSram(byte[] wram)
		{
			Debug.Assert(false);

			const GameRegion region = GameRegion.EnglishNtsc;
			const int wOffset = 0;
			const int wOffsetEnd = wOffset + Sizes.Sram;

			var sram = new byte[8192];
			var sramW = wram[wOffset..(wOffsetEnd + 1)];

			// Debug
			var S = Encoding.ASCII.GetString(sram);
			var W = Encoding.ASCII.GetString(sramW);

			Debug.Assert(false);

			var sramFile = new SramFileSoE(sram, region);
			var wramFile = new SramFileSoE(sramW, region);

			sram[Offsets.SramChecksum] = wram[WramOffsets.SramChecksum];

			// Loop though all save slots
			for (var i = 0; i < 4; i += Sizes.SaveSlot.All)
			{
				var slotS = sramFile.GetSaveSlot(i);
				var slotW = wramFile.GetSaveSlot(i);

				slotS.Checksum = slotW.Checksum;

				slotS.BoyName.StringValue = slotW.BoyName.StringValue;

				slotS.BoyCurrentHp = slotW.BoyCurrentHp;

				Debug.Assert(false);
			}

			return sram;
		}
	}
}
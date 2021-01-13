using System.Diagnostics;
using System.Text;
using RosettaStone.Savestate.Snes9x.SoE.Constants;
using RosettaStone.Savestate.Snes9x.SoE.Models;
using RosettaStone.Sram.SoE.Constants;
using RosettaStone.Sram.SoE.Enums;
using RosettaStone.Sram.SoE.Models;

namespace RosettaStone.Savestate.Snes9x.SoE.Helpers
{
	public static class SavestateWramHelper
	{
		internal static int WramSramOffset = WramOffsets.WramSramOffset; // 8682

		internal static SramFileSoE GetSramFileFromWram(byte[] wram) => GetSramFileFromWSram(GetSramChunkFromWram(wram));
		internal static WSramFileSoE GetWSramFileFromWram(byte[] wram) => new(GetSramChunkFromWram(wram), GameRegion.EnglishNtsc);

		private static SramFileSoE GetSramFileFromWSram(byte[] wSram)
		{
			const GameRegion region = GameRegion.EnglishNtsc;
			
			var sram = new byte[8192];

			// Debug
			var W = Encoding.ASCII.GetString(wSram);
			var pos = W.IndexOf("Latschi") - WramOffsets.SaveSlot.BoyName;
			Debug.Assert(pos == 0);

			pos = W.IndexOf("Hundi") - WramOffsets.SaveSlot.DogName;
			Debug.Assert(pos == 0);

			var sramFile = new SramFileSoE(sram, region);
			var wramFile = new WSramFileSoE(wSram, region);

			//var supposedBoyLevelPre10 = GetBufferRange(wSram, WramOffsets.SaveSlot.Chunk02 - 10, WramSizes.SaveSlot.Chunk02 + 10);
			//var supposedBoyLevelPost10 = GetBufferRange(wSram, WramOffsets.SaveSlot.Chunk02, WramSizes.SaveSlot.Chunk02 + 10);

			// Loop though all save slots
			for (var i = 0; i < 4; i += SramSizes.SaveSlot.All)
			{
				//var slotS = sramFile.GetSaveSlot(i);
				var dataW = wramFile.GetSaveSlot(i);

				Debug.Assert(false);
			}

			return sramFile;
		}

		private static byte[] GetSramChunkFromWram(byte[] wram) => GetSramChunkFromWram(wram, WramSramOffset);
		private static byte[] GetSramChunkFromWram(byte[] wram, int offset) => GetBufferRange(wram, offset, SramSizes.Sram);
		private static byte[] GetBufferRange(byte[] wram, int offset, int size, int offsetOffset) => GetBufferRange(wram, offset - offsetOffset, size + offsetOffset * 2);

		private static byte[] GetBufferRange(byte[] buffer, int offset, int size) => buffer[offset..(offset + size + 1)];
	}
}
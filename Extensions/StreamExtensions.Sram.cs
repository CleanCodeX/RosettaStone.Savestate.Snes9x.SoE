using System.IO;
using RosettaStone.Savestate.Snes9x.Extensions;
using RosettaStone.Savestate.Snes9x.Helpers;
using RosettaStone.Savestate.Snes9x.SoE.Helpers;

namespace RosettaStone.Savestate.Snes9x.SoE.Extensions
{
	public static class StreamExtensions
    {
	    public static Stream? GetSramFromSavestate(this Stream source) => SavestateWramExtractor.ExtractSram(SavestateReader.Load(source).RAM.Data).ToStreamIfNotNull();
    }
}

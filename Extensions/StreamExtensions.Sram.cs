using System.IO;
using IO.Extensions;
using Savestate.Snes9x.Helpers;
using SoE.Models.Enums;
using WRAM.Snes9x.SoE.Helpers;

namespace WRAM.Snes9x.SoE.Extensions
{
	public static class StreamExtensions
    {
	    public static Stream GetSramFromSavestate(this Stream source, GameRegion region) => SavestateWramHelper.GetSramFileFromSavestate(SavestateReader.Load(source), region).Buffer.ToStream();
    }
}

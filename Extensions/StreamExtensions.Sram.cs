using System.IO;
using RosettaStone.Savestate.Snes9x.Helpers;
using RosettaStone.Savestate.Snes9x.SoE.Helpers;
using SramCommons.Extensions;

namespace RosettaStone.Savestate.Snes9x.SoE.Extensions
{
	public static class StreamExtensions
    {
	    public static Stream GetSramFromSavestate(this Stream source) => SavestateWramHelper.GetSramFileFromSavestate(SavestateReader.Load(source)).Buffer.ToStream();
    }
}

using System.Diagnostics;
using RosettaStone.Savestate.Snes9x.Extensions;
using RosettaStone.Savestate.Snes9x.Helpers;
using RosettaStone.Savestate.Snes9x.SoE.Helpers;
using RosettaStone.Sram.SoE;
using RosettaStone.Sram.SoE.Enums;

var wramBytes = SavestateReader.Load(args[0]).RAM.Data;
var sramStream = SavestateWramExtractor.ExtractSram(wramBytes).ToStream()!;

Debug.Assert(false);

var sramFile = new SramFileSoE(sramStream, GameRegion.EnglishNtsc);
var saveSlot = sramFile.GetSaveSlot(0);

Debug.Print(saveSlot.BoyCurrentHp.ToString());



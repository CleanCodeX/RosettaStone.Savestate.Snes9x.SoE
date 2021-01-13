using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Common.Shared.Min.Extensions;
using RosettaStone.Savestate.Snes9x.Helpers;
using RosettaStone.Savestate.Snes9x.SoE.Helpers;
using RosettaStone.Savestate.Snes9x.SoE.Models.Structs;
using SramCommons.Extensions;

Console.BufferHeight = 1000;
Console.WindowHeight = 50;

const string Delimiter = ", ";

try
{
	if (args.Length == 0)
		throw new ArgumentException("Pass a file as argument.");

	Console.ForegroundColor = ConsoleColor.White;
	Console.WriteLine("Reading file:");
	Console.WriteLine(args[0]);
	var wramBytes = SavestateReader.Load(args[0]).RAM.Data;

	Console.WriteLine();

	Console.ForegroundColor = ConsoleColor.Green;
	var file = $"1_WramDump_{wramBytes.Length}_bytes.txt";
	File.WriteAllBytes(file, wramBytes);
	Console.WriteLine($"Dumped WRAM ({wramBytes.Length} bytes) to {file}.");

	Console.WriteLine();

	Console.ForegroundColor = ConsoleColor.White;
	Console.WriteLine($"Current S-RAM Offset in WRAM is: {SavestateWramHelper.WramSramOffset}");
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine("If a different offset should be used, enter a new value. 0 or empty will use the existing offset.");

	var wsramOffset = 0;
	if (args.Length > 1)
		wsramOffset = ParseInt(args[1]);

	if (wsramOffset == 0)
		int.TryParse(Console.ReadLine()!, out wsramOffset);

	if (wsramOffset > 0)
	{
		SavestateWramHelper.WramSramOffset = wsramOffset;
		Console.WriteLine($"New S-RAM Offset in WRAM is: {SavestateWramHelper.WramSramOffset}");
	}

	var wramFile = SavestateWramHelper.GetWSramFileFromWram(wramBytes);

	Console.WriteLine();

	Console.ForegroundColor = ConsoleColor.Green;

	file = $"2_WSramDump_{wramFile.Buffer.Length}_bytes.txt";
	File.WriteAllBytes(file, wramFile.Buffer);
	Console.WriteLine($"Dumped W-SRAM ({wramFile.Buffer.Length} bytes) to {file}.");

	var saveSlot = wramFile.GetSaveSlot(0);
	var saveSlotBytes = saveSlot.ToBytes();
	
	file = $"3_SaveSlot0Dump_{saveSlotBytes.Length}_bytes.txt";
	File.WriteAllBytes(file, saveSlotBytes);
	Console.WriteLine($"Dumped SaveSlot0 ({saveSlotBytes.Length} bytes) to {file}.");

	Console.ForegroundColor = ConsoleColor.Yellow;

	Console.WriteLine();
	ShowCommands();

	Console.ForegroundColor = ConsoleColor.Gray;
	
	while (true)
	{
		var key = Console.ReadLine();

		switch (key)
		{
			case "":
				continue;
			case "q":
				return;
			case "?":
				ShowCommands();
				break;
			case "cls":
				Console.Clear();
				break;
			case "vars":
				ShowVariables();
				break;
			case "slot":
				Console.WriteLine(saveSlot.ToString());
				break;
			case { } when key.StartsWith("var "):
				ShowVariable(saveSlot, key);
				break;
			case { } when key.StartsWith("byte"):
				ShowOffsetNumber(saveSlotBytes, key);
				break;
			case { } when key.StartsWith("char"):
				ShowOffsetCharacters(saveSlotBytes, key);
				break;
			case { } when key.StartsWith("string"):
				ShowOffsetString(saveSlotBytes, key);
				break;
			default:
				Console.WriteLine(@$"Unknown command name: ""{key}""");
				break;
		}
	}
}
catch (Exception ex)
{
	Console.WriteLine("ERROR:" + ex.Message);
	Console.WriteLine();
	Console.ReadKey();
}

static void ShowOffsetNumber(byte[] saveSlotBytes, string key)
{
	Console.ForegroundColor = ConsoleColor.Yellow;

	var valueIndex = key.IndexOf(" ") + 1;
	var sizeIndex = key.IndexOf(":");
	string value;
	int offset;
	if (sizeIndex == -1)
	{
		offset = ParseInt(key.Substring(valueIndex));
		value = saveSlotBytes[offset].ToString();
	}
	else
	{
		offset = ParseInt(key.Substring(valueIndex, sizeIndex - valueIndex));
		var size = ParseInt(key.Substring(sizeIndex + 1));
		value = saveSlotBytes[offset..(offset + size + 1)].FormatAsString(Delimiter);
	}

	Console.WriteLine($"{offset}: {value}");
	Console.WriteLine();
	Console.ResetColor();
}

static int ParseInt(string input) => input.StartsWith("x") ? int.Parse(input, NumberStyles.AllowHexSpecifier) : int.Parse(input);

static void ShowOffsetString(byte[] saveSlotBytes, string key)
{
	Console.ForegroundColor = ConsoleColor.Yellow;

	string value;
	int offset;
	var valueIndex = key.IndexOf(" ") + 1;
	var sizeIndex = key.IndexOf(":");
	
	if (sizeIndex == -1)
	{
		offset = ParseInt(key.Substring(valueIndex));
		value = ((char)saveSlotBytes[offset]).ToString();
	}
	else
	{
		offset = ParseInt(key.Substring(valueIndex, sizeIndex - valueIndex));
		var size = ParseInt(key.Substring(sizeIndex + 1));
		value = Encoding.ASCII.GetString(saveSlotBytes[offset..(offset + size + 1)]);
	}

	Console.WriteLine($"{offset}: [{value}]");
	Console.WriteLine();
	Console.ResetColor();
}

static void ShowOffsetCharacters(byte[] saveSlotBytes, string key)
{
	Console.ForegroundColor = ConsoleColor.Yellow;

	string value;
	int offset;
	var valueIndex = key.IndexOf(" ") + 1;
	var sizeIndex = key.IndexOf(":");

	if (sizeIndex == -1)
	{
		offset = ParseInt(key.Substring(valueIndex));
		value = ((char)saveSlotBytes[offset]).ToString();
	}
	else
	{
		offset = ParseInt(key.Substring(valueIndex, sizeIndex - valueIndex));
		var size = ParseInt(key.Substring(sizeIndex + 1));
		value = Encoding.ASCII.GetChars(saveSlotBytes[offset..(offset + size + 1)]).Join(Delimiter);
	}

	Console.WriteLine($"{offset}: [{value}]");
	Console.WriteLine();
	Console.ResetColor();
}

static void ShowCommands()
{
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine("Commands:");
	Console.WriteLine("?: This command list");
	Console.WriteLine("q: Quit");
	Console.WriteLine("cls: Clears the window");
	Console.WriteLine("vars: List saveslot variable names");
	Console.WriteLine("slot: Shows the slot0 variable summary");
	Console.WriteLine("var {name}: Shows the text value of that variable name");
	Console.WriteLine("byte {offset}: Shows the byte at offset X as number");
	Console.WriteLine("bytes {offset:size}: Shows the bytes at offset X with");
	Console.WriteLine("char {offset}: Shows the char at offset X as number");
	Console.WriteLine("chars {offset:size}: Shows the chars at offset X with");
	Console.WriteLine("string {offset:size}: Shows the ANSII string at the given offset");
	Console.WriteLine($"Cmd-Line arg {{1}}: W-RAM S-RAM Offset ({SavestateWramHelper.WramSramOffset})");
	Console.WriteLine();
	Console.ResetColor();
}

static void ShowVariables()
{
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine(typeof(WramSaveSlotSoE).GetFields().Select(e => e.Name).Join(Environment.NewLine));
	Console.WriteLine();
	Console.ResetColor();
}

static void ShowVariable(WramSaveSlotSoE saveSlot, string key)
{
	var name = key.Substring(4).Trim();
	var fieldInfo = typeof(WramSaveSlotSoE).GetFields().SingleOrDefault(e => e.Name.EqualsInsensitive(name));
	if (fieldInfo is null)
		throw new ArgumentException(@$"Field ""{key}"" does not exist");

	var value = fieldInfo!.GetValue(saveSlot)?.ToString();

	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine($"[{name}]: {value}");
	Console.WriteLine();
	Console.ResetColor();
}

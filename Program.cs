using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Common.Shared.Min.Extensions;
using IO.Extensions;
using Savestate.Snes9x.Helpers;
using SoE.Models.Enums;
using WRAM.Snes9x.SoE.Helpers;
using SRAM.SoE.Models.Structs;

namespace WRAM.Snes9x.SoE
{
	public static class Program
	{
		private const string Delimiter = ", ";

		public static void Main(string[] args)
		{
			Console.BufferHeight = 1000;
			Console.WindowHeight = 50;
			
			try
			{
				if (args.Length == 0)
					throw new ArgumentException("Pass a file as argument.");

				var filePath = args[0];

				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("Reading file:");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine(filePath);
				Console.WriteLine();

				var savestateFile = SavestateReader.Load(filePath);
				var sramFile = SavestateWramHelper.GetSramFileFromSavestate(savestateFile, GameRegion.EnglishNtsc);

				var fileName = Path.GetFileNameWithoutExtension(filePath);
				var srmFilePath = Path.Join(Path.GetDirectoryName(filePath), fileName + ".srm");

				if (File.Exists(srmFilePath))
					File.Copy(srmFilePath, srmFilePath + ".backup", true);

				sramFile.Save(srmFilePath);

				DumpWram();
				DumpWSram();

				ShowCommands(filePath);

				Console.ForegroundColor = ConsoleColor.Gray;

				while (true)
				{
					var key = Console.ReadLine();

					try
					{
						switch (key)
						{
							case "":
								continue;
							case "q":
								return;
							case "?":
								ShowCommands(filePath);
								break;
							case "cls":
								Console.Clear();
								break;
							case "vars":
								ShowVariables();
								break;
							case "slot":
								Console.WriteLine(sramFile.GetSegment(0).ToString());
								break;
							case { } when key.StartsWith("var "):
								ShowVariable(sramFile.GetSegment(0).Data, key);
								break;
							case { } when key.StartsWith("byte"):
								ShowOffsetNumber(sramFile.GetSegmentBytes(0), key);
								break;
							case { } when key.StartsWith("char"):
								ShowOffsetCharacters(sramFile.GetSegmentBytes(0), key);
								break;
							case { } when key.StartsWith("string"):
								ShowOffsetString(sramFile.GetSegmentBytes(0), key);
								break;
							default:
								Console.WriteLine(@$"Unknown command name: ""{key}""");
								break;
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine("ERROR:" + ex.Message);
						Console.WriteLine();
						Console.ReadKey();
					}
				}

				void DumpWSram()
				{
					Console.ForegroundColor = ConsoleColor.Green;

					var file = $"2_W-SramDump_{sramFile.Size}_bytes.txt";
					File.WriteAllBytes(file, sramFile.Buffer);
					Console.WriteLine($"Dumped W-S-RAM ({sramFile.Size} bytes): {file}");

					var bytes = sramFile.GetSegmentBytes(0);

					file = $"3_SaveSlot0Dump_{bytes.Length}_bytes.txt";
					File.WriteAllBytes(file, bytes);
					Console.WriteLine($"Dumped SaveSlot0 ({bytes.Length} bytes): {file}");
					Console.WriteLine();
					Console.ResetColor();
				}

				void DumpWram()
				{
					Console.ForegroundColor = ConsoleColor.Green;

					var data = savestateFile.RAM.Data;
					var file = $"1_WramDump_{data.Length}_bytes.txt";
					File.WriteAllBytes(file, data);

					Console.WriteLine($"Dumped WRAM ({data.Length} bytes): {file}");
					Console.ResetColor();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("ERROR:" + ex.Message);
				Console.WriteLine();
				Console.ReadKey();
			}
		}

		private static void ShowOffsetNumber(byte[] saveSlotBytes, string key)
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

		private static int ParseInt(string input)
		{
			if (input.StartsWith("x"))
				return int.Parse(input.Remove("x")!, NumberStyles.AllowHexSpecifier);

			return int.Parse(input);
		}

		private static void ShowOffsetString(byte[] saveSlotBytes, string key)
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

		private static void ShowOffsetCharacters(byte[] saveSlotBytes, string key)
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

		private static void ShowCommands(string savestateFile)
		{
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Commands:");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("?: This command list");
			Console.WriteLine("sramoffset: Setzt das W-S-RAM-Offset");
			Console.WriteLine("vars: List saveslot variable names");
			Console.WriteLine("sslot: Shows the S-RAM slot 0 content");
			Console.WriteLine("wslot: Shows the W-RAM slot 0 content");
			Console.WriteLine("var {name}: Shows the text value of that variable name");
			Console.WriteLine("byte {offset}: Shows the byte at offset X as number");
			Console.WriteLine("bytes {offset:size}: Shows the bytes at offset X with");
			Console.WriteLine("char {offset}: Shows the char at offset X as number");
			Console.WriteLine("chars {offset:size}: Shows the chars at offset X with");
			Console.WriteLine("string {offset:size}: Shows the ANSII string at the given offset");
			Console.WriteLine("cls: Clears the window");
			Console.WriteLine("q: Quit");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Cmd-Args:");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Arg {{0}} ~ Savestate file: [{savestateFile}");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Hint: Hex-numbers must be prefixed with x (e.g. x100)");
			Console.WriteLine();
			Console.ResetColor();
		}

		private static void ShowVariables()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(typeof(SaveSlotDataSoE).GetFields().Select(e => e.Name).Join(Environment.NewLine));
			Console.WriteLine();
			Console.ResetColor();
		}

		private static void ShowVariable(SaveSlotDataSoE saveSlot, string key)
		{
			var name = key.Substring(4).Trim();
			var fieldInfo = saveSlot.GetType().GetFields().SingleOrDefault(e => e.Name.EqualsInsensitive(name));
			if (fieldInfo is null)
				throw new ArgumentException(@$"Field ""{key}"" does not exist");

			var value = fieldInfo!.GetValue(saveSlot)?.ToString();

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"{fieldInfo.Name}: {value}");
			Console.WriteLine();
			Console.ResetColor();
		}
	}
}
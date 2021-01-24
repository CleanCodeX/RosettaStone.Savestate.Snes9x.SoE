using SRAM.SoE.Models;

namespace WRAM.Snes9x.SoE.Models
{
	/// <summary>
	/// Known sizes of SoE's W-RAM buffer
	/// </summary>
	public class WramSizes
	{
		public const int All = 128 * 1024;
		public const bool IsValid = SramSizes.SaveSlot.AllChunks + AllUnknown == All;

		#region Unknowns

		public const int Unknown1 = 2_613;

		#region S-RAM area
		public const int Unknown2 = 8; // (x)
		public const int Unknown3 = 4; // (x)
		public const int Unknown4 = 34; // (x)
		public const int Unknown5 = 8; // (x)
		public const int Unknown6 = 4; // (x)
		public const int Unknown7 = 28; // (x)
		public const int Unknown8 = 5873; // (x16F1)
		public const int Unknown9 = 21; // (x)
		public const int Unknown10 = 6; // (x)
		public const int Unknown11 = 390; // (x)
		public const int Unknown12 = 2591; // (xA1F)
		public const int Unknown13 = 7871; // (x1EBF)
		public const int Unknown14 = 26; // (x)
		public const int Unknown15 = 60; // (x)
		public const int Unknown16 = 42; // (x)
		public const int Unknown17 = 26; // (x)
		public const int Unknown18 = 60; // (x)
#endregion

		public const int Unknown19 = 110_619;

		public const int AllUnknown = Unknown1 + Unknown2 + Unknown3 + Unknown4 + Unknown5 +
		                              Unknown6 + Unknown7 + Unknown8 + Unknown9 + Unknown10 +
		                              Unknown11 + Unknown12 + Unknown13 + Unknown14 + Unknown15 +
		                              Unknown16 + Unknown17 + Unknown18 + Unknown19;

		public const int UnknownPercentage = AllUnknown * 100 / All;

		#endregion
	}
}
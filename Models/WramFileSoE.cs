using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Common.Shared.Min.Helpers;
using RosettaStone.Savestate.Snes9x.SoE.Models.Structs;
using RosettaStone.Sram.SoE.Models.Enums;
using SramCommons.Models;

namespace RosettaStone.Savestate.Snes9x.SoE.Models
{
	/// <summary>
	/// SramFile implementation for <see cref="WramSoE"/>
	/// </summary>
	public class WramFileSoE : WramFile<WramSoE>
	{
		/// <summary>
		/// The SRAM's file gameRegion 
		/// </summary>
		public GameRegion GameRegion { get; }

		/// <summary>
		/// Creates an instance of <see cref="WramFileSoE" />
		/// </summary>
		/// <param name="buffer">The buffer from which the W-RAM buffer and W-RAM structure will be loaded from</param>
		/// <param name="gameRegion">The SRAM's file gameRegion</param>
		public WramFileSoE(byte[] buffer, GameRegion gameRegion) : base(buffer)
		{
			SizeChecks();
			GameRegion = gameRegion;
		}

		/// <summary>
		/// Creates an instance of <see cref="WramFileSoE" />
		/// </summary>
		/// <param name="stream">The (opened) stream from which the W-RAM buffer and W-RAM structure will be loaded from</param>
		/// <param name="gameRegion">The SRAM's file gameRegion</param>
		public WramFileSoE(Stream stream, GameRegion gameRegion) : base(stream)
		{
			SizeChecks();
			GameRegion = gameRegion;
		}

		private void SizeChecks()
		{
			Debug.Assert(WramSizes.IsValid);

			Requires.Equal(Marshal.SizeOf<WramSoE>(), WramSizes.All, nameof(Size));
		}
	}
}
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Common.Shared.Min.Helpers;
using SoE.Models.Enums;
using WRAM.Models;
using WRAM.Snes9x.SoE.Models.Structs;

namespace WRAM.Snes9x.SoE.Models
{
	/// <summary>
	/// SramFile implementation for <see cref="WramSoE"/>
	/// </summary>
	public class WramFileSoE : WramFile<WramSoE>
	{
		/// <summary>
		/// The SRAM's file region 
		/// </summary>
		public GameRegion GameRegion { get; }

		/// <summary>
		/// Creates an instance of <see cref="WramFileSoE" />
		/// </summary>
		/// <param name="buffer">The buffer from which the W-RAM buffer and W-RAM structure will be loaded from</param>
		/// <param name="region">The SRAM's file region</param>
		public WramFileSoE(byte[] buffer, GameRegion region) : base(buffer)
		{
			SizeChecks();
			GameRegion = region;
		}

		/// <summary>
		/// Creates an instance of <see cref="WramFileSoE" />
		/// </summary>
		/// <param name="stream">The (opened) stream from which the W-RAM buffer and W-RAM structure will be loaded from</param>
		/// <param name="region">The SRAM's file region</param>
		public WramFileSoE(Stream stream, GameRegion region) : base(stream)
		{
			SizeChecks();
			GameRegion = region;
		}

		private void SizeChecks()
		{
			Debug.Assert(WramSizes.IsValid);

			Requires.Equal(Marshal.SizeOf<WramSoE>(), WramSizes.All, nameof(Size));
		}
	}
}
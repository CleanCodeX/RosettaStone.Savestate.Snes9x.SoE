using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RosettaStone.Savestate.Snes9x.SoE.Extensions
{
	public static class ArrayExtensions
	{
		/// <returns>Array of chars</returns>
		public static char[] GetChars([NotNull] this byte[] source) => Encoding.ASCII.GetChars(source);
	}
}

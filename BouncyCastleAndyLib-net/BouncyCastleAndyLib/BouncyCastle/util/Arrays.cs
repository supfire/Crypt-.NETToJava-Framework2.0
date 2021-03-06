using System;
using System.Text;

namespace Org.BouncyCastle.Utilities
{

    /// <summary> General array utilities.</summary>
    public sealed class Arrays
    {
        private Arrays()
        {
        }

        /// <summary>
        /// Are two arrays equal.
        /// </summary>
        /// <param name="a">Left side.</param>
        /// <param name="b">Right side.</param>
        /// <returns>True if equal.</returns>
        public static bool AreEqual(
			byte[]	a,
			byte[]	b)
        {
			if (a == b)
				return true;

			return HaveSameContents(a, b);
        }

		public static bool AreSame(
			byte[]	a,
			byte[]	b)
		{
			if (a == b)
				return true;

			if (a == null || b == null)
				return false;

			return HaveSameContents(a, b);
		}

		private static bool HaveSameContents(
			byte[]	a,
			byte[]	b)
		{
			if (a.Length != b.Length)
				return false;

			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] != b[i])
					return false;
			}

			return true;
		}

		public static string ToString(
			object[] a)
		{
			StringBuilder sb = new StringBuilder('[');
			if (a.Length > 0)
			{
				sb.Append(a[0]);
				for (int index = 1; index < a.Length; ++index)
				{
					sb.Append(", ").Append(a[index]);
				}
			}
			sb.Append(']');
			return sb.ToString();
		}

		public static int GetHashCode(
			byte[] data)
		{
			int hc = 0;

			for (int i = 0; i != data.Length; i++)
			{
				hc ^= ((int) data[i]) << (i % 4);
			}

			return hc;
		}

		public static byte[] Clone(
			byte[] data)
		{
			return data == null ? null : (byte[]) data.Clone();
		}
	}
}

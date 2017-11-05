using System.Collections.Generic;

namespace TomLabs.PowerClam.Extensions
{
	/// <summary>
	/// <see cref="System.Linq"/> related extension methods
	/// </summary>
	public static class LinqExtensions
	{
		/// <summary>
		/// Concatenates the members of a constructed <see cref="System.Collections.Generic.IEnumerable{T}"/>
		///     collection of type <see cref="string"/>, using the specified separator between each
		///     member.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <param name="separator"></param>
		/// <returns></returns>
		public static string JoinItems<T>(this T collection, string separator) where T : IEnumerable<string>
		{
			return string.Join(separator, collection);
		}
	}
}

using System.Collections.Generic;
using System.Linq;
using TomLabs.PowerClam.Data;

namespace TomLabs.PowerClam.Extensions
{
	/// <summary>
	/// Extension methods for PowerShell related classes
	/// </summary>
	public static class PSExtensions
	{
		/// <summary>
		/// Converts <see cref="IEnumerable{PSParam}"/> to <see cref="IDictionary{TKey, TValue}"/>
		/// </summary>
		/// <param name="paramList"></param>
		/// <returns><see cref="IDictionary{TKey, TValue}"/> params</returns>
		public static IDictionary<string, object> ToDictionary(this IEnumerable<PSParam> paramList)
		{
			return paramList?.ToDictionary(p => p.Name, v => v.Value);
		}
	}
}

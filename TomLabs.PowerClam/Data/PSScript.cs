using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TomLabs.PowerClam.Data
{
	/// <summary>
	/// Class that holds information about powershell script
	/// </summary>
	public class PSScript
	{
		/// <summary>
		/// Script name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Path to script
		/// </summary>
		public string Path { get; set; }

		/// <summary>
		/// Script parameters
		/// </summary>
		public List<PSParam> Parameters { get; set; }

		public string WorkingDirectory { get; set; }

		[Obsolete("Only for serialization")]
		public PSScript()
		{
		}

		/// <summary>
		/// Creates new instance of <see cref="PSScript"/> from script file
		/// </summary>
		/// <param name="path">Path to script</param>
		public PSScript(string path)
		{
			Path = path;
			Name = System.IO.Path.GetFileNameWithoutExtension(Path);
			WorkingDirectory = System.IO.Path.GetDirectoryName(Path);

			LoadParameters();
		}

		/// <summary>
		/// Loads script <see cref="Parameters"/> from script content
		/// </summary>
		public void LoadParameters()
		{
			if (File.Exists(Path))
			{
				var script = File.ReadAllText(Path);
				Parameters = ParseParameters(script);
			}
		}

		/// <summary>
		/// Executes given script
		/// </summary>
		public ScriptOutput Execute()
		{
			return ScriptExecutor.ExecuteScript(this);
		}

		/// <summary>
		/// Executes given script
		/// </summary>
		public async Task<ScriptOutput> ExecuteAsync()
		{
			return await ScriptExecutor.ExecuteScriptAsync(this);
		}

		/// <summary>
		/// Parses parameters from powershell script content
		/// </summary>
		/// <param name="script"></param>
		/// <returns></returns>
		private List<PSParam> ParseParameters(string script)
		{
			var parameters = new List<PSParam>();

			string paramsString = Regex.Match(script, @"param\((.*)\)").Value;
			var matchedParams = Regex.Matches(paramsString, @"(\[(.*?),|\[(.*)\))");
			foreach (Match match in matchedParams)
			{
				string groupedParam = (match.Groups[2]?.Value == "" ? match.Groups[3]?.Value : match.Groups[2]?.Value).Replace(",", "");
				string type = Regex.Match(groupedParam, @"(.*)]").Groups[1]?.Value;
				string name = Regex.Match(groupedParam, @"\]\$(.*)=").Groups[1]?.Value;
				var valueRegex = Regex.Match(groupedParam, @"(=\$(.*)|=(.*))");
				string value = valueRegex.Groups[2]?.Value == "" ? valueRegex.Groups[3]?.Value.Replace("\"", "") : valueRegex.Groups[2]?.Value;

				parameters.Add(new PSParam(name, value, type));
			}

			return parameters;
		}
	}
}

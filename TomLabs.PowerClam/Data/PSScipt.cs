using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace TomLabs.PowerClam.Data
{
	/// <summary>
	/// Class that holds information about powershell script
	/// </summary>
	public class PSScipt
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

		/// <summary>
		/// Gets or sets whether app should prompt user for filling in parameter values before running
		/// </summary>
		public bool PromptParams { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public PSScipt()
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="path">Path to script</param>
		public PSScipt(string path)
		{
			Path = path;
			Name = System.IO.Path.GetFileNameWithoutExtension(Path);
			LoadParameters();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="path">Path to script</param>
		/// <param name="parameters">Script parameters</param>
		/// <param name="promptParams">Sets whether app should prompt user for filling in parameter values before running</param>
		/// <param name="name">Script name</param>
		public PSScipt(string path, List<PSParam> parameters, bool promptParams = false, string name = null)
		{
			Path = path;
			Parameters = parameters;
			PromptParams = promptParams;
			Name = name ?? System.IO.Path.GetFileNameWithoutExtension(Path);
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

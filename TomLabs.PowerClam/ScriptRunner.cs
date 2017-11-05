using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using TomLabs.PowerClam.Data;
using TomLabs.PowerClam.Extensions;

namespace TomLabs.PowerClam
{
	/// <summary>
	/// Provides methods for running powershell scripts
	/// </summary>
	public class ScriptRunner
	{
		/// <summary>
		/// Runs powershell <see cref="PSScipt"/>
		/// </summary>
		/// <param name="script"></param>
		public static string RunScriptFile(PSScipt script)
		{
			return RunScriptFile(script.Path, script.Parameters.ToDictionary());
		}

		/// <summary>
		/// Runs powershell script file with given parameters
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="parameters"></param>
		public static string RunScriptFile(string filePath, IDictionary<string, object> parameters = null)
		{
			return Execute($"& '{filePath}' {SerializeParameters(parameters)}", Path.GetDirectoryName(filePath));
		}

		/// <summary>
		/// Runs powershell command
		/// </summary>
		/// <param name="command"></param>
		/// <param name="workingDirectory">Directory to run the script in</param>
		/// <returns></returns>
		public static string RunCommand(string command, string workingDirectory)
		{
			return Execute($"& '{command}'", workingDirectory);
		}

		private static string Execute(string arguments, string workingDirectory)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = @"powershell.exe",
				Arguments = arguments,
				WorkingDirectory = workingDirectory,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};

			Process process = new Process
			{
				StartInfo = startInfo
			};
			process.Start();

			return process.StandardOutput.ReadToEnd();
		}

		private static string SerializeParameters(IDictionary<string, object> parameters)
		{
			return parameters?
				.Where(p => p.Value != null && (p.Value is string && (string)p.Value != string.Empty))  // Exclude empty params
				.Select(p => $"-{p.Key} {p.Value.ToString()}").JoinItems(" ");
		}
	}
}

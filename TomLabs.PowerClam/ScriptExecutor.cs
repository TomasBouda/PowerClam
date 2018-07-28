using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Threading.Tasks;
using TomLabs.PowerClam.Data;
using TomLabs.PowerClam.Extensions;
using static TomLabs.PowerClam.PSCommands;

namespace TomLabs.PowerClam
{
	/// <summary>
	/// Provides methods for running powershell scripts
	/// </summary>
	public static class ScriptExecutor
	{
		/// <summary>
		/// Runs powershell <see cref="PSScript"/>
		/// </summary>
		/// <param name="script"></param>
		public static ScriptOutput ExecuteScript(PSScript script)
		{
			return ExecuteScriptFile(script.Path, script.Parameters.ToDictionary(), script.WorkingDirectory);
		}

		/// <summary>
		/// Runs powershell <see cref="PSScript"/>
		/// </summary>
		/// <param name="script"></param>
		public static async Task<ScriptOutput> ExecuteScriptAsync(PSScript script)
		{
			return await ExecuteScriptFileAsync(script.Path, script.Parameters.ToDictionary(), script.WorkingDirectory);
		}

		/// <summary>
		/// Runs powershell script file with given parameters
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="parameters"></param>
		public static ScriptOutput ExecuteScriptFile(string filePath, IDictionary<string, object> parameters = null, string workingDirectory = null)
		{
			if (!File.Exists(filePath))
			{
				throw new FileNotFoundException($"File not found! - {filePath}");
			}
			var scriptBlock = File.ReadAllText(filePath);

			workingDirectory = workingDirectory ?? Path.GetDirectoryName(filePath);

			return ExecuteScriptBlock(scriptBlock, parameters, workingDirectory);
		}

		/// <summary>
		/// Runs powershell script file with given parameters
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="parameters"></param>
		public static async Task<ScriptOutput> ExecuteScriptFileAsync(string filePath, IDictionary<string, object> parameters = null, string workingDirectory = null)
		{
			if (!File.Exists(filePath))
			{
				throw new FileNotFoundException($"File not found! - {filePath}");
			}
			var scriptBlock = File.ReadAllText(filePath);

			workingDirectory = workingDirectory ?? Path.GetDirectoryName(filePath);

			return await ExecuteScriptBlockAsync(scriptBlock, parameters, workingDirectory);
		}

		public static ScriptOutput ExecuteScriptBlock(string scriptBlock, IDictionary<string, object> parameters = null, string workingDirectory = null)
		{
			return Execute(scriptBlock, parameters, workingDirectory);
		}

		public static async Task<ScriptOutput> ExecuteScriptBlockAsync(string scriptBlock, IDictionary<string, object> parameters = null, string workingDirectory = null)
		{
			return await ExecuteAsync(scriptBlock, parameters, workingDirectory);
		}

		private static ScriptOutput Execute(string scriptBlock, IDictionary<string, object> parameters = null, string workingDirectory = null)
		{
			if (string.IsNullOrWhiteSpace(scriptBlock))
			{
				throw new ArgumentNullException(nameof(scriptBlock));
			}

			using (var shell = PowerShell.Create())
			{
				if(!string.IsNullOrEmpty(workingDirectory))
				{
					shell.AddScript($"{Set_Location} \"{workingDirectory}\"");
				}

				var script = shell.AddScript(scriptBlock);

				if(parameters != null)
				{
					script.AddParameters(parameters.ToDictionary(k => k.Key, v => v.Value));
				}

				var output = ScriptOutput.ExecuteAndOutput(script);
				if (shell.Streams.Error.Count > 0)
				{
					throw new AggregateException(shell.Streams.Error.Select(e => e.Exception));
				}

				return output;
			}
		}

		private static async Task<ScriptOutput> ExecuteAsync(string scriptBlock, IDictionary<string, object> parameters = null, string workingDirectory = null)
		{
			if (string.IsNullOrWhiteSpace(scriptBlock))
			{
				throw new ArgumentNullException(nameof(scriptBlock));
			}

			using (var shell = PowerShell.Create())
			{
				if (!string.IsNullOrEmpty(workingDirectory))
				{
					shell.AddScript($"{Set_Location} \"{workingDirectory}\"");
				}

				var script = shell.AddScript(scriptBlock);

				if (parameters?.Count > 0)
				{
					script.AddParameters(parameters.ToDictionary(k => k.Key, v => v.Value));
				}

				var output = await ScriptOutput.ExecuteAndOutputAsync(script);
				if (shell.Streams.Error.Count > 0)
				{
					throw new AggregateException(shell.Streams.Error.Select(e => e.Exception));
				}

				return output;
			}
		}
	}
}

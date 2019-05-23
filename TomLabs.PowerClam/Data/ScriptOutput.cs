using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace TomLabs.PowerClam.Data
{
	public enum PowerShellStreamType
	{
		Info, 
		Verbose,
		Progress,
		Debug,
		Warning,
		Error
	}

	public class ScriptStreamInfo
	{
		internal ScriptStreamInfo(string message, PowerShellStreamType streamType, DateTime? createdAt = null)
		{
			Message = message;
			CreatedAt = createdAt;
			StreamType = streamType;
		}

		public string Message { get; set; }
		public PowerShellStreamType StreamType { get; set; }
		public DateTime? CreatedAt { get; set; }
	}

	public class ScriptOutput
	{
		public IReadOnlyCollection<string> Pipeline { get; private set; }
		public IReadOnlyCollection<ScriptStreamInfo> Console { get; private set; }

		internal static ScriptOutput ExecuteAndOutput(PowerShell script)
		{
			if (script == null)
			{
				throw new ArgumentNullException(nameof(script));
			}

			var scriptOutput = new ScriptOutput();

			var output = script.Invoke();
			scriptOutput.Pipeline = output.Select(o => o.ToString()).ToList();

			scriptOutput.Console = script.Streams.Information.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Info, s.TimeGenerated))
				.Union(script.Streams.Verbose.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Verbose)))
				.Union(script.Streams.Progress.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Progress)))
				.Union(script.Streams.Debug.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Debug)))
				.Union(script.Streams.Warning.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Warning)))
				.Union(script.Streams.Error.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Error)))
				.ToList();

			return scriptOutput;
		}

		internal async static Task<ScriptOutput> ExecuteAndOutputAsync(PowerShell script)
		{
			if (script == null)
			{
				throw new ArgumentNullException(nameof(script));
			}

			var scriptOutput = new ScriptOutput();

			//var output = await Task.Factory.FromAsync(script.BeginInvoke(), (ar) => script.EndInvoke(ar));
			var output = await Task.Run(() => script.Invoke());

			scriptOutput.Pipeline = output.Select(o => o?.ToString()).ToList();

			scriptOutput.Console = script.Streams.Information.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Info, s.TimeGenerated))
				.Union(script.Streams.Verbose.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Verbose)))
				.Union(script.Streams.Progress.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Progress)))
				.Union(script.Streams.Debug.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Debug)))
				.Union(script.Streams.Warning.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Warning)))
				.Union(script.Streams.Error.Select(s => new ScriptStreamInfo(s.ToString(), PowerShellStreamType.Error)))
				.ToList();

			return scriptOutput;
		}

		public override string ToString()
		{
			return string.Join(Environment.NewLine, Pipeline);
		}
	}
}

# PowerClam
Small library for executing powershell scripts.

## Usage

```cs
string output = ScriptRunner.RunScriptFile(new PSScipt(@"C:\PathToScript\Testscript.ps1"));
```

```cs
var script = new PSScipt(@"C:\PathToScript\Testscript.ps1");
script.Parameters[0].Value = "test";
string output = ScriptRunner.RunScriptFile(script);
```
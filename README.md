# PowerClam [![NuGet](https://img.shields.io/nuget/v/TomLabs.PowerClam.svg)](https://www.nuget.org/packages/TomLabs.PowerClam/) [![Travis](https://travis-ci.org/TomasBouda/PowerClam.svg?branch=master)](https://travis-ci.org/TomasBouda/PowerClam)
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

## Install via NuGet

```
Install-Package TomLabs.PowerClam -Version 1.0.0
```
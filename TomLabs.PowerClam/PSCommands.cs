namespace TomLabs.PowerClam
{
	/// <summary>
	/// List of powershell commands
	/// </summary>
	public static class PSCommands
	{
		///<summary>
		/// Adds one or more files to an existing Background Intelligent Transfer Service (BITS) transfer job.
		///</summary>
		public const string Add_BitsFile = "Add-BitsFile";

		///<summary>
		/// Adds the local computer to a domain or workgroup.
		///</summary>
		public const string Add_Computer = "Add-Computer";

		///<summary>
		/// Adds content to the specified items, such as adding words to a file.
		///</summary>
		public const string Add_Content = "Add-Content";

		///<summary>
		/// Appends entries to the session history.
		///</summary>
		public const string Add_History = "Add-History";

		///<summary>
		/// Adds a user-defined custom member to an instance of a Windows PowerShell object.
		///</summary>
		public const string Add_Member = "Add-Member";

		///<summary>
		/// Adds one or more Windows PowerShell snap-ins to the current session.
		///</summary>
		public const string Add_PSSnapin = "Add-PSSnapin";

		///<summary>
		/// Adds a Microsoft .NET Framework type (a class) to a Windows PowerShell session (PSSession).
		///</summary>
		public const string Add_Type = "Add-Type";

		///<summary>
		/// Creates a system restore point on the local computer.
		///</summary>
		public const string Checkpoint_Computer = "Checkpoint-Computer";

		///<summary>
		/// Deletes the contents of an item, such as deleting the text from a file, but does not delete the item.
		///</summary>
		public const string Clear_Content = "Clear-Content";

		///<summary>
		/// Deletes all entries from specified event logs on the local or remote computers.
		///</summary>
		public const string Clear_EventLog = "Clear-EventLog";

		///<summary>
		/// Deletes entries from the command history.
		///</summary>
		public const string Clear_History = "Clear-History";

		///<summary>
		/// Deletes the contents of an item but does not delete the item.
		///</summary>
		public const string Clear_Item = "Clear-Item";

		///<summary>
		/// Deletes the value of a property but does not delete the property.
		///</summary>
		public const string Clear_ItemProperty = "Clear-ItemProperty";

		///<summary>
		/// Deletes the value of a variable.
		///</summary>
		public const string Clear_Variable = "Clear-Variable";

		///<summary>
		/// Compares two sets of objects.
		///</summary>
		public const string Compare_Object = "Compare-Object";

		///<summary>
		/// Completes a BITS transfer job.
		///</summary>
		public const string Complete_BitsTransfer = "Complete-BitsTransfer";

		///<summary>
		/// Commits the active transaction.
		///</summary>
		public const string Complete_Transaction = "Complete-Transaction";

		///<summary>
		/// Connects to the Windows Remote Management (WinRM) service on a remote computer.
		///</summary>
		public const string Connect_WSMan = "Connect-WSMan";

		///<summary>
		/// Converts object properties in comma-separated value (CSV) format into CSV versions of the original objects.
		///</summary>
		public const string ConvertFrom_CSV = "ConvertFrom-CSV";

		///<summary>
		/// Converts a secure string into an encrypted standard string.
		///</summary>
		public const string ConvertFrom_SecureString = "ConvertFrom-SecureString";

		///<summary>
		/// Converts a string containing one or more key/value pairs to a hash table.
		///</summary>
		public const string ConvertFrom_StringData = "ConvertFrom-StringData";

		///<summary>
		/// Converts a path from a Windows PowerShell path to a PowerShell provider path.
		///</summary>
		public const string Convert_Path = "Convert-Path";

		///<summary>
		/// Converts .NET Framework objects into a series of CSV variable-length strings.
		///</summary>
		public const string ConvertTo_CSV = "ConvertTo-CSV";

		///<summary>
		/// Converts .NET Framework objects into HTML that can be displayed in a Web browser.
		///</summary>
		public const string ConvertTo_Html = "ConvertTo-Html";

		///<summary>
		/// Converts encrypted standard strings to secure strings. It can also convert plain text to secure strings. It is used with ConvertFrom-SecureString and Read-Host.
		///</summary>
		public const string ConvertTo_SecureString = "ConvertTo-SecureString";

		///<summary>
		/// Creates an XML-based representation of an object.
		///</summary>
		public const string ConvertTo_XML = "ConvertTo-XML";

		///<summary>
		/// Copies an item from one location to another within a namespace.
		///</summary>
		public const string Copy_Item = "Copy-Item";

		///<summary>
		/// Copies a property and value from a specified location to another location.
		///</summary>
		public const string Copy_ItemProperty = "Copy-ItemProperty";

		///<summary>
		/// Debugs one or more processes running on the local computer.
		///</summary>
		public const string Debug_Process = "Debug-Process";

		///<summary>
		/// Disables the System Restore feature on the specified file system drive.
		///</summary>
		public const string Disable_ComputerRestore = "Disable-ComputerRestore";

		///<summary>
		/// Disables breakpoints in the current console.
		///</summary>
		public const string Disable_PSBreakpoint = "Disable-PSBreakpoint";

		///<summary>
		/// Denies access to the session configurations on the local computer.
		///</summary>
		public const string Disable_PSSessionConfiguration = "Disable-PSSessionConfiguration";

		///<summary>
		/// Disables Credential Security Service Provider (CredSSP) authentication on a client computer.
		///</summary>
		public const string Disable_WSManCredSSP = "Disable-WSManCredSSP";

		///<summary>
		/// Disconnects the client from the WinRM service on a remote computer.
		///</summary>
		public const string Disconnect_WSMan = "Disconnect-WSMan";

		///<summary>
		/// Enables the System Restore feature on the specified file system drive.
		///</summary>
		public const string Enable_ComputerRestore = "Enable-ComputerRestore";

		///<summary>
		/// Enables breakpoints in the current console.
		///</summary>
		public const string Enable_PSBreakpoint = "Enable-PSBreakpoint";

		///<summary>
		/// Configures the computer to receive remote commands.
		///</summary>
		public const string Enable_PSRemoting = "Enable-PSRemoting";

		///<summary>
		/// Enables session configurations on the local computer.
		///</summary>
		public const string Enable_PSSessionConfiguration = "Enable-PSSessionConfiguration";

		///<summary>
		/// Enables CredSSP authentication on a client computer.
		///</summary>
		public const string Enable_WSManCredSSP = "Enable-WSManCredSSP";

		///<summary>
		/// Starts an interactive session with a remote computer.
		///</summary>
		public const string Enter_PSSession = "Enter-PSSession";

		///<summary>
		/// Ends an interactive session with a remote computer.
		///</summary>
		public const string Exit_PSSession = "Exit-PSSession";

		///<summary>
		/// Exports information about currently defined aliases to a file.
		///</summary>
		public const string Export_Alias = "Export-Alias";

		///<summary>
		/// Creates an XML-based representation of an object or objects and stores it in a file.
		///</summary>
		public const string Export_Clixml = "Export-Clixml";

		///<summary>
		/// Exports the names of snap-ins in the current session to a console file.
		///</summary>
		public const string Export_Console = "Export-Console";

		///<summary>
		/// Takes PerformanceCounterSampleSet objects and exports them as counter log files.
		///</summary>
		public const string Export_Counter = "Export-Counter";

		///<summary>
		/// Converts .NET Framework objects into a series of CSV variable-length strings and saves the strings in a CSV file.
		///</summary>
		public const string Export_CSV = "Export-CSV";

		///<summary>
		/// Saves formatting data from the current session in a formatting file.
		///</summary>
		public const string Export_FormatData = "Export-FormatData";

		///<summary>
		/// Specifies the module members that are exported.
		///</summary>
		public const string Export_ModuleMember = "Export-ModuleMember";

		///<summary>
		/// Imports commands from another session and saves them in a Windows PowerShell module.
		///</summary>
		public const string Export_PSSession = "Export-PSSession";

		///<summary>
		/// Performs an operation against each of a set of input objects.
		///</summary>
		public const string ForEach_Object = "ForEach-Object";

		///<summary>
		/// Uses a customized view to format the output.
		///</summary>
		public const string Format_Custom = "Format-Custom";

		///<summary>
		/// Formats the output as a list of properties in which each property appears on a new line.
		///</summary>
		public const string Format_List = "Format-List";

		///<summary>
		/// Formats the output as a table.
		///</summary>
		public const string Format_Table = "Format-Table";

		///<summary>
		/// Formats objects as a wide table that displays only one property of each object.
		///</summary>
		public const string Format_Wide = "Format-Wide";

		///<summary>
		/// Gets the security descriptor for a resource, such as a file or registry key.
		///</summary>
		public const string Get_Acl = "Get-Acl";

		///<summary>
		/// Gets the aliases for the current session.
		///</summary>
		public const string Get_Alias = "Get-Alias";

		///<summary>
		/// Gets the AppLocker file information from a list of files or an event log.
		///</summary>
		public const string Get_AppLockerFileInformation = "Get-AppLockerFileInformation";

		///<summary>
		/// Gets the local, effective, or domain AppLocker policy.
		///</summary>
		public const string Get_AppLockerPolicy = "Get-AppLockerPolicy";

		///<summary>
		/// Gets information about the Authenticode signature in a file.
		///</summary>
		public const string Get_AuthenticodeSignature = "Get-AuthenticodeSignature";

		///<summary>
		/// Retrieves the associated BitsJob object for an existing BITS transfer job.
		///</summary>
		public const string Get_BitsTransfer = "Get-BitsTransfer";

		///<summary>
		/// Gets the items and child items in one or more specified locations.
		///</summary>
		public const string Get_ChildItem = "Get-ChildItem";

		///<summary>
		/// Gets basic information about cmdlets and other elements of Windows PowerShell commands.
		///</summary>
		public const string Get_Command = "Get-Command";

		///<summary>
		/// Gets the restore points on the local computer.
		///</summary>
		public const string Get_ComputerRestorePoint = "Get-ComputerRestorePoint";

		///<summary>
		/// Gets the content of the item at the specified location.
		///</summary>
		public const string Get_Content = "Get-Content";

		///<summary>
		/// Gets performance counter data from local and remote computers.
		///</summary>
		public const string Get_Counter = "Get-Counter";

		///<summary>
		/// Gets a credential object based on a user name and password.
		///</summary>
		public const string Get_Credential = "Get-Credential";

		///<summary>
		/// Gets the current culture set in the operating system.
		///</summary>
		public const string Get_Culture = "Get-Culture";

		///<summary>
		/// Gets the current date and time.
		///</summary>
		public const string Get_Date = "Get-Date";

		///<summary>
		/// Gets the events in the event queue.
		///</summary>
		public const string Get_Event = "Get-Event";

		///<summary>
		/// Gets the events in an event log, or a list of the event logs, on the local or remote computers.
		///</summary>
		public const string Get_EventLog = "Get-EventLog";

		///<summary>
		/// Gets the event subscribers in the current session.
		///</summary>
		public const string Get_EventSubscriber = "Get-EventSubscriber";

		///<summary>
		/// Gets the execution policies for the current session.
		///</summary>
		public const string Get_ExecutionPolicy = "Get-ExecutionPolicy";

		///<summary>
		/// Gets the formatting data in the current session.
		///</summary>
		public const string Get_FormatData = "Get-FormatData";

		///<summary>
		/// Displays information about Windows PowerShell commands and concepts.
		///</summary>
		public const string Get_Help = "Get-Help";

		///<summary>
		/// Gets a list of the commands entered during the current session.
		///</summary>
		public const string Get_History = "Get-History";

		///<summary>
		/// Gets an object that represents the current host program. Also displays Windows PowerShell version and regional information by default.
		///</summary>
		public const string Get_Host = "Get-Host";

		///<summary>
		/// Gets the hotfixes that are applied to the local and remote computers.
		///</summary>
		public const string Get_HotFix = "Get-HotFix";

		///<summary>
		/// Gets the item at the specified location.
		///</summary>
		public const string Get_Item = "Get-Item";

		///<summary>
		/// Gets the properties of a specified item.
		///</summary>
		public const string Get_ItemProperty = "Get-ItemProperty";

		///<summary>
		/// Gets Windows PowerShell background jobs that are running in the current session.
		///</summary>
		public const string Get_Job = "Get-Job";

		///<summary>
		/// Gets information about the current working location.
		///</summary>
		public const string Get_Location = "Get-Location";

		///<summary>
		/// Gets the properties and methods of objects.
		///</summary>
		public const string Get_Member = "Get-Member";

		///<summary>
		/// Gets the modules that are imported or that can be imported into the current session.
		///</summary>
		public const string Get_Module = "Get-Module";

		///<summary>
		/// Gets information about .pfx certificate files on the computer.
		///</summary>
		public const string Get_PfxCertificate = "Get-PfxCertificate";

		///<summary>
		/// Gets the processes that are running on the local computer or a remote computer.
		///</summary>
		public const string Get_Process = "Get-Process";

		///<summary>
		/// Gets the breakpoints that are set in the current session.
		///</summary>
		public const string Get_PSBreakpoint = "Get-PSBreakpoint";

		///<summary>
		/// Displays the current call stack.
		///</summary>
		public const string Get_PSCallStack = "Get-PSCallStack";

		///<summary>
		/// Gets the Windows PowerShell drives in the current session.
		///</summary>
		public const string Get_PSDrive = "Get-PSDrive";

		///<summary>
		/// Gets information about the specified Windows PowerShell provider.
		///</summary>
		public const string Get_PSProvider = "Get-PSProvider";

		///<summary>
		/// Gets the Windows PSSessions in the current session.
		///</summary>
		public const string Get_PSSession = "Get-PSSession";

		///<summary>
		/// Gets the registered session configurations on the computer.
		///</summary>
		public const string Get_PSSessionConfiguration = "Get-PSSessionConfiguration";

		///<summary>
		/// Gets the Windows PowerShell snap-ins on the computer.
		///</summary>
		public const string Get_PSSnapin = "Get-PSSnapin";

		///<summary>
		/// Gets a random number or selects objects randomly from a collection.
		///</summary>
		public const string Get_Random = "Get-Random";

		///<summary>
		/// Gets the services on a local or remote computer.
		///</summary>
		public const string Get_Service = "Get-Service";

		///<summary>
		/// Gets the Windows PowerShell components that are instrumented for tracing.
		///</summary>
		public const string Get_TraceSource = "Get-TraceSource";

		///<summary>
		/// Gets the current (active) transaction.
		///</summary>
		public const string Get_Transaction = "Get-Transaction";

		///<summary>
		/// Gets information about a troubleshooting pack and can generate an answer file.
		///</summary>
		public const string Get_TroubleshootingPack = "Get-TroubleshootingPack";

		///<summary>
		/// Gets the current user interface (UI) culture settings in the operating system.
		///</summary>
		public const string Get_UICulture = "Get-UICulture";

		///<summary>
		/// Returns the unique items from a sorted list.
		///</summary>
		public const string Get_Unique = "Get-Unique";

		///<summary>
		/// Gets the variables in the current console.
		///</summary>
		public const string Get_Variable = "Get-Variable";

		///<summary>
		/// Gets events from event logs and event tracing log files on local and remote computers.
		///</summary>
		public const string Get_WinEvent = "Get-WinEvent";

		///<summary>
		/// Gets instances of Windows Management Instrumentation (WMI) classes or information about the available classes.
		///</summary>
		public const string Get_WmiObject = "Get-WmiObject";

		///<summary>
		/// Gets the CredSSP-related configuration for the client.
		///</summary>
		public const string Get_WSManCredSSP = "Get-WSManCredSSP";

		///<summary>
		/// Displays management information for a resource instance specified by a Uniform Resource Identifier (URI).
		///</summary>
		public const string Get_WSManInstance = "Get-WSManInstance";

		///<summary>
		/// Groups objects that contain the same value for specified properties.
		///</summary>
		public const string Group_Object = "Group-Object";

		///<summary>
		/// Imports an alias list from a file.
		///</summary>
		public const string Import_Alias = "Import-Alias";

		///<summary>
		/// Imports a CLIXML file and creates corresponding objects within Windows PowerShell.
		///</summary>
		public const string Import_Clixml = "Import-Clixml";

		///<summary>
		/// Imports performance counter log files (.blg, .csv, .tsv) and creates the objects that represent each counter sample in the log.
		///</summary>
		public const string Import_Counter = "Import-Counter";

		///<summary>
		/// Converts object properties in a CSV file into CSV versions of the original objects.
		///</summary>
		public const string Import_CSV = "Import-CSV";

		///<summary>
		/// Imports language-specific data into scripts and functions based on the UI culture that is selected for the operating system.
		///</summary>
		public const string Import_LocalizedData = "Import-LocalizedData";

		///<summary>
		/// Adds modules to the current session.
		///</summary>
		public const string Import_Module = "Import-Module";

		///<summary>
		/// Imports commands from another session into the current session.
		///</summary>
		public const string Import_PSSession = "Import-PSSession";

		///<summary>
		/// Runs commands on local and remote computers.
		///</summary>
		public const string Invoke_Command = "Invoke-Command";

		///<summary>
		/// Runs commands or expressions on the local computer.
		///</summary>
		public const string Invoke_Expression = "Invoke-Expression";

		///<summary>
		/// Runs commands from the session history.
		///</summary>
		public const string Invoke_History = "Invoke-History";

		///<summary>
		/// Performs the default action on the specified item.
		///</summary>
		public const string Invoke_Item = "Invoke-Item";

		///<summary>
		/// Executes a troubleshooting pack in interactive or unattended mode to fix a problem and then generates a results report.
		///</summary>
		public const string Invoke_TroubleshootingPack = "Invoke-TroubleshootingPack";

		///<summary>
		/// Calls WMI methods.
		///</summary>
		public const string Invoke_WmiMethod = "Invoke-WmiMethod";

		///<summary>
		/// Invokes an action on the object that is specified by the Resource URI and by the selectors.
		///</summary>
		public const string Invoke_WSManAction = "Invoke-WSManAction";

		///<summary>
		/// Combines a path and a child path into a single path. The provider supplies the path delimiters.
		///</summary>
		public const string Join_Path = "Join-Path";

		///<summary>
		/// Sets the event log properties that limit the size of the event log and the age of its entries.
		///</summary>
		public const string Limit_EventLog = "Limit-EventLog";

		///<summary>
		/// Measures the time it takes to run script blocks and cmdlets.
		///</summary>
		public const string Measure_Command = "Measure-Command";

		///<summary>
		/// Calculates the numeric properties of objects and the characters, words, and lines in string objects, such as files of text.
		///</summary>
		public const string Measure_Object = "Measure-Object";

		///<summary>
		/// Moves an item from one location to another.
		///</summary>
		public const string Move_Item = "Move-Item";

		///<summary>
		/// Moves a property from one location to another.
		///</summary>
		public const string Move_ItemProperty = "Move-ItemProperty";

		///<summary>
		/// Creates a new alias.
		///</summary>
		public const string New_Alias = "New-Alias";

		///<summary>
		/// Creates a new AppLocker policy from a list of file information and other rule creation options.
		///</summary>
		public const string New_AppLockerPolicy = "New-AppLockerPolicy";

		///<summary>
		/// Creates a new event.
		///</summary>
		public const string New_Event = "New-Event";

		///<summary>
		/// Creates a new event log and a new event source on a local or remote computer.
		///</summary>
		public const string New_EventLog = "New-EventLog";

		///<summary>
		/// Creates a new item.
		///</summary>
		public const string New_Item = "New-Item";

		///<summary>
		/// Creates a new property for an item and sets its value. For example, you can use New-ItemProperty to create and change registry values and data, which are properties of a registry key.
		///</summary>
		public const string New_ItemProperty = "New-ItemProperty";

		///<summary>
		/// Creates a new dynamic module that exists only in memory.
		///</summary>
		public const string New_Module = "New-Module";

		///<summary>
		/// Creates a new module manifest.
		///</summary>
		public const string New_ModuleManifest = "New-ModuleManifest";

		///<summary>
		/// Creates an instance of a Microsoft .NET Framework or Component Object Model (COM) object.
		///</summary>
		public const string New_Object = "New-Object";

		///<summary>
		/// Creates a Windows PowerShell drive in the current session.
		///</summary>
		public const string New_PSDrive = "New-PSDrive";

		///<summary>
		/// Creates a persistent connection to a local or remote computer.
		///</summary>
		public const string New_PSSession = "New-PSSession";

		///<summary>
		/// Creates an object that contains advanced options for a PSSession.
		///</summary>
		public const string New_PSSessionOption = "New-PSSessionOption";

		///<summary>
		/// Creates a new Windows service.
		///</summary>
		public const string New_Service = "New-Service";

		///<summary>
		/// Creates a TimeSpan object.
		///</summary>
		public const string New_TimeSpan = "New-TimeSpan";

		///<summary>
		/// Creates a new variable.
		///</summary>
		public const string New_Variable = "New-Variable";

		///<summary>
		/// Creates a Web service proxy object that lets you use and manage the Web service in Windows PowerShell.
		///</summary>
		public const string New_WebServiceProxy = "New-WebServiceProxy";

		///<summary>
		/// Creates a new instance of a management resource.
		///</summary>
		public const string New_WSManInstance = "New-WSManInstance";

		///<summary>
		/// Creates a WS-Management session option hash table to use as input parameters to the followingWS-Management cmdlets: Get-WSManInstance, Set-WSManInstance, Invoke-WSManAction, Connect-WSMan.
		///</summary>
		public const string New_WSManSessionOption = "New-WSManSessionOption";

		///<summary>
		/// Sends the output to the default formatter and to the default output cmdlet.
		///</summary>
		public const string Out_Default = "Out-Default";

		///<summary>
		/// Sends output to a file.
		///</summary>
		public const string Out_File = "Out-File";

		///<summary>
		/// Sends output to an interactive table in a separate window.
		///</summary>
		public const string Out_GridView = "Out-GridView";

		///<summary>
		/// Sends output to the command line.
		///</summary>
		public const string Out_Host = "Out-Host";

		///<summary>
		/// Deletes output instead of sending it to the console.
		///</summary>
		public const string Out_Null = "Out-Null";

		///<summary>
		/// Sends output to a printer.
		///</summary>
		public const string Out_Printer = "Out-Printer";

		///<summary>
		/// Sends objects to the host as a series of strings.
		///</summary>
		public const string Out_String = "Out-String";

		///<summary>
		/// Changes the current location to the location most recently pushed onto the stack. You can pop the location from the default stack or from a stack that you create by using the Push-Location cmdlet.
		///</summary>
		public const string Pop_Location = "Pop-Location";

		///<summary>
		/// Adds the current location to the top of a list of locations (a stack).
		///</summary>
		public const string Push_Location = "Push-Location";

		///<summary>
		/// Reads a line of input from the console.
		///</summary>
		public const string Read_Host = "Read-Host";

		///<summary>
		/// Gets the results of the Windows PowerShell background jobs in the current session.
		///</summary>
		public const string Receive_Job = "Receive-Job";

		///<summary>
		/// Subscribes to events that are generated by the Windows PowerShell engine and by the New-Event cmdlet.
		///</summary>
		public const string Register_EngineEvent = "Register-EngineEvent";

		///<summary>
		/// Subscribes to the events that are generated by a Microsoft .NET Framework object.
		///</summary>
		public const string Register_ObjectEvent = "Register-ObjectEvent";

		///<summary>
		/// Creates and registers a new session configuration.
		///</summary>
		public const string Register_PSSessionConfiguration = "Register-PSSessionConfiguration";

		///<summary>
		/// Subscribes to a WMI event.
		///</summary>
		public const string Register_WmiEvent = "Register-WmiEvent";

		///<summary>
		/// Cancels a BITS transfer job.
		///</summary>
		public const string Remove_BitsTransfer = "Remove-BitsTransfer";

		///<summary>
		/// Removes the local computer from a workgroup or domain.
		///</summary>
		public const string Remove_Computer = "Remove-Computer";

		///<summary>
		/// Deletes events from the event queue.
		///</summary>
		public const string Remove_Event = "Remove-Event";

		///<summary>
		/// Deletes an event log or unregisters an event source.
		///</summary>
		public const string Remove_EventLog = "Remove-EventLog";

		///<summary>
		/// Deletes the specified items.
		///</summary>
		public const string Remove_Item = "Remove-Item";

		///<summary>
		/// Deletes the property and its value from an item.
		///</summary>
		public const string Remove_ItemProperty = "Remove-ItemProperty";

		///<summary>
		/// Deletes a Windows PowerShell background job.
		///</summary>
		public const string Remove_Job = "Remove-Job";

		///<summary>
		/// Removes modules from the current session.
		///</summary>
		public const string Remove_Module = "Remove-Module";

		///<summary>
		/// Deletes breakpoints from the current console.
		///</summary>
		public const string Remove_PSBreakpoint = "Remove-PSBreakpoint";

		///<summary>
		/// Removes a Windows PowerShell drive from its location.
		///</summary>
		public const string Remove_PSDrive = "Remove-PSDrive";

		///<summary>
		/// Closes one or more Windows PSSessions.
		///</summary>
		public const string Remove_PSSession = "Remove-PSSession";

		///<summary>
		/// Removes Windows PowerShell snap-ins from the current session.
		///</summary>
		public const string Remove_PSSnapin = "Remove-PSSnapin";

		///<summary>
		/// Deletes a variable and its value.
		///</summary>
		public const string Remove_Variable = "Remove-Variable";

		///<summary>
		/// Deletes an instance of an existing WMI class.
		///</summary>
		public const string Remove_WmiObject = "Remove-WmiObject";

		///<summary>
		/// Deletes a management resource instance.
		///</summary>
		public const string Remove_WSManInstance = "Remove-WSManInstance";

		///<summary>
		/// Renames an item in a Windows PowerShell provider namespace.
		///</summary>
		public const string Rename_Item = "Rename-Item";

		///<summary>
		/// Renames a property of an item.
		///</summary>
		public const string Rename_ItemProperty = "Rename-ItemProperty";

		///<summary>
		/// Resets the machine account password for the computer.
		///</summary>
		public const string Reset_ComputerMachinePassword = "Reset-ComputerMachinePassword";

		///<summary>
		/// Resolves the wildcard characters in a path and displays the path contents.
		///</summary>
		public const string Resolve_Path = "Resolve-Path";

		///<summary>
		/// Restarts (reboots) the operating system on local and remote computers.
		///</summary>
		public const string Restart_Computer = "Restart-Computer";

		///<summary>
		/// Stops and then starts one or more services.
		///</summary>
		public const string Restart_Service = "Restart-Service";

		///<summary>
		/// Starts a system restore on the local computer.
		///</summary>
		public const string Restore_Computer = "Restore-Computer";

		///<summary>
		/// Resumes a BITS transfer job.
		///</summary>
		public const string Resume_BitsTransfer = "Resume-BitsTransfer";

		///<summary>
		/// Resumes one or more suspended (paused) services.
		///</summary>
		public const string Resume_Service = "Resume-Service";

		///<summary>
		/// Selects specified properties of an object or set of objects. It can also select unique objects from an array of objects, or it can select a specified number of objects from the beginning or end of an array of objects.
		///</summary>
		public const string Select_Object = "Select-Object";

		///<summary>
		/// Finds text in strings and files.
		///</summary>
		public const string Select_String = "Select-String";

		///<summary>
		/// Finds text in an XML string or document.
		///</summary>
		public const string Select_XML = "Select-XML";

		///<summary>
		/// Sends an e-mail message.
		///</summary>
		public const string Send_MailMessage = "Send-MailMessage";

		///<summary>
		/// Changes the security descriptor of a specified resource, such as a file or registry key.
		///</summary>
		public const string Set_Acl = "Set-Acl";

		///<summary>
		/// Creates or changes an alias (alternate name) for a cmdlet or other command element in the current Windows PSSession.
		///</summary>
		public const string Set_Alias = "Set-Alias";

		///<summary>
		/// Sets the AppLocker policy for the specified Group Policy object (GPO).
		///</summary>
		public const string Set_AppLockerPolicy = "Set-AppLockerPolicy";

		///<summary>
		/// Adds an Authenticode signature to a Windows PowerShell script or other file.
		///</summary>
		public const string Set_AuthenticodeSignature = "Set-AuthenticodeSignature";

		///<summary>
		/// Modifies the properties of an existing BITS transfer job.
		///</summary>
		public const string Set_BitsTransfer = "Set-BitsTransfer";

		///<summary>
		/// Writes or replaces the content in an item with new content.
		///</summary>
		public const string Set_Content = "Set-Content";

		///<summary>
		/// Changes the system time on the computer to a time that you specify.
		///</summary>
		public const string Set_Date = "Set-Date";

		///<summary>
		/// Changes the user preference for the Windows PowerShell execution policy.
		///</summary>
		public const string Set_ExecutionPolicy = "Set-ExecutionPolicy";

		///<summary>
		/// Changes the value of an item to the value specified in the command.
		///</summary>
		public const string Set_Item = "Set-Item";

		///<summary>
		/// Creates or changes the value of a property of an item.
		///</summary>
		public const string Set_ItemProperty = "Set-ItemProperty";

		///<summary>
		/// Sets the current working location to a specified location.
		///</summary>
		public const string Set_Location = "Set-Location";

		///<summary>
		/// Sets a breakpoint on a line, command, or variable.
		///</summary>
		public const string Set_PSBreakpoint = "Set-PSBreakpoint";

		///<summary>
		/// Turns script debugging features on and off, sets the trace level, and toggles StrictMode.
		///</summary>
		public const string Set_PSDebug = "Set-PSDebug";

		///<summary>
		/// Changes the properties of a registered session configuration.
		///</summary>
		public const string Set_PSSessionConfiguration = "Set-PSSessionConfiguration";

		///<summary>
		/// Starts, stops, and suspends a service and changes its properties.
		///</summary>
		public const string Set_Service = "Set-Service";

		///<summary>
		/// Establishes and enforces coding rules in expressions, scripts, and script blocks.
		///</summary>
		public const string Set_StrictMode = "Set-StrictMode";

		///<summary>
		/// Configures, starts, and stops a trace of Windows PowerShell components.
		///</summary>
		public const string Set_TraceSource = "Set-TraceSource";

		///<summary>
		/// Sets the value of a variable. Creates the variable if one with the requested name does not exist.
		///</summary>
		public const string Set_Variable = "Set-Variable";

		///<summary>
		/// Creates or updates an instance of an existing WMI class.
		///</summary>
		public const string Set_WmiInstance = "Set-WmiInstance";

		///<summary>
		/// Modifies the management information that is related to a resource.
		///</summary>
		public const string Set_WSManInstance = "Set-WSManInstance";

		///<summary>
		/// Configures the local computer for remote management.
		///</summary>
		public const string Set_WSManQuickConfig = "Set-WSManQuickConfig";

		///<summary>
		/// Displays the event logs of the local or a remote computer in Event Viewer.
		///</summary>
		public const string Show_EventLog = "Show-EventLog";

		///<summary>
		/// Sorts objects by property values.
		///</summary>
		public const string Sort_Object = "Sort-Object";

		///<summary>
		/// Returns the specified part of a path.
		///</summary>
		public const string Split_Path = "Split-Path";

		///<summary>
		/// Creates a new BITS transfer job.
		///</summary>
		public const string Start_BitsTransfer = "Start-BitsTransfer";

		///<summary>
		/// Starts a Windows PowerShell background job.
		///</summary>
		public const string Start_Job = "Start-Job";

		///<summary>
		/// Starts one or more processes on the local computer.
		///</summary>
		public const string Start_Process = "Start-Process";

		///<summary>
		/// Starts one or more stopped services.
		///</summary>
		public const string Start_Service = "Start-Service";

		///<summary>
		/// Suspends the activity in a script or session for the specified period of time.
		///</summary>
		public const string Start_Sleep = "Start-Sleep";

		///<summary>
		/// Starts a transaction.
		///</summary>
		public const string Start_Transaction = "Start-Transaction";

		///<summary>
		/// Creates a record of all or part of a Windows PSSession in a text file.
		///</summary>
		public const string Start_Transcript = "Start-Transcript";

		///<summary>
		/// Stops (shuts down) local and remote computers.
		///</summary>
		public const string Stop_Computer = "Stop-Computer";

		///<summary>
		/// Stops a Windows PowerShell background job.
		///</summary>
		public const string Stop_Job = "Stop-Job";

		///<summary>
		/// Stops one or more running processes.
		///</summary>
		public const string Stop_Process = "Stop-Process";

		///<summary>
		/// Stops one or more running services.
		///</summary>
		public const string Stop_Service = "Stop-Service";

		///<summary>
		/// Stops a transcript.
		///</summary>
		public const string Stop_Transcript = "Stop-Transcript";

		///<summary>
		/// Suspends a BITS transfer job.
		///</summary>
		public const string Suspend_BitsTransfer = "Suspend-BitsTransfer";

		///<summary>
		/// Suspends (pauses) one or more running services.
		///</summary>
		public const string Suspend_Service = "Suspend-Service";

		///<summary>
		/// Saves command output in a file or variable and displays it in the console.
		///</summary>
		public const string Tee_Object = "Tee-Object";

		///<summary>
		/// Tests whether the input files are allowed to run for a given user based on the specified AppLocker policy.
		///</summary>
		public const string Test_AppLockerPolicy = "Test-AppLockerPolicy";

		///<summary>
		/// Tests and repairs the secure channel between the local computer and its domain.
		///</summary>
		public const string Test_ComputerSecureChannel = "Test-ComputerSecureChannel";

		///<summary>
		/// Sends Internet Control Message Protocol (ICMP) echo request packets (pings) to one or more computers.
		///</summary>
		public const string Test_Connection = "Test-Connection";

		///<summary>
		/// Verifies that a module manifest file accurately describes the contents of a module.
		///</summary>
		public const string Test_ModuleManifest = "Test-ModuleManifest";

		///<summary>
		/// Determines whether all elements of a path exist.
		///</summary>
		public const string Test_Path = "Test-Path";

		///<summary>
		/// Tests whether the WinRM service is running on a local or remote computer.
		///</summary>
		public const string Test_WSMan = "Test-WSMan";

		///<summary>
		/// Configures and starts a trace of the specified expression or command.
		///</summary>
		public const string Trace_Command = "Trace-Command";

		///<summary>
		/// Rolls back the active transaction.
		///</summary>
		public const string Undo_Transaction = "Undo-Transaction";

		///<summary>
		/// Cancels an event subscription.
		///</summary>
		public const string Unregister_Event = "Unregister-Event";

		///<summary>
		/// Deletes registered session configurations from the computer.
		///</summary>
		public const string Unregister_PSSessionConfiguration = "Unregister-PSSessionConfiguration";

		///<summary>
		/// Updates the formatting data in the current session.
		///</summary>
		public const string Update_FormatData = "Update-FormatData";

		///<summary>
		/// Adds items to and removes items from a property value that contains a collection of objects.
		///</summary>
		public const string Update_List = "Update-List";

		///<summary>
		/// Updates the current extended type configuration by reloading the *.types.ps1xml files into memory.
		///</summary>
		public const string Update_TypeData = "Update-TypeData";

		///<summary>
		/// Adds the script block to the active transaction.
		///</summary>
		public const string Use_Transaction = "Use-Transaction";

		///<summary>
		/// Waits until a particular event is raised before continuing to run.
		///</summary>
		public const string Wait_Event = "Wait-Event";

		///<summary>
		/// Suppresses the command prompt until one or all of the Windows PowerShell background jobs running in the session are complete.
		///</summary>
		public const string Wait_Job = "Wait-Job";

		///<summary>
		/// Waits for the processes to be stopped before accepting more input.
		///</summary>
		public const string Wait_Process = "Wait-Process";

		///<summary>
		/// Creates a filter that controls which objects will be passed along a command pipeline.
		///</summary>
		public const string Where_Object = "Where-Object";

		///<summary>
		/// Writes a debug message to the console.
		///</summary>
		public const string Write_Debug = "Write-Debug";

		///<summary>
		/// Writes an object to the error stream.
		///</summary>
		public const string Write_Error = "Write-Error";

		///<summary>
		/// Writes an event to an event log.
		///</summary>
		public const string Write_EventLog = "Write-EventLog";

		///<summary>
		/// Writes customized output to a host.
		///</summary>
		public const string Write_Host = "Write-Host";

		///<summary>
		/// Sends the specified objects to the next command in the pipeline. If the command is the last command in the pipeline, the objects are displayed in the console.
		///</summary>
		public const string Write_Output = "Write-Output";

		///<summary>
		/// Displays a progress bar within a Windows PowerShell command window.
		///</summary>
		public const string Write_Progress = "Write-Progress";

		///<summary>
		/// Writes text to the verbose message stream.
		///</summary>
		public const string Write_Verbose = "Write-Verbose";

		///<summary>
		/// Writes a warning message.
		///</summary>
		public const string Write_Warning = "Write-Warning";

	}
}

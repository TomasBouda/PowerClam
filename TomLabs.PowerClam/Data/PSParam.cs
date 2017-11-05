using System;
using System.Xml.Serialization;

namespace TomLabs.PowerClam.Data
{
	/// <summary>
	/// PowerShell script parameter
	/// </summary>
	public class PSParam
	{
		/// <summary>
		/// Parameter name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Parameter type
		/// </summary>
		[XmlIgnore]
		public Type Type { get; protected set; }


		private string _typeName;
		/// <summary>
		/// Parameter type name
		/// </summary>
		public string TypeName
		{
			get { return _typeName; }
			set
			{
				_typeName = value;
				Type = ParseType(_typeName);
			}
		}

		/// <summary>
		/// Parameter value
		/// </summary>
		public object Value { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public PSParam()
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name">Param name</param>
		/// <param name="value">Param value</param>
		/// <param name="typeName">Param type</param>
		public PSParam(string name, object value, string typeName)
		{
			Name = name;
			TypeName = typeName;
			Value = HandleParamValue(value);
			Type = ParseType(TypeName);
		}

		private Type ParseType(string typeName)
		{
			return Type.GetType($"System.{FixTypeName(typeName)}");
		}

		private string FixTypeName(string typeName)
		{
			switch (typeName)
			{
				case "Int": return "Int32";
				default: return typeName;
			}
		}

		/// <summary>
		/// Escapes param value according to <see cref="TypeName"/>
		/// </summary>
		/// <param name="textValue"></param>
		/// <remarks>
		/// <see cref="string"/> value escapes with '
		/// <see cref="bool"/> value prefixes with $
		/// </remarks>
		/// <returns></returns>
		public object HandleParamValue(object textValue)
		{
			if (TypeName == "String")
			{
				if ((string)textValue == string.Empty)
				{
					return textValue;
				}
				else
				{
					return $"'{textValue}'";
				}
			}
			else if (TypeName == "Boolean")
			{
				return $"${textValue}";
			}
			else
			{
				return textValue;
			}
		}
	}
}

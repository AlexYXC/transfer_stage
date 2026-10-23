using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Filmetrics.FIMatFileDBService;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.233")]
[XmlType(Namespace = "http://www.ficorpserv.com/")]
public enum ReleaseLevel
{
	Local,
	Unreleased,
	Customer,
	Released,
	Unknown,
	Shipping,
	Deleted
}

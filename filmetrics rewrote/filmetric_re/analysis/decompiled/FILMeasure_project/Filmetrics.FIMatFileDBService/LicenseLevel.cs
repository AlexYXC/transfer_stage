using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Filmetrics.FIMatFileDBService;

[Serializable]
[XmlType(Namespace = "http://www.ficorpserv.com/")]
[GeneratedCode("System.Xml", "4.0.30319.233")]
public enum LicenseLevel
{
	Unlicensed,
	ShippingReadOnly,
	ReadOnly,
	ReadWrite,
	ReadWriteAdmin,
	ShippingReadWrite
}

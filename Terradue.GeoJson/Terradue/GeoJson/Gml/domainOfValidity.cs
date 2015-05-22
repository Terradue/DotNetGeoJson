using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class domainOfValidity
  {
    private EX_Extent_Type eX_ExtentField;
    private string nilReasonField;
    private string remoteSchemaField;

    [XmlElement(Namespace = "http://www.isotc211.org/2005/gmd")]
    public EX_Extent_Type EX_Extent
    {
      get { return eX_ExtentField; }
      set { eX_ExtentField = value; }
    }

    [XmlAttribute]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
    }
  }
}
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("ValueArray", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ValueArrayType : CompositeValueType
  {
    private string codeSpaceField;
    private string uomField;

    [XmlAttribute(DataType = "anyURI")]
    public string codeSpace
    {
      get { return codeSpaceField; }
      set { codeSpaceField = value; }
    }

    [XmlAttribute]
    public string uom
    {
      get { return uomField; }
      set { uomField = value; }
    }
  }
}
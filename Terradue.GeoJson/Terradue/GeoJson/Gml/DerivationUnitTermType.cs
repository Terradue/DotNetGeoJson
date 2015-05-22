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
  [XmlRoot("derivationUnitTerm", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DerivationUnitTermType : UnitOfMeasureType
  {
    private string exponentField;

    [XmlAttribute(DataType = "integer")]
    public string exponent
    {
      get { return exponentField; }
      set { exponentField = value; }
    }
  }
}
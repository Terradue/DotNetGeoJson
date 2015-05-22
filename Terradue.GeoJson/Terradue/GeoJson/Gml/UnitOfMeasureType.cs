using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (ConversionToPreferredUnitType))]
  [XmlInclude(typeof (DerivationUnitTermType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("unitOfMeasure", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class UnitOfMeasureType
  {
    private string uomField;

    [XmlAttribute]
    public string uom
    {
      get { return uomField; }
      set { uomField = value; }
    }
  }
}
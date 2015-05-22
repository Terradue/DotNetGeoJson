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
  [XmlRoot("conversionToPreferredUnit", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ConversionToPreferredUnitType : UnitOfMeasureType
  {
    private object itemField;

    [XmlElement("factor", typeof (double))]
    [XmlElement("formula", typeof (FormulaType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}
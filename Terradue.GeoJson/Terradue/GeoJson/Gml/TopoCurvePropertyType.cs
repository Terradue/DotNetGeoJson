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
  [XmlRoot("topoCurveProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoCurvePropertyType
  {
    private bool ownsField;
    private TopoCurveType topoCurveField;

    public TopoCurvePropertyType()
    {
      ownsField = false;
    }

    [XmlElement]
    public TopoCurveType TopoCurve
    {
      get { return topoCurveField; }
      set { topoCurveField = value; }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}
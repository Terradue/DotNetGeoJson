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
  [XmlRoot("pointMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class PointArrayPropertyType
  {
    private bool ownsField;
    private PointType[] pointField;

    public PointArrayPropertyType()
    {
      ownsField = false;
    }

    [XmlElement("Point")]
    public PointType[] Point
    {
      get { return pointField; }
      set { pointField = value; }
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
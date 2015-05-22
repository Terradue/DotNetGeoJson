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
  [XmlRoot("topoPointProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoPointPropertyType
  {
    private bool ownsField;
    private TopoPointType topoPointField;

    public TopoPointPropertyType()
    {
      ownsField = false;
    }

    [XmlElement]
    public TopoPointType TopoPoint
    {
      get { return topoPointField; }
      set { topoPointField = value; }
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
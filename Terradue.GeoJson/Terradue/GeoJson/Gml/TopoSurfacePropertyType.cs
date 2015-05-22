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
  [XmlRoot("topoSurfaceProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoSurfacePropertyType
  {
    private bool ownsField;
    private TopoSurfaceType topoSurfaceField;

    public TopoSurfacePropertyType()
    {
      ownsField = false;
    }

    [XmlElement]
    public TopoSurfaceType TopoSurface
    {
      get { return topoSurfaceField; }
      set { topoSurfaceField = value; }
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
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
  [XmlRoot("topoVolumeProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoVolumePropertyType
  {
    private bool ownsField;
    private TopoVolumeType topoVolumeField;

    public TopoVolumePropertyType()
    {
      ownsField = false;
    }

    [XmlElement]
    public TopoVolumeType TopoVolume
    {
      get { return topoVolumeField; }
      set { topoVolumeField = value; }
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
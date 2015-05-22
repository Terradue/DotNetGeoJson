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
  [XmlRoot("surfaceMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class SurfaceArrayPropertyType
  {
    private AbstractSurfaceType[] itemsField;
    private bool ownsField;

    public SurfaceArrayPropertyType()
    {
      ownsField = false;
    }

    [XmlElement("CompositeSurface", typeof (CompositeSurfaceType))]
    [XmlElement("OrientableSurface", typeof (OrientableSurfaceType))]
    [XmlElement("Polygon", typeof (PolygonType))]
    [XmlElement("Surface", typeof (SurfaceType))]
    public PolygonType[] Items
    {
      get { return itemsField as PolygonType[]; }
      set { itemsField = value; }
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
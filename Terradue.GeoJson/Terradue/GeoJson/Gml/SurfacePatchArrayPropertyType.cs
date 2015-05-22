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
  [XmlRoot("patches", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public class SurfacePatchArrayPropertyType
  {
    private AbstractSurfacePatchType[] itemsField;

    [XmlElement("PolygonPatch", typeof (PolygonPatchType))]
    [XmlElement("Rectangle", typeof (RectangleType))]
    [XmlElement("Triangle", typeof (TriangleType))]
    public AbstractSurfacePatchType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }
  }
}
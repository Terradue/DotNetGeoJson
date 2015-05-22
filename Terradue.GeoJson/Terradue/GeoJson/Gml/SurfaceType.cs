using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (TinType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("Surface", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public class SurfaceType : AbstractSurfaceType
  {
    private ItemChoiceType2 itemElementNameField;
    private SurfacePatchArrayPropertyType itemField;

    [XmlElement("patches", typeof (SurfacePatchArrayPropertyType))]
    [XmlElement("polygonPatches", typeof (SurfacePatchArrayPropertyType))]
    [XmlElement("trianglePatches", typeof (SurfacePatchArrayPropertyType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public SurfacePatchArrayPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType2 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }
  }
}
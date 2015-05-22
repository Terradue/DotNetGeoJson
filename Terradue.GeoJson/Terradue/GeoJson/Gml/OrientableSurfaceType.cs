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
  [XmlRoot("OrientableSurface", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class OrientableSurfaceType : AbstractSurfaceType
  {
    private SurfacePropertyType baseSurfaceField;
    private SignType orientationField;

    public OrientableSurfaceType()
    {
      orientationField = SignType.Item1;
    }

    [XmlElement]
    public SurfacePropertyType baseSurface
    {
      get { return baseSurfaceField; }
      set { baseSurfaceField = value; }
    }

    [XmlAttribute]
    [DefaultValue(SignType.Item1)]
    public SignType orientation
    {
      get { return orientationField; }
      set { orientationField = value; }
    }
  }
}
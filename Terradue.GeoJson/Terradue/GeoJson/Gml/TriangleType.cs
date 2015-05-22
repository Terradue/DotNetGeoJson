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
  [XmlRoot("Triangle", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TriangleType : AbstractSurfacePatchType
  {
    private AbstractRingPropertyType exteriorField;
    private SurfaceInterpolationType interpolationField;
    private bool interpolationFieldSpecified;

    public TriangleType()
    {
      interpolationField = SurfaceInterpolationType.planar;
    }

    [XmlElement]
    public AbstractRingPropertyType exterior
    {
      get { return exteriorField; }
      set { exteriorField = value; }
    }

    [XmlAttribute]
    public SurfaceInterpolationType interpolation
    {
      get { return interpolationField; }
      set { interpolationField = value; }
    }

    [XmlIgnore]
    public bool interpolationSpecified
    {
      get { return interpolationFieldSpecified; }
      set { interpolationFieldSpecified = value; }
    }
  }
}
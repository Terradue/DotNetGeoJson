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
  [XmlRoot("PolygonPatch", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class PolygonPatchType : AbstractSurfacePatchType
  {
    private AbstractRingPropertyType exteriorField;
    private AbstractRingPropertyType[] interiorField;
    private SurfaceInterpolationType interpolationField;
    private bool interpolationFieldSpecified;

    public PolygonPatchType()
    {
      interpolationField = SurfaceInterpolationType.planar;
    }

    [XmlElement]
    public AbstractRingPropertyType exterior
    {
      get { return exteriorField; }
      set { exteriorField = value; }
    }

    [XmlElement("interior")]
    public AbstractRingPropertyType[] interior
    {
      get { return interiorField; }
      set { interiorField = value; }
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
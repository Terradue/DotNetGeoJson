namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Triangle", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TriangleType : AbstractSurfacePatchType
  {

    private AbstractRingPropertyType exteriorField;

    private SurfaceInterpolationType interpolationField;

    private bool interpolationFieldSpecified;

    public TriangleType()
    {
      interpolationField = SurfaceInterpolationType.planar;
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public AbstractRingPropertyType exterior
    {
      get { return exteriorField; }
      set { exteriorField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SurfaceInterpolationType interpolation
    {
      get { return interpolationField; }
      set { interpolationField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool interpolationSpecified
    {
      get { return interpolationFieldSpecified; }
      set { interpolationFieldSpecified = value; }
    }
  }
}
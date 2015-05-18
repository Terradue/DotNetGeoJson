namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Clothoid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ClothoidType : AbstractCurveSegmentType
  {

    private ClothoidTypeRefLocation refLocationField;

    private decimal scaleFactorField;

    private double startParameterField;

    private double endParameterField;

    private CurveInterpolationType interpolationField;

    private bool interpolationFieldSpecified;

    public ClothoidType()
    {
      interpolationField = CurveInterpolationType.clothoid;
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public ClothoidTypeRefLocation refLocation
    {
      get { return refLocationField; }
      set { refLocationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public decimal scaleFactor
    {
      get { return scaleFactorField; }
      set { scaleFactorField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public double startParameter
    {
      get { return startParameterField; }
      set { startParameterField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public double endParameter
    {
      get { return endParameterField; }
      set { endParameterField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CurveInterpolationType interpolation
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
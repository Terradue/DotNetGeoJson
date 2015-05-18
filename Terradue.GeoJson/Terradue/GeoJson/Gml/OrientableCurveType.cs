namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("OrientableCurve", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class OrientableCurveType : AbstractCurveType
  {

    private CurvePropertyType baseCurveField;

    private SignType orientationField;

    public OrientableCurveType()
    {
      orientationField = SignType.Item1;
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CurvePropertyType baseCurve
    {
      get { return baseCurveField; }
      set { baseCurveField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
    public SignType orientation
    {
      get { return orientationField; }
      set { orientationField = value; }
    }
  }
}
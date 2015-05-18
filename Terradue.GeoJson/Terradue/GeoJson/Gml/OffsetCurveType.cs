namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("OffsetCurve", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class OffsetCurveType : AbstractCurveSegmentType
  {

    private CurvePropertyType offsetBaseField;

    private LengthType distanceField;

    private VectorType refDirectionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CurvePropertyType offsetBase
    {
      get { return offsetBaseField; }
      set { offsetBaseField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public LengthType distance
    {
      get { return distanceField; }
      set { distanceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public VectorType refDirection
    {
      get { return refDirectionField; }
      set { refDirectionField = value; }
    }
  }
}
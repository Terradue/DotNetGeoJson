namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeodesicType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("GeodesicString", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class GeodesicStringType : AbstractCurveSegmentType
  {

    private object itemField;

    private CurveInterpolationType interpolationField;

    private bool interpolationFieldSpecified;

    public GeodesicStringType()
    {
      interpolationField = CurveInterpolationType.geodesic;
    }

    [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof (PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof (DirectPositionType))]
    [System.Xml.Serialization.XmlElementAttribute("posList", typeof (DirectPositionListType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
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
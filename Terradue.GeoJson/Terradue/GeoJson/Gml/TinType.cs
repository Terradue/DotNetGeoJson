namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Tin", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class TinType : SurfaceType
  {

    private LineStringSegmentArrayPropertyType[] stopLinesField;

    private LineStringSegmentArrayPropertyType[] breakLinesField;

    private LengthType maxLengthField;

    private TinTypeControlPoint controlPointField;

    [System.Xml.Serialization.XmlElementAttribute("stopLines")]
    public LineStringSegmentArrayPropertyType[] stopLines
    {
      get { return stopLinesField; }
      set { stopLinesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("breakLines")]
    public LineStringSegmentArrayPropertyType[] breakLines
    {
      get { return breakLinesField; }
      set { breakLinesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public LengthType maxLength
    {
      get { return maxLengthField; }
      set { maxLengthField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TinTypeControlPoint controlPoint
    {
      get { return controlPointField; }
      set { controlPointField = value; }
    }
  }
}
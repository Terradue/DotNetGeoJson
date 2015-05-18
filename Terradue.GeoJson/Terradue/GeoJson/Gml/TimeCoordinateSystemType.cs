namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TimeCoordinateSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimeCoordinateSystemType : TimeReferenceSystemType
  {

    private object itemField;

    private TimeIntervalLengthType intervalField;

    [System.Xml.Serialization.XmlElementAttribute("origin", typeof (TimeInstantPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("originPosition", typeof (TimePositionType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimeIntervalLengthType interval
    {
      get { return intervalField; }
      set { intervalField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TimeClock", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimeClockType : TimeReferenceSystemType
  {

    private StringOrRefType referenceEventField;

    private System.DateTime referenceTimeField;

    private System.DateTime utcReferenceField;

    private TimeCalendarPropertyType[] dateBasisField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public StringOrRefType referenceEvent
    {
      get { return referenceEventField; }
      set { referenceEventField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
    public System.DateTime referenceTime
    {
      get { return referenceTimeField; }
      set { referenceTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
    public System.DateTime utcReference
    {
      get { return utcReferenceField; }
      set { utcReferenceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("dateBasis")]
    public TimeCalendarPropertyType[] dateBasis
    {
      get { return dateBasisField; }
      set { dateBasisField = value; }
    }
  }
}
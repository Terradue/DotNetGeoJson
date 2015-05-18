namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TimeCalendar", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimeCalendarType : TimeReferenceSystemType
  {

    private TimeCalendarEraPropertyType[] referenceFrameField;

    [System.Xml.Serialization.XmlElementAttribute("referenceFrame")]
    public TimeCalendarEraPropertyType[] referenceFrame
    {
      get { return referenceFrameField; }
      set { referenceFrameField = value; }
    }
  }
}
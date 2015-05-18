namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TimeCalendarEra", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimeCalendarEraType : DefinitionType
  {

    private StringOrRefType referenceEventField;

    private string referenceDateField;

    private decimal julianReferenceField;

    private TimePeriodPropertyType epochOfUseField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public StringOrRefType referenceEvent
    {
      get { return referenceEventField; }
      set { referenceEventField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public string referenceDate
    {
      get { return referenceDateField; }
      set { referenceDateField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public decimal julianReference
    {
      get { return julianReferenceField; }
      set { julianReferenceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimePeriodPropertyType epochOfUse
    {
      get { return epochOfUseField; }
      set { epochOfUseField = value; }
    }
  }
}
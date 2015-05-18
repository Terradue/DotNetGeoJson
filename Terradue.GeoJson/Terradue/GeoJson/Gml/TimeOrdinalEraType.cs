namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TimeOrdinalEra", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimeOrdinalEraType : DefinitionType
  {

    private RelatedTimeType[] relatedTimeField;

    private TimeNodePropertyType startField;

    private TimeNodePropertyType endField;

    private TimePeriodPropertyType extentField;

    private TimeOrdinalEraPropertyType[] memberField;

    private ReferenceType groupField;

    [System.Xml.Serialization.XmlElementAttribute("relatedTime")]
    public RelatedTimeType[] relatedTime
    {
      get { return relatedTimeField; }
      set { relatedTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimeNodePropertyType start
    {
      get { return startField; }
      set { startField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimeNodePropertyType end
    {
      get { return endField; }
      set { endField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimePeriodPropertyType extent
    {
      get { return extentField; }
      set { extentField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("member")]
    public TimeOrdinalEraPropertyType[] member
    {
      get { return memberField; }
      set { memberField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public ReferenceType group
    {
      get { return groupField; }
      set { groupField = value; }
    }
  }
}
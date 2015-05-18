namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeOrdinalReferenceSystemType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeClockType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeCalendarType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeCoordinateSystemType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TimeReferenceSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimeReferenceSystemType : DefinitionType
  {

    private string domainOfValidityField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public string domainOfValidity
    {
      get { return domainOfValidityField; }
      set { domainOfValidityField = value; }
    }
  }
}
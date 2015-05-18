namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TimeOrdinalReferenceSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimeOrdinalReferenceSystemType : TimeReferenceSystemType
  {

    private TimeOrdinalEraPropertyType[] componentField;

    [System.Xml.Serialization.XmlElementAttribute("component")]
    public TimeOrdinalEraPropertyType[] component
    {
      get { return componentField; }
      set { componentField = value; }
    }
  }
}
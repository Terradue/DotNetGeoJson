namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public partial class DirectionDescriptionType
  {

    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("compassPoint", typeof (CompassPointEnumeration))]
    [System.Xml.Serialization.XmlElementAttribute("description", typeof (string))]
    [System.Xml.Serialization.XmlElementAttribute("keyword", typeof (CodeType))]
    [System.Xml.Serialization.XmlElementAttribute("reference", typeof (ReferenceType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}
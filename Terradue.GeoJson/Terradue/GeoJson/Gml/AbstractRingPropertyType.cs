namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("exterior", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class AbstractRingPropertyType
  {

    private AbstractRingType itemField;

    [System.Xml.Serialization.XmlElementAttribute("LinearRing", typeof (LinearRingType))]
    [System.Xml.Serialization.XmlElementAttribute("Ring", typeof (RingType))]
    public AbstractRingType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}
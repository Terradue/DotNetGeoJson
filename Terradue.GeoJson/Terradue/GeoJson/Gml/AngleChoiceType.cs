namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public partial class AngleChoiceType
  {

    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("angle", typeof (AngleType))]
    [System.Xml.Serialization.XmlElementAttribute("dmsAngle", typeof (DMSAngleType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}
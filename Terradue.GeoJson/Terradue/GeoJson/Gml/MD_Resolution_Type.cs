namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Resolution_Type
  {

    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("distance", typeof (Distance_PropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("equivalentScale", typeof (MD_RepresentativeFraction_PropertyType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}
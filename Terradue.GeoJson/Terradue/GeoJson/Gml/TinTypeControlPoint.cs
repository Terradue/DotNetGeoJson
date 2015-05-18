namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml/3.2")]
  public partial class TinTypeControlPoint
  {

    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof (PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof (DirectPositionType))]
    [System.Xml.Serialization.XmlElementAttribute("posList", typeof (DirectPositionListType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}
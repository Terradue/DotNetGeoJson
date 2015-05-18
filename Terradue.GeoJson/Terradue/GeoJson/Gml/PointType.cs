namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Point", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class PointType : AbstractGeometricPrimitiveType
  {

    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof (CoordinatesType))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof (DirectPositionType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class EX_BoundingPolygon_Type : AbstractEX_GeographicExtent_Type
  {

    private GM_Object_PropertyType[] polygonField;

    [System.Xml.Serialization.XmlElementAttribute("polygon")]
    public GM_Object_PropertyType[] polygon
    {
      get { return polygonField; }
      set { polygonField = value; }
    }
  }
}
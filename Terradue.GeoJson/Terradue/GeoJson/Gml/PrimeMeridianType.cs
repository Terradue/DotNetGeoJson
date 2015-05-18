namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("PrimeMeridian", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class PrimeMeridianType : IdentifiedObjectType
  {

    private AngleType greenwichLongitudeField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public AngleType greenwichLongitude
    {
      get { return greenwichLongitudeField; }
      set { greenwichLongitudeField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class EX_GeographicDescription_Type : AbstractEX_GeographicExtent_Type
  {

    private MD_Identifier_PropertyType geographicIdentifierField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_Identifier_PropertyType geographicIdentifier
    {
      get { return geographicIdentifierField; }
      set { geographicIdentifierField = value; }
    }
  }
}
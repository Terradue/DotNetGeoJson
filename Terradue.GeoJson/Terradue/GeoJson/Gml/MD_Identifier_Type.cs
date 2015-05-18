namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (RS_Identifier_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Identifier_Type : AbstractObject_Type
  {

    private CI_Citation_PropertyType authorityField;

    private CharacterString_PropertyType codeField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Citation_PropertyType authority
    {
      get { return authorityField; }
      set { authorityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType code
    {
      get { return codeField; }
      set { codeField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MD_SecurityConstraints_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MD_LegalConstraints_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Constraints_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType[] useLimitationField;

    [System.Xml.Serialization.XmlElementAttribute("useLimitation")]
    public CharacterString_PropertyType[] useLimitation
    {
      get { return useLimitationField; }
      set { useLimitationField = value; }
    }
  }
}
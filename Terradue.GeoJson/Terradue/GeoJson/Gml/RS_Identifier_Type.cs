namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class RS_Identifier_Type : MD_Identifier_Type
  {

    private CharacterString_PropertyType codeSpaceField;

    private CharacterString_PropertyType versionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType codeSpace
    {
      get { return codeSpaceField; }
      set { codeSpaceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType version
    {
      get { return versionField; }
      set { versionField = value; }
    }
  }
}
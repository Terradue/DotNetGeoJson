namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Keywords_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType[] keywordField;

    private MD_KeywordTypeCode_PropertyType typeField;

    private CI_Citation_PropertyType thesaurusNameField;

    [System.Xml.Serialization.XmlElementAttribute("keyword")]
    public CharacterString_PropertyType[] keyword
    {
      get { return keywordField; }
      set { keywordField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_KeywordTypeCode_PropertyType type
    {
      get { return typeField; }
      set { typeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Citation_PropertyType thesaurusName
    {
      get { return thesaurusNameField; }
      set { thesaurusNameField = value; }
    }
  }
}
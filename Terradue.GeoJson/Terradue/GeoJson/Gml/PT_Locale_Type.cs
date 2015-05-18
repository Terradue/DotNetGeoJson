namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class PT_Locale_Type : AbstractObject_Type
  {

    private LanguageCode_PropertyType languageCodeField;

    private Country_PropertyType countryField;

    private MD_CharacterSetCode_PropertyType characterEncodingField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public LanguageCode_PropertyType languageCode
    {
      get { return languageCodeField; }
      set { languageCodeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Country_PropertyType country
    {
      get { return countryField; }
      set { countryField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_CharacterSetCode_PropertyType characterEncoding
    {
      get { return characterEncodingField; }
      set { characterEncodingField = value; }
    }
  }
}
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class PT_Locale_Type : AbstractObject_Type
  {
    private MD_CharacterSetCode_PropertyType characterEncodingField;
    private Country_PropertyType countryField;
    private LanguageCode_PropertyType languageCodeField;

    [XmlElement]
    public LanguageCode_PropertyType languageCode
    {
      get { return languageCodeField; }
      set { languageCodeField = value; }
    }

    [XmlElement]
    public Country_PropertyType country
    {
      get { return countryField; }
      set { countryField = value; }
    }

    [XmlElement]
    public MD_CharacterSetCode_PropertyType characterEncoding
    {
      get { return characterEncodingField; }
      set { characterEncodingField = value; }
    }
  }
}
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
  public class MD_Keywords_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType[] keywordField;
    private CI_Citation_PropertyType thesaurusNameField;
    private MD_KeywordTypeCode_PropertyType typeField;

    [XmlElement("keyword")]
    public CharacterString_PropertyType[] keyword
    {
      get { return keywordField; }
      set { keywordField = value; }
    }

    [XmlElement]
    public MD_KeywordTypeCode_PropertyType type
    {
      get { return typeField; }
      set { typeField = value; }
    }

    [XmlElement]
    public CI_Citation_PropertyType thesaurusName
    {
      get { return thesaurusNameField; }
      set { thesaurusNameField = value; }
    }
  }
}
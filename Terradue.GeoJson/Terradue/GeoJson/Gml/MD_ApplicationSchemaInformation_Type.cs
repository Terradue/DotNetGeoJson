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
  public class MD_ApplicationSchemaInformation_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType constraintLanguageField;
    private Binary_PropertyType graphicsFileField;
    private CI_Citation_PropertyType nameField;
    private CharacterString_PropertyType schemaAsciiField;
    private CharacterString_PropertyType schemaLanguageField;
    private Binary_PropertyType softwareDevelopmentFileField;
    private CharacterString_PropertyType softwareDevelopmentFileFormatField;

    [XmlElement]
    public CI_Citation_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType schemaLanguage
    {
      get { return schemaLanguageField; }
      set { schemaLanguageField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType constraintLanguage
    {
      get { return constraintLanguageField; }
      set { constraintLanguageField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType schemaAscii
    {
      get { return schemaAsciiField; }
      set { schemaAsciiField = value; }
    }

    [XmlElement]
    public Binary_PropertyType graphicsFile
    {
      get { return graphicsFileField; }
      set { graphicsFileField = value; }
    }

    [XmlElement]
    public Binary_PropertyType softwareDevelopmentFile
    {
      get { return softwareDevelopmentFileField; }
      set { softwareDevelopmentFileField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType softwareDevelopmentFileFormat
    {
      get { return softwareDevelopmentFileFormatField; }
      set { softwareDevelopmentFileFormatField = value; }
    }
  }
}
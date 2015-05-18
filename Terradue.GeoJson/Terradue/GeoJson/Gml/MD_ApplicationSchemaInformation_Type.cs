namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_ApplicationSchemaInformation_Type : AbstractObject_Type
  {

    private CI_Citation_PropertyType nameField;

    private CharacterString_PropertyType schemaLanguageField;

    private CharacterString_PropertyType constraintLanguageField;

    private CharacterString_PropertyType schemaAsciiField;

    private Binary_PropertyType graphicsFileField;

    private Binary_PropertyType softwareDevelopmentFileField;

    private CharacterString_PropertyType softwareDevelopmentFileFormatField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Citation_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType schemaLanguage
    {
      get { return schemaLanguageField; }
      set { schemaLanguageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType constraintLanguage
    {
      get { return constraintLanguageField; }
      set { constraintLanguageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType schemaAscii
    {
      get { return schemaAsciiField; }
      set { schemaAsciiField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Binary_PropertyType graphicsFile
    {
      get { return graphicsFileField; }
      set { graphicsFileField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Binary_PropertyType softwareDevelopmentFile
    {
      get { return softwareDevelopmentFileField; }
      set { softwareDevelopmentFileField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType softwareDevelopmentFileFormat
    {
      get { return softwareDevelopmentFileFormatField; }
      set { softwareDevelopmentFileFormatField = value; }
    }
  }
}
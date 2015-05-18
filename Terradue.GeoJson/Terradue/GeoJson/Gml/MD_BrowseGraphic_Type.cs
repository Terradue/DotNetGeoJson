namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_BrowseGraphic_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType fileNameField;

    private CharacterString_PropertyType fileDescriptionField;

    private CharacterString_PropertyType fileTypeField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType fileName
    {
      get { return fileNameField; }
      set { fileNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType fileDescription
    {
      get { return fileDescriptionField; }
      set { fileDescriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType fileType
    {
      get { return fileTypeField; }
      set { fileTypeField = value; }
    }
  }
}
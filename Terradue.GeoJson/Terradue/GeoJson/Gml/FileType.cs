namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("File", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class FileType
  {

    private AssociationRoleType rangeParametersField;

    private string itemField;

    private ItemChoiceType18 itemElementNameField;

    private CodeType fileStructureField;

    private string mimeTypeField;

    private string compressionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public AssociationRoleType rangeParameters
    {
      get { return rangeParametersField; }
      set { rangeParametersField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("fileName", typeof (string), DataType = "anyURI")]
    [System.Xml.Serialization.XmlElementAttribute("fileReference", typeof (string), DataType = "anyURI")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType18 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CodeType fileStructure
    {
      get { return fileStructureField; }
      set { fileStructureField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
    public string mimeType
    {
      get { return mimeTypeField; }
      set { mimeTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
    public string compression
    {
      get { return compressionField; }
      set { compressionField = value; }
    }
  }
}
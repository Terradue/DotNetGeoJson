namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Format_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType nameField;

    private CharacterString_PropertyType versionField;

    private CharacterString_PropertyType amendmentNumberField;

    private CharacterString_PropertyType specificationField;

    private CharacterString_PropertyType fileDecompressionTechniqueField;

    private MD_Distributor_PropertyType[] formatDistributorField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType version
    {
      get { return versionField; }
      set { versionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType amendmentNumber
    {
      get { return amendmentNumberField; }
      set { amendmentNumberField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType specification
    {
      get { return specificationField; }
      set { specificationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType fileDecompressionTechnique
    {
      get { return fileDecompressionTechniqueField; }
      set { fileDecompressionTechniqueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("formatDistributor")]
    public MD_Distributor_PropertyType[] formatDistributor
    {
      get { return formatDistributorField; }
      set { formatDistributorField = value; }
    }
  }
}
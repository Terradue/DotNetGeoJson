namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_DataIdentification_Type : AbstractMD_Identification_Type
  {

    private MD_SpatialRepresentationTypeCode_PropertyType[] spatialRepresentationTypeField;

    private MD_Resolution_PropertyType[] spatialResolutionField;

    private CharacterString_PropertyType[] languageField;

    private MD_CharacterSetCode_PropertyType[] characterSetField;

    private MD_TopicCategoryCode_PropertyType[] topicCategoryField;

    private CharacterString_PropertyType environmentDescriptionField;

    private EX_Extent_PropertyType[] extentField;

    private CharacterString_PropertyType supplementalInformationField;

    [System.Xml.Serialization.XmlElementAttribute("spatialRepresentationType")]
    public MD_SpatialRepresentationTypeCode_PropertyType[] spatialRepresentationType
    {
      get { return spatialRepresentationTypeField; }
      set { spatialRepresentationTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("spatialResolution")]
    public MD_Resolution_PropertyType[] spatialResolution
    {
      get { return spatialResolutionField; }
      set { spatialResolutionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("language")]
    public CharacterString_PropertyType[] language
    {
      get { return languageField; }
      set { languageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("characterSet")]
    public MD_CharacterSetCode_PropertyType[] characterSet
    {
      get { return characterSetField; }
      set { characterSetField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("topicCategory")]
    public MD_TopicCategoryCode_PropertyType[] topicCategory
    {
      get { return topicCategoryField; }
      set { topicCategoryField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType environmentDescription
    {
      get { return environmentDescriptionField; }
      set { environmentDescriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("extent")]
    public EX_Extent_PropertyType[] extent
    {
      get { return extentField; }
      set { extentField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType supplementalInformation
    {
      get { return supplementalInformationField; }
      set { supplementalInformationField = value; }
    }
  }
}
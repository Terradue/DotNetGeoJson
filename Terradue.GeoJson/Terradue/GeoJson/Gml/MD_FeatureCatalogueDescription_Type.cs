namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_FeatureCatalogueDescription_Type : AbstractMD_ContentInformation_Type
  {

    private Boolean_PropertyType complianceCodeField;

    private CharacterString_PropertyType[] languageField;

    private Boolean_PropertyType includedWithDatasetField;

    private GenericName_PropertyType[] featureTypesField;

    private CI_Citation_PropertyType[] featureCatalogueCitationField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType complianceCode
    {
      get { return complianceCodeField; }
      set { complianceCodeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("language")]
    public CharacterString_PropertyType[] language
    {
      get { return languageField; }
      set { languageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType includedWithDataset
    {
      get { return includedWithDatasetField; }
      set { includedWithDatasetField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("featureTypes")]
    public GenericName_PropertyType[] featureTypes
    {
      get { return featureTypesField; }
      set { featureTypesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("featureCatalogueCitation")]
    public CI_Citation_PropertyType[] featureCatalogueCitation
    {
      get { return featureCatalogueCitationField; }
      set { featureCatalogueCitationField = value; }
    }
  }
}
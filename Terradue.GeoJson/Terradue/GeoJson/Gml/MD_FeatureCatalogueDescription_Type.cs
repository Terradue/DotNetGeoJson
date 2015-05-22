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
  public class MD_FeatureCatalogueDescription_Type : AbstractMD_ContentInformation_Type
  {
    private Boolean_PropertyType complianceCodeField;
    private CI_Citation_PropertyType[] featureCatalogueCitationField;
    private GenericName_PropertyType[] featureTypesField;
    private Boolean_PropertyType includedWithDatasetField;
    private CharacterString_PropertyType[] languageField;

    [XmlElement]
    public Boolean_PropertyType complianceCode
    {
      get { return complianceCodeField; }
      set { complianceCodeField = value; }
    }

    [XmlElement("language")]
    public CharacterString_PropertyType[] language
    {
      get { return languageField; }
      set { languageField = value; }
    }

    [XmlElement]
    public Boolean_PropertyType includedWithDataset
    {
      get { return includedWithDatasetField; }
      set { includedWithDatasetField = value; }
    }

    [XmlElement("featureTypes")]
    public GenericName_PropertyType[] featureTypes
    {
      get { return featureTypesField; }
      set { featureTypesField = value; }
    }

    [XmlElement("featureCatalogueCitation")]
    public CI_Citation_PropertyType[] featureCatalogueCitation
    {
      get { return featureCatalogueCitationField; }
      set { featureCatalogueCitationField = value; }
    }
  }
}
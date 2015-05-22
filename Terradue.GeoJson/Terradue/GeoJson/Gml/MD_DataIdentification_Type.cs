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
  public class MD_DataIdentification_Type : AbstractMD_Identification_Type
  {
    private MD_CharacterSetCode_PropertyType[] characterSetField;
    private CharacterString_PropertyType environmentDescriptionField;
    private EX_Extent_PropertyType[] extentField;
    private CharacterString_PropertyType[] languageField;
    private MD_SpatialRepresentationTypeCode_PropertyType[] spatialRepresentationTypeField;
    private MD_Resolution_PropertyType[] spatialResolutionField;
    private CharacterString_PropertyType supplementalInformationField;
    private MD_TopicCategoryCode_PropertyType[] topicCategoryField;

    [XmlElement("spatialRepresentationType")]
    public MD_SpatialRepresentationTypeCode_PropertyType[] spatialRepresentationType
    {
      get { return spatialRepresentationTypeField; }
      set { spatialRepresentationTypeField = value; }
    }

    [XmlElement("spatialResolution")]
    public MD_Resolution_PropertyType[] spatialResolution
    {
      get { return spatialResolutionField; }
      set { spatialResolutionField = value; }
    }

    [XmlElement("language")]
    public CharacterString_PropertyType[] language
    {
      get { return languageField; }
      set { languageField = value; }
    }

    [XmlElement("characterSet")]
    public MD_CharacterSetCode_PropertyType[] characterSet
    {
      get { return characterSetField; }
      set { characterSetField = value; }
    }

    [XmlElement("topicCategory")]
    public MD_TopicCategoryCode_PropertyType[] topicCategory
    {
      get { return topicCategoryField; }
      set { topicCategoryField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType environmentDescription
    {
      get { return environmentDescriptionField; }
      set { environmentDescriptionField = value; }
    }

    [XmlElement("extent")]
    public EX_Extent_PropertyType[] extent
    {
      get { return extentField; }
      set { extentField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType supplementalInformation
    {
      get { return supplementalInformationField; }
      set { supplementalInformationField = value; }
    }
  }
}
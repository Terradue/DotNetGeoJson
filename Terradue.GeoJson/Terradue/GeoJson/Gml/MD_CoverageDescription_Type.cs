using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (MD_ImageDescription_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class MD_CoverageDescription_Type : AbstractMD_ContentInformation_Type
  {
    private RecordType_PropertyType attributeDescriptionField;
    private MD_CoverageContentTypeCode_PropertyType contentTypeField;
    private MD_RangeDimension_PropertyType[] dimensionField;

    [XmlElement]
    public RecordType_PropertyType attributeDescription
    {
      get { return attributeDescriptionField; }
      set { attributeDescriptionField = value; }
    }

    [XmlElement]
    public MD_CoverageContentTypeCode_PropertyType contentType
    {
      get { return contentTypeField; }
      set { contentTypeField = value; }
    }

    [XmlElement("dimension")]
    public MD_RangeDimension_PropertyType[] dimension
    {
      get { return dimensionField; }
      set { dimensionField = value; }
    }
  }
}
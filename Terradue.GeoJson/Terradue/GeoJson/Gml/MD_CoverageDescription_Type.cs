namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MD_ImageDescription_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_CoverageDescription_Type : AbstractMD_ContentInformation_Type
  {

    private RecordType_PropertyType attributeDescriptionField;

    private MD_CoverageContentTypeCode_PropertyType contentTypeField;

    private MD_RangeDimension_PropertyType[] dimensionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public RecordType_PropertyType attributeDescription
    {
      get { return attributeDescriptionField; }
      set { attributeDescriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_CoverageContentTypeCode_PropertyType contentType
    {
      get { return contentTypeField; }
      set { contentTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("dimension")]
    public MD_RangeDimension_PropertyType[] dimension
    {
      get { return dimensionField; }
      set { dimensionField = value; }
    }
  }
}
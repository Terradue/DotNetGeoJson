namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_MetadataExtensionInformation_Type : AbstractObject_Type
  {

    private CI_OnlineResource_PropertyType extensionOnLineResourceField;

    private MD_ExtendedElementInformation_PropertyType[] extendedElementInformationField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_OnlineResource_PropertyType extensionOnLineResource
    {
      get { return extensionOnLineResourceField; }
      set { extensionOnLineResourceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("extendedElementInformation")]
    public MD_ExtendedElementInformation_PropertyType[] extendedElementInformation
    {
      get { return extendedElementInformationField; }
      set { extendedElementInformationField = value; }
    }
  }
}
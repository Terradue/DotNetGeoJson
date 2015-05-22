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
  public class MD_MetadataExtensionInformation_Type : AbstractObject_Type
  {
    private MD_ExtendedElementInformation_PropertyType[] extendedElementInformationField;
    private CI_OnlineResource_PropertyType extensionOnLineResourceField;

    [XmlElement]
    public CI_OnlineResource_PropertyType extensionOnLineResource
    {
      get { return extensionOnLineResourceField; }
      set { extensionOnLineResourceField = value; }
    }

    [XmlElement("extendedElementInformation")]
    public MD_ExtendedElementInformation_PropertyType[] extendedElementInformation
    {
      get { return extendedElementInformationField; }
      set { extendedElementInformationField = value; }
    }
  }
}
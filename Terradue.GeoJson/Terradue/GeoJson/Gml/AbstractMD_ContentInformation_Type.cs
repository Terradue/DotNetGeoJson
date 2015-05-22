using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (MD_CoverageDescription_Type))]
  [XmlInclude(typeof (MD_ImageDescription_Type))]
  [XmlInclude(typeof (MD_FeatureCatalogueDescription_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract class AbstractMD_ContentInformation_Type : AbstractObject_Type
  {
  }
}
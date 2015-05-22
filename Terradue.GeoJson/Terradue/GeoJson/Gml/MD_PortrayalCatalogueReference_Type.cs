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
  public class MD_PortrayalCatalogueReference_Type : AbstractObject_Type
  {
    private CI_Citation_PropertyType[] portrayalCatalogueCitationField;

    [XmlElement("portrayalCatalogueCitation")]
    public CI_Citation_PropertyType[] portrayalCatalogueCitation
    {
      get { return portrayalCatalogueCitationField; }
      set { portrayalCatalogueCitationField = value; }
    }
  }
}
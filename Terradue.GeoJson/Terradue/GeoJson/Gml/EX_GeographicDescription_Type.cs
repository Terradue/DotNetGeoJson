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
  public class EX_GeographicDescription_Type : AbstractEX_GeographicExtent_Type
  {
    private MD_Identifier_PropertyType geographicIdentifierField;

    [XmlElement]
    public MD_Identifier_PropertyType geographicIdentifier
    {
      get { return geographicIdentifierField; }
      set { geographicIdentifierField = value; }
    }
  }
}
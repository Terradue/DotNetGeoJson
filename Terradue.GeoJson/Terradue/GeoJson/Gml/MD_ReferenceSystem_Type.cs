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
  public class MD_ReferenceSystem_Type : AbstractObject_Type
  {
    private RS_Identifier_PropertyType referenceSystemIdentifierField;

    [XmlElement]
    public RS_Identifier_PropertyType referenceSystemIdentifier
    {
      get { return referenceSystemIdentifierField; }
      set { referenceSystemIdentifierField = value; }
    }
  }
}
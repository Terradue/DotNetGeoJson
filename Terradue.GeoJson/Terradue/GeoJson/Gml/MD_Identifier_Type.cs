using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (RS_Identifier_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class MD_Identifier_Type : AbstractObject_Type
  {
    private CI_Citation_PropertyType authorityField;
    private CharacterString_PropertyType codeField;

    [XmlElement]
    public CI_Citation_PropertyType authority
    {
      get { return authorityField; }
      set { authorityField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType code
    {
      get { return codeField; }
      set { codeField = value; }
    }
  }
}
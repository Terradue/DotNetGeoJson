using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (MD_SecurityConstraints_Type))]
  [XmlInclude(typeof (MD_LegalConstraints_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class MD_Constraints_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType[] useLimitationField;

    [XmlElement("useLimitation")]
    public CharacterString_PropertyType[] useLimitation
    {
      get { return useLimitationField; }
      set { useLimitationField = value; }
    }
  }
}
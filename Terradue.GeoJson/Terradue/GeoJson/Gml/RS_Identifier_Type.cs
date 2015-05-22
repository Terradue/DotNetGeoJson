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
  public class RS_Identifier_Type : MD_Identifier_Type
  {
    private CharacterString_PropertyType codeSpaceField;
    private CharacterString_PropertyType versionField;

    [XmlElement]
    public CharacterString_PropertyType codeSpace
    {
      get { return codeSpaceField; }
      set { codeSpaceField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType version
    {
      get { return versionField; }
      set { versionField = value; }
    }
  }
}
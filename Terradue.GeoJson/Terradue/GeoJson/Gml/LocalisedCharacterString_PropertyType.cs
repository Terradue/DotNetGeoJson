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
  public class LocalisedCharacterString_PropertyType : ObjectReference_PropertyType
  {
    private LocalisedCharacterString_Type localisedCharacterStringField;

    [XmlElement]
    public LocalisedCharacterString_Type LocalisedCharacterString
    {
      get { return localisedCharacterStringField; }
      set { localisedCharacterStringField = value; }
    }
  }
}
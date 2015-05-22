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
  public class PT_FreeText_Type : AbstractObject_Type
  {
    private LocalisedCharacterString_PropertyType[] textGroupField;

    [XmlElement("textGroup")]
    public LocalisedCharacterString_PropertyType[] textGroup
    {
      get { return textGroupField; }
      set { textGroupField = value; }
    }
  }
}
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
  public class PT_FreeText_PropertyType : CharacterString_PropertyType
  {
    private PT_FreeText_Type pT_FreeTextField;

    [XmlElement]
    public PT_FreeText_Type PT_FreeText
    {
      get { return pT_FreeTextField; }
      set { pT_FreeTextField = value; }
    }
  }
}
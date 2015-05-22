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
  public class CI_Telephone_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType[] facsimileField;
    private CharacterString_PropertyType[] voiceField;

    [XmlElement("voice")]
    public CharacterString_PropertyType[] voice
    {
      get { return voiceField; }
      set { voiceField = value; }
    }

    [XmlElement("facsimile")]
    public CharacterString_PropertyType[] facsimile
    {
      get { return facsimileField; }
      set { facsimileField = value; }
    }
  }
}
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gco")]
  public class TypeName_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType aNameField;

    [XmlElement]
    public CharacterString_PropertyType aName
    {
      get { return aNameField; }
      set { aNameField = value; }
    }
  }
}
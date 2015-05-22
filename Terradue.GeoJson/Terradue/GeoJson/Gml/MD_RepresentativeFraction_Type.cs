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
  public class MD_RepresentativeFraction_Type : AbstractObject_Type
  {
    private Integer_PropertyType denominatorField;

    [XmlElement]
    public Integer_PropertyType denominator
    {
      get { return denominatorField; }
      set { denominatorField = value; }
    }
  }
}
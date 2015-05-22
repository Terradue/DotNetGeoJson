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
  public class MultiplicityRange_Type : AbstractObject_Type
  {
    private Integer_PropertyType lowerField;
    private UnlimitedInteger_PropertyType upperField;

    [XmlElement]
    public Integer_PropertyType lower
    {
      get { return lowerField; }
      set { lowerField = value; }
    }

    [XmlElement]
    public UnlimitedInteger_PropertyType upper
    {
      get { return upperField; }
      set { upperField = value; }
    }
  }
}
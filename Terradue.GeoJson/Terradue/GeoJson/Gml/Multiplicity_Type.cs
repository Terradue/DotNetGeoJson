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
  public class Multiplicity_Type : AbstractObject_Type
  {
    private MultiplicityRange_PropertyType[] rangeField;

    [XmlElement("range")]
    public MultiplicityRange_PropertyType[] range
    {
      get { return rangeField; }
      set { rangeField = value; }
    }
  }
}
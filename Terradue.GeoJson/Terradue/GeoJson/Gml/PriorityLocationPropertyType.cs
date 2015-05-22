using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("priorityLocation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class PriorityLocationPropertyType : LocationPropertyType
  {
    private string priorityField;

    [XmlAttribute]
    public string priority
    {
      get { return priorityField; }
      set { priorityField = value; }
    }
  }
}
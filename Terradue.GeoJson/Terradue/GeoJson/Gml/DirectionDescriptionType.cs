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
  [XmlRoot(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public class DirectionDescriptionType
  {
    private object itemField;

    [XmlElement("compassPoint", typeof (CompassPointEnumeration))]
    [XmlElement("description", typeof (string))]
    [XmlElement("keyword", typeof (CodeType))]
    [XmlElement("reference", typeof (ReferenceType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}
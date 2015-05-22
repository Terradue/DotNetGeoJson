using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (TimeEdgeType))]
  [XmlInclude(typeof (TimeNodeType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractTimeTopologyPrimitive",
    Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public abstract class AbstractTimeTopologyPrimitiveType : AbstractTimePrimitiveType
  {
    private ReferenceType complexField;

    [XmlElement]
    public ReferenceType complex
    {
      get { return complexField; }
      set { complexField = value; }
    }
  }
}
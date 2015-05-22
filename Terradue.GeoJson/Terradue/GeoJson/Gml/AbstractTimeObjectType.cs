using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (AbstractTimeComplexType))]
  [XmlInclude(typeof (TimeTopologyComplexType))]
  [XmlInclude(typeof (AbstractTimePrimitiveType))]
  [XmlInclude(typeof (AbstractTimeTopologyPrimitiveType))]
  [XmlInclude(typeof (TimeEdgeType))]
  [XmlInclude(typeof (TimeNodeType))]
  [XmlInclude(typeof (AbstractTimeGeometricPrimitiveType))]
  [XmlInclude(typeof (TimePeriodType))]
  [XmlInclude(typeof (TimeInstantType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractTimeObject", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractTimeObjectType : AbstractGMLType
  {
  }
}
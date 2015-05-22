using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (DQ_AccuracyOfATimeMeasurement_Type))]
  [XmlInclude(typeof (DQ_TemporalConsistency_Type))]
  [XmlInclude(typeof (DQ_TemporalValidity_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract class AbstractDQ_TemporalAccuracy_Type : AbstractDQ_Element_Type
  {
  }
}
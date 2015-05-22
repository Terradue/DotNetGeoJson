using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (DQ_ThematicClassificationCorrectness_Type))]
  [XmlInclude(typeof (DQ_NonQuantitativeAttributeAccuracy_Type))]
  [XmlInclude(typeof (DQ_QuantitativeAttributeAccuracy_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract class AbstractDQ_ThematicAccuracy_Type : AbstractDQ_Element_Type
  {
  }
}
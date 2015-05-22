using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (DQ_AbsoluteExternalPositionalAccuracy_Type))]
  [XmlInclude(typeof (DQ_GriddedDataPositionalAccuracy_Type))]
  [XmlInclude(typeof (DQ_RelativeInternalPositionalAccuracy_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract class AbstractDQ_PositionalAccuracy_Type : AbstractDQ_Element_Type
  {
  }
}
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (DS_ProductionSeries_Type))]
  [XmlInclude(typeof (DS_Sensor_Type))]
  [XmlInclude(typeof (DS_Platform_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class DS_Series_Type : AbstractDS_Aggregate_Type
  {
  }
}
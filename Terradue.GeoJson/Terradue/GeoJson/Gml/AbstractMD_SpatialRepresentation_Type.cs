using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (MD_VectorSpatialRepresentation_Type))]
  [XmlInclude(typeof (MD_GridSpatialRepresentation_Type))]
  [XmlInclude(typeof (MD_Georectified_Type))]
  [XmlInclude(typeof (MD_Georeferenceable_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract class AbstractMD_SpatialRepresentation_Type : AbstractObject_Type
  {
  }
}
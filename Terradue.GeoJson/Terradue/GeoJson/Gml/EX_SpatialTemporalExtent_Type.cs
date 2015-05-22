using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class EX_SpatialTemporalExtent_Type : EX_TemporalExtent_Type
  {
    private EX_GeographicExtent_PropertyType[] spatialExtentField;

    [XmlElement("spatialExtent")]
    public EX_GeographicExtent_PropertyType[] spatialExtent
    {
      get { return spatialExtentField; }
      set { spatialExtentField = value; }
    }
  }
}
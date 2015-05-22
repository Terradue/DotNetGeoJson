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
  public class MD_VectorSpatialRepresentation_Type : AbstractMD_SpatialRepresentation_Type
  {
    private MD_GeometricObjects_PropertyType[] geometricObjectsField;
    private MD_TopologyLevelCode_PropertyType topologyLevelField;

    [XmlElement]
    public MD_TopologyLevelCode_PropertyType topologyLevel
    {
      get { return topologyLevelField; }
      set { topologyLevelField = value; }
    }

    [XmlElement("geometricObjects")]
    public MD_GeometricObjects_PropertyType[] geometricObjects
    {
      get { return geometricObjectsField; }
      set { geometricObjectsField = value; }
    }
  }
}
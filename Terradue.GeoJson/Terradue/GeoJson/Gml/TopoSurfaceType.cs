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
  [XmlRoot("TopoSurface", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoSurfaceType : AbstractTopologyType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private DirectedFacePropertyType[] directedFaceField;

    [XmlElement("directedFace")]
    public DirectedFacePropertyType[] directedFace
    {
      get { return directedFaceField; }
      set { directedFaceField = value; }
    }

    [XmlAttribute]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [XmlIgnore]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}
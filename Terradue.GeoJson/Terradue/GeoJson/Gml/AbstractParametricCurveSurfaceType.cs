using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (AbstractGriddedSurfaceType))]
  [XmlInclude(typeof (SphereType))]
  [XmlInclude(typeof (CylinderType))]
  [XmlInclude(typeof (ConeType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractParametricCurveSurface",
    Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public abstract class AbstractParametricCurveSurfaceType : AbstractSurfacePatchType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;

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
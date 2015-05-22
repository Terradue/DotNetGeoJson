using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (MultiSolidType))]
  [XmlInclude(typeof (MultiSurfaceType))]
  [XmlInclude(typeof (MultiCurveType))]
  [XmlInclude(typeof (MultiPointType))]
  [XmlInclude(typeof (MultiGeometryType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractGeometricAggregate", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractGeometricAggregateType : AbstractGeometryType
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
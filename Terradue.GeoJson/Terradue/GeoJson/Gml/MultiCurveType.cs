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
  [XmlRoot("MultiCurve", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class MultiCurveType : AbstractGeometricAggregateType
  {
    private CurvePropertyType[] curveMemberField;
    private CurveArrayPropertyType curveMembersField;

    [XmlElement("curveMember")]
    public CurvePropertyType[] curveMember
    {
      get { return curveMemberField; }
      set { curveMemberField = value; }
    }

    [XmlElement]
    public CurveArrayPropertyType curveMembers
    {
      get { return curveMembersField; }
      set { curveMembersField = value; }
    }
  }
}
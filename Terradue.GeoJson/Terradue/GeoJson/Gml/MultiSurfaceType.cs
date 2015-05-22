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
  [XmlRoot("MultiSurface", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class MultiSurfaceType : AbstractGeometricAggregateType
  {
    private SurfacePropertyType[] surfaceMemberField;
    private SurfaceArrayPropertyType surfaceMembersField;

    [XmlElement("surfaceMember")]
    public SurfacePropertyType[] surfaceMember
    {
      get { return surfaceMemberField; }
      set { surfaceMemberField = value; }
    }

    [XmlElement]
    public SurfaceArrayPropertyType surfaceMembers
    {
      get { return surfaceMembersField; }
      set { surfaceMembersField = value; }
    }
  }
}
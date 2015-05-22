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
  [XmlRoot("MultiGeometry", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class MultiGeometryType : AbstractGeometricAggregateType
  {
    private GeometryPropertyType[] geometryMemberField;
    private GeometryArrayPropertyType geometryMembersField;

    [XmlElement("geometryMember")]
    public GeometryPropertyType[] geometryMember
    {
      get { return geometryMemberField; }
      set { geometryMemberField = value; }
    }

    [XmlElement]
    public GeometryArrayPropertyType geometryMembers
    {
      get { return geometryMembersField; }
      set { geometryMembersField = value; }
    }
  }
}
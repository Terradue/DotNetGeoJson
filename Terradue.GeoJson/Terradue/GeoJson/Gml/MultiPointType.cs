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
  [XmlRoot("MultiPoint", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class MultiPointType : AbstractGeometricAggregateType
  {
    private PointPropertyType[] pointMemberField;
    private PointArrayPropertyType pointMembersField;

    [XmlElement("pointMember")]
    public PointPropertyType[] pointMember
    {
      get { return pointMemberField; }
      set { pointMemberField = value; }
    }

    [XmlElement]
    public PointArrayPropertyType pointMembers
    {
      get { return pointMembersField; }
      set { pointMembersField = value; }
    }
  }
}
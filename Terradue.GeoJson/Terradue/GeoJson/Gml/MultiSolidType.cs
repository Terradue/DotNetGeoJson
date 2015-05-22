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
  [XmlRoot("MultiSolid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class MultiSolidType : AbstractGeometricAggregateType
  {
    private SolidPropertyType[] solidMemberField;
    private SolidArrayPropertyType solidMembersField;

    [XmlElement("solidMember")]
    public SolidPropertyType[] solidMember
    {
      get { return solidMemberField; }
      set { solidMemberField = value; }
    }

    [XmlElement]
    public SolidArrayPropertyType solidMembers
    {
      get { return solidMembersField; }
      set { solidMembersField = value; }
    }
  }
}
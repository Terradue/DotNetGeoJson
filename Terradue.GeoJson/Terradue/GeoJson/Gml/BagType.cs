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
  [XmlRoot("Bag", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class BagType : AbstractGMLType
  {
    private AssociationRoleType[] memberField;
    private ArrayAssociationType membersField;

    [XmlElement("member")]
    public AssociationRoleType[] member
    {
      get { return memberField; }
      set { memberField = value; }
    }

    [XmlElement]
    public ArrayAssociationType members
    {
      get { return membersField; }
      set { membersField = value; }
    }
  }
}
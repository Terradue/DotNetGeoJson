namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("MultiSolid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class MultiSolidType : AbstractGeometricAggregateType
  {

    private SolidPropertyType[] solidMemberField;

    private SolidArrayPropertyType solidMembersField;

    [System.Xml.Serialization.XmlElementAttribute("solidMember")]
    public SolidPropertyType[] solidMember
    {
      get { return solidMemberField; }
      set { solidMemberField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public SolidArrayPropertyType solidMembers
    {
      get { return solidMembersField; }
      set { solidMembersField = value; }
    }
  }
}
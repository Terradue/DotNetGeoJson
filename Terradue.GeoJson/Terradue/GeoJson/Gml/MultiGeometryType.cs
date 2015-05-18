namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("MultiGeometry", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class MultiGeometryType : AbstractGeometricAggregateType
  {

    private GeometryPropertyType[] geometryMemberField;

    private GeometryArrayPropertyType geometryMembersField;

    [System.Xml.Serialization.XmlElementAttribute("geometryMember")]
    public GeometryPropertyType[] geometryMember
    {
      get { return geometryMemberField; }
      set { geometryMemberField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public GeometryArrayPropertyType geometryMembers
    {
      get { return geometryMembersField; }
      set { geometryMembersField = value; }
    }
  }
}
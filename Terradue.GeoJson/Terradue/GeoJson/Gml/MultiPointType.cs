namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("MultiPoint", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class MultiPointType : AbstractGeometricAggregateType
  {

    private PointPropertyType[] pointMemberField;

    private PointArrayPropertyType pointMembersField;

    [System.Xml.Serialization.XmlElementAttribute("pointMember")]
    public PointPropertyType[] pointMember
    {
      get { return pointMemberField; }
      set { pointMemberField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public PointArrayPropertyType pointMembers
    {
      get { return pointMembersField; }
      set { pointMembersField = value; }
    }
  }
}
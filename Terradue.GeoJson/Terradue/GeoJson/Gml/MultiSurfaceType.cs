namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("MultiSurface", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class MultiSurfaceType : AbstractGeometricAggregateType
  {

    private SurfacePropertyType[] surfaceMemberField;

    private SurfaceArrayPropertyType surfaceMembersField;

    [System.Xml.Serialization.XmlElementAttribute("surfaceMember")]
    public SurfacePropertyType[] surfaceMember
    {
      get { return surfaceMemberField; }
      set { surfaceMemberField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public SurfaceArrayPropertyType surfaceMembers
    {
      get { return surfaceMembersField; }
      set { surfaceMembersField = value; }
    }
  }
}
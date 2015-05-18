namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("MultiCurve", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class MultiCurveType : AbstractGeometricAggregateType
  {

    private CurvePropertyType[] curveMemberField;

    private CurveArrayPropertyType curveMembersField;

    [System.Xml.Serialization.XmlElementAttribute("curveMember")]
    public CurvePropertyType[] curveMember
    {
      get { return curveMemberField; }
      set { curveMemberField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CurveArrayPropertyType curveMembers
    {
      get { return curveMembersField; }
      set { curveMembersField = value; }
    }
  }
}
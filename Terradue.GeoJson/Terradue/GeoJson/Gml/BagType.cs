namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Bag", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class BagType : AbstractGMLType
  {

    private AssociationRoleType[] memberField;

    private ArrayAssociationType membersField;

    [System.Xml.Serialization.XmlElementAttribute("member")]
    public AssociationRoleType[] member
    {
      get { return memberField; }
      set { memberField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public ArrayAssociationType members
    {
      get { return membersField; }
      set { membersField = value; }
    }
  }
}
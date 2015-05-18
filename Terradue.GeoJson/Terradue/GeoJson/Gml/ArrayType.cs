namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Array", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class ArrayType : AbstractGMLType
  {

    private ArrayAssociationType membersField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public ArrayAssociationType members
    {
      get { return membersField; }
      set { membersField = value; }
    }
  }
}
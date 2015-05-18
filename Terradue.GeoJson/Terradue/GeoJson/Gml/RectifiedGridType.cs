namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("RectifiedGrid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class RectifiedGridType : GridType
  {

    private PointPropertyType originField;

    private VectorType[] offsetVectorField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public PointPropertyType origin
    {
      get { return originField; }
      set { originField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("offsetVector")]
    public VectorType[] offsetVector
    {
      get { return offsetVectorField; }
      set { offsetVectorField = value; }
    }
  }
}
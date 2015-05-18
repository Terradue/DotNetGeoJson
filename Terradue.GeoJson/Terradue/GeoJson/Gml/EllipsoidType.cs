namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Ellipsoid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class EllipsoidType : IdentifiedObjectType
  {

    private MeasureType semiMajorAxisField;

    private secondDefiningParameter secondDefiningParameterField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MeasureType semiMajorAxis
    {
      get { return semiMajorAxisField; }
      set { semiMajorAxisField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public secondDefiningParameter secondDefiningParameter
    {
      get { return secondDefiningParameterField; }
      set { secondDefiningParameterField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimePeriodType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeInstantType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractTimeGeometricPrimitive",
    Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public abstract partial class AbstractTimeGeometricPrimitiveType : AbstractTimePrimitiveType
  {

    private string frameField;

    public AbstractTimeGeometricPrimitiveType()
    {
      frameField = "#ISO-8601";
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    [System.ComponentModel.DefaultValueAttribute("#ISO-8601")]
    public string frame
    {
      get { return frameField; }
      set { frameField = value; }
    }
  }
}
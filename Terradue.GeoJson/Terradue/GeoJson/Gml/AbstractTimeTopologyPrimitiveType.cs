namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeEdgeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeNodeType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractTimeTopologyPrimitive",
    Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public abstract partial class AbstractTimeTopologyPrimitiveType : AbstractTimePrimitiveType
  {

    private ReferenceType complexField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public ReferenceType complex
    {
      get { return complexField; }
      set { complexField = value; }
    }
  }
}
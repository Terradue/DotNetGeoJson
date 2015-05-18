namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TimeTopologyComplex", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class TimeTopologyComplexType : AbstractTimeComplexType
  {

    private TimeTopologyPrimitivePropertyType[] primitiveField;

    [System.Xml.Serialization.XmlElementAttribute("primitive")]
    public TimeTopologyPrimitivePropertyType[] primitive
    {
      get { return primitiveField; }
      set { primitiveField = value; }
    }
  }
}
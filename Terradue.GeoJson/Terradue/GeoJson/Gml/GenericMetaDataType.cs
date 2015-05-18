namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("GenericMetaData", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class GenericMetaDataType : AbstractMetaDataType
  {

    private System.Xml.XmlElement[] anyField;

    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any
    {
      get { return anyField; }
      set { anyField = value; }
    }
  }
}
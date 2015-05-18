namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  public enum IncrementOrder
  {

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("+x+y")] xy,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("+y+x")] yx,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("+x-y")] xy1,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("-x-y")] xy2,
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("indirectEntry", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class IndirectEntryType
  {

    private DefinitionProxyType definitionProxyField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public DefinitionProxyType DefinitionProxy
    {
      get { return definitionProxyField; }
      set { definitionProxyField = value; }
    }
  }
}
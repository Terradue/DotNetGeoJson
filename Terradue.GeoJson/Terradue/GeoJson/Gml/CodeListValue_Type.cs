namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class CodeListValue_Type
  {

    private string codeListField;

    private string codeListValueField;

    private string codeSpaceField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string codeList
    {
      get { return codeListField; }
      set { codeListField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string codeListValue
    {
      get { return codeListValueField; }
      set { codeListValueField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string codeSpace
    {
      get { return codeSpaceField; }
      set { codeSpaceField = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}
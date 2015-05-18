namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CategoryExtentType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("CategoryList", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class CodeOrNilReasonListType
  {

    private string codeSpaceField;

    private string[] textField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string codeSpace
    {
      get { return codeSpaceField; }
      set { codeSpaceField = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
      get { return textField; }
      set { textField = value; }
    }
  }
}
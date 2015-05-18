namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class UnlimitedInteger_Type
  {

    private bool isInfiniteField;

    private bool isInfiniteFieldSpecified;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isInfinite
    {
      get { return isInfiniteField; }
      set { isInfiniteField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isInfiniteSpecified
    {
      get { return isInfiniteFieldSpecified; }
      set { isInfiniteFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute(DataType = "nonNegativeInteger")]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}
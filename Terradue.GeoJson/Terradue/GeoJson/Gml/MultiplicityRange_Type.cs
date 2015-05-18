namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class MultiplicityRange_Type : AbstractObject_Type
  {

    private Integer_PropertyType lowerField;

    private UnlimitedInteger_PropertyType upperField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Integer_PropertyType lower
    {
      get { return lowerField; }
      set { lowerField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public UnlimitedInteger_PropertyType upper
    {
      get { return upperField; }
      set { upperField = value; }
    }
  }
}
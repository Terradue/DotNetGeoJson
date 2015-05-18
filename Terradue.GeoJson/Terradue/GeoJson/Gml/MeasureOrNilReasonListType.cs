namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (QuantityExtentType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("QuantityList", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class MeasureOrNilReasonListType
  {

    private string uomField;

    private string[] textField;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uom
    {
      get { return uomField; }
      set { uomField = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
      get { return textField; }
      set { textField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("timeInterval", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimeIntervalLengthType
  {

    private string unitField;

    private string radixField;

    private string factorField;

    private decimal valueField;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit
    {
      get { return unitField; }
      set { unitField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
    public string radix
    {
      get { return radixField; }
      set { radixField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string factor
    {
      get { return factorField; }
      set { factorField = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public partial class KnotType
  {

    private double valueField;

    private string multiplicityField;

    private double weightField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public double value
    {
      get { return valueField; }
      set { valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
    public string multiplicity
    {
      get { return multiplicityField; }
      set { multiplicityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public double weight
    {
      get { return weightField; }
      set { weightField = value; }
    }
  }
}
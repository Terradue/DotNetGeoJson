namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public partial class SequenceRuleType
  {

    private IncrementOrder orderField;

    private bool orderFieldSpecified;

    private string[] axisOrderField;

    private SequenceRuleEnumeration valueField;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public IncrementOrder order
    {
      get { return orderField; }
      set { orderField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool orderSpecified
    {
      get { return orderFieldSpecified; }
      set { orderFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string[] axisOrder
    {
      get { return axisOrderField; }
      set { axisOrderField = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public SequenceRuleEnumeration Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}
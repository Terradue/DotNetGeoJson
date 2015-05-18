namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("GridFunction", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class GridFunctionType
  {

    private SequenceRuleType sequenceRuleField;

    private string startPointField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public SequenceRuleType sequenceRule
    {
      get { return sequenceRuleField; }
      set { sequenceRuleField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public string startPoint
    {
      get { return startPointField; }
      set { startPointField = value; }
    }
  }
}
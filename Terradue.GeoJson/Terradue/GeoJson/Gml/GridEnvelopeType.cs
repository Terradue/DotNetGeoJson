namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public partial class GridEnvelopeType
  {

    private string lowField;

    private string highField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public string low
    {
      get { return lowField; }
      set { lowField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public string high
    {
      get { return highField; }
      set { highField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public partial class FormulaType
  {

    private double aField;

    private bool aFieldSpecified;

    private double bField;

    private double cField;

    private double dField;

    private bool dFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute()]
    public double a
    {
      get { return aField; }
      set { aField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool aSpecified
    {
      get { return aFieldSpecified; }
      set { aFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public double b
    {
      get { return bField; }
      set { bField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public double c
    {
      get { return cField; }
      set { cField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public double d
    {
      get { return dField; }
      set { dField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dSpecified
    {
      get { return dFieldSpecified; }
      set { dFieldSpecified = value; }
    }
  }
}
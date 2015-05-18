namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("CoordinateSystemAxis", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class CoordinateSystemAxisType : IdentifiedObjectType
  {

    private CodeType axisAbbrevField;

    private CodeWithAuthorityType axisDirectionField;

    private double minimumValueField;

    private bool minimumValueFieldSpecified;

    private double maximumValueField;

    private bool maximumValueFieldSpecified;

    private CodeWithAuthorityType rangeMeaningField;

    private string uomField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CodeType axisAbbrev
    {
      get { return axisAbbrevField; }
      set { axisAbbrevField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CodeWithAuthorityType axisDirection
    {
      get { return axisDirectionField; }
      set { axisDirectionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public double minimumValue
    {
      get { return minimumValueField; }
      set { minimumValueField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool minimumValueSpecified
    {
      get { return minimumValueFieldSpecified; }
      set { minimumValueFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public double maximumValue
    {
      get { return maximumValueField; }
      set { maximumValueField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maximumValueSpecified
    {
      get { return maximumValueFieldSpecified; }
      set { maximumValueFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CodeWithAuthorityType rangeMeaning
    {
      get { return rangeMeaningField; }
      set { rangeMeaningField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uom
    {
      get { return uomField; }
      set { uomField = value; }
    }
  }
}
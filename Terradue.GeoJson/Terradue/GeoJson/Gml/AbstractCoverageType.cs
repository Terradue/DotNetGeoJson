namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractContinuousCoverageType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DiscreteCoverageType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractCoverage", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractCoverageType : AbstractFeatureType
  {

    private DomainSetType item1Field;

    private Item1ChoiceType9 item1ElementNameField;

    private RangeSetType rangeSetField;

    [System.Xml.Serialization.XmlElementAttribute("domainSet", typeof (DomainSetType))]
    [System.Xml.Serialization.XmlElementAttribute("gridDomain", typeof (DomainSetType))]
    [System.Xml.Serialization.XmlElementAttribute("multiCurveDomain", typeof (DomainSetType))]
    [System.Xml.Serialization.XmlElementAttribute("multiPointDomain", typeof (DomainSetType))]
    [System.Xml.Serialization.XmlElementAttribute("multiSolidDomain", typeof (DomainSetType))]
    [System.Xml.Serialization.XmlElementAttribute("multiSurfaceDomain", typeof (DomainSetType))]
    [System.Xml.Serialization.XmlElementAttribute("rectifiedGridDomain", typeof (DomainSetType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public DomainSetType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType9 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public RangeSetType rangeSet
    {
      get { return rangeSetField; }
      set { rangeSetField = value; }
    }
  }
}
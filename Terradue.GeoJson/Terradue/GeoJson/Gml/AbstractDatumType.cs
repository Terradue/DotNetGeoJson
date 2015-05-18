namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TemporalDatumBaseType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TemporalDatumType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (VerticalDatumType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ImageDatumType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EngineeringDatumType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeodeticDatumType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractDatum", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractDatumType : IdentifiedObjectType
  {

    private domainOfValidity domainOfValidityField;

    private string[] scopeField;

    private CodeType itemField;

    private ItemChoiceType4 itemElementNameField;

    private System.DateTime realizationEpochField;

    private bool realizationEpochFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute()]
    public domainOfValidity domainOfValidity
    {
      get { return domainOfValidityField; }
      set { domainOfValidityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("scope")]
    public string[] scope
    {
      get { return scopeField; }
      set { scopeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("anchorDefinition", typeof (CodeType))]
    [System.Xml.Serialization.XmlElementAttribute("anchorPoint", typeof (CodeType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public CodeType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType4 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime realizationEpoch
    {
      get { return realizationEpochField; }
      set { realizationEpochField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool realizationEpochSpecified
    {
      get { return realizationEpochFieldSpecified; }
      set { realizationEpochFieldSpecified = value; }
    }
  }
}
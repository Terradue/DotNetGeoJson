namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeneralDerivedCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DerivedCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ProjectedCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeocentricCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeographicCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TemporalCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ImageCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EngineeringCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (VerticalCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeodeticCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompoundCRSType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractCRSType : IdentifiedObjectType
  {

    private domainOfValidity[] domainOfValidityField;

    private string[] scopeField;

    [System.Xml.Serialization.XmlElementAttribute("domainOfValidity")]
    public domainOfValidity[] domainOfValidity
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
  }
}
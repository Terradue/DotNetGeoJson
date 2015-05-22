using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (AbstractGeneralDerivedCRSType))]
  [XmlInclude(typeof (DerivedCRSType))]
  [XmlInclude(typeof (ProjectedCRSType))]
  [XmlInclude(typeof (GeocentricCRSType))]
  [XmlInclude(typeof (GeographicCRSType))]
  [XmlInclude(typeof (TemporalCRSType))]
  [XmlInclude(typeof (ImageCRSType))]
  [XmlInclude(typeof (EngineeringCRSType))]
  [XmlInclude(typeof (VerticalCRSType))]
  [XmlInclude(typeof (GeodeticCRSType))]
  [XmlInclude(typeof (CompoundCRSType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractCRSType : IdentifiedObjectType
  {
    private domainOfValidity[] domainOfValidityField;
    private string[] scopeField;

    [XmlElement("domainOfValidity")]
    public domainOfValidity[] domainOfValidity
    {
      get { return domainOfValidityField; }
      set { domainOfValidityField = value; }
    }

    [XmlElement("scope")]
    public string[] scope
    {
      get { return scopeField; }
      set { scopeField = value; }
    }
  }
}
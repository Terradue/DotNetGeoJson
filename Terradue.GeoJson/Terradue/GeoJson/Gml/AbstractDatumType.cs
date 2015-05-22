using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (TemporalDatumBaseType))]
  [XmlInclude(typeof (TemporalDatumType))]
  [XmlInclude(typeof (VerticalDatumType))]
  [XmlInclude(typeof (ImageDatumType))]
  [XmlInclude(typeof (EngineeringDatumType))]
  [XmlInclude(typeof (GeodeticDatumType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractDatum", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractDatumType : IdentifiedObjectType
  {
    private domainOfValidity domainOfValidityField;
    private ItemChoiceType4 itemElementNameField;
    private CodeType itemField;
    private DateTime realizationEpochField;
    private bool realizationEpochFieldSpecified;
    private string[] scopeField;

    [XmlElement]
    public domainOfValidity domainOfValidity
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

    [XmlElement("anchorDefinition", typeof (CodeType))]
    [XmlElement("anchorPoint", typeof (CodeType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public CodeType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType4 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement(DataType = "date")]
    public DateTime realizationEpoch
    {
      get { return realizationEpochField; }
      set { realizationEpochField = value; }
    }

    [XmlIgnore]
    public bool realizationEpochSpecified
    {
      get { return realizationEpochFieldSpecified; }
      set { realizationEpochFieldSpecified = value; }
    }
  }
}
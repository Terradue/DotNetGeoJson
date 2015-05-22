using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (AbstractContinuousCoverageType))]
  [XmlInclude(typeof (DiscreteCoverageType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractCoverage", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractCoverageType : AbstractFeatureType
  {
    private Item1ChoiceType9 item1ElementNameField;
    private DomainSetType item1Field;
    private RangeSetType rangeSetField;

    [XmlElement("domainSet", typeof (DomainSetType))]
    [XmlElement("gridDomain", typeof (DomainSetType))]
    [XmlElement("multiCurveDomain", typeof (DomainSetType))]
    [XmlElement("multiPointDomain", typeof (DomainSetType))]
    [XmlElement("multiSolidDomain", typeof (DomainSetType))]
    [XmlElement("multiSurfaceDomain", typeof (DomainSetType))]
    [XmlElement("rectifiedGridDomain", typeof (DomainSetType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public DomainSetType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType9 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }

    [XmlElement]
    public RangeSetType rangeSet
    {
      get { return rangeSetField; }
      set { rangeSetField = value; }
    }
  }
}
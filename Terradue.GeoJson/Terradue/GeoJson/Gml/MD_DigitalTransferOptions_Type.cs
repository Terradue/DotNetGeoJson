using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class MD_DigitalTransferOptions_Type : AbstractObject_Type
  {
    private MD_Medium_PropertyType offLineField;
    private CI_OnlineResource_PropertyType[] onLineField;
    private Real_PropertyType transferSizeField;
    private CharacterString_PropertyType unitsOfDistributionField;

    [XmlElement]
    public CharacterString_PropertyType unitsOfDistribution
    {
      get { return unitsOfDistributionField; }
      set { unitsOfDistributionField = value; }
    }

    [XmlElement]
    public Real_PropertyType transferSize
    {
      get { return transferSizeField; }
      set { transferSizeField = value; }
    }

    [XmlElement("onLine")]
    public CI_OnlineResource_PropertyType[] onLine
    {
      get { return onLineField; }
      set { onLineField = value; }
    }

    [XmlElement]
    public MD_Medium_PropertyType offLine
    {
      get { return offLineField; }
      set { offLineField = value; }
    }
  }
}
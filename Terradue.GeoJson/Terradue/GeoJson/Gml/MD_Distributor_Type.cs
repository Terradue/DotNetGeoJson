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
  public class MD_Distributor_Type : AbstractObject_Type
  {
    private MD_StandardOrderProcess_PropertyType[] distributionOrderProcessField;
    private CI_ResponsibleParty_PropertyType distributorContactField;
    private MD_Format_PropertyType[] distributorFormatField;
    private MD_DigitalTransferOptions_PropertyType[] distributorTransferOptionsField;

    [XmlElement]
    public CI_ResponsibleParty_PropertyType distributorContact
    {
      get { return distributorContactField; }
      set { distributorContactField = value; }
    }

    [XmlElement("distributionOrderProcess")]
    public MD_StandardOrderProcess_PropertyType[] distributionOrderProcess
    {
      get { return distributionOrderProcessField; }
      set { distributionOrderProcessField = value; }
    }

    [XmlElement("distributorFormat")]
    public MD_Format_PropertyType[] distributorFormat
    {
      get { return distributorFormatField; }
      set { distributorFormatField = value; }
    }

    [XmlElement("distributorTransferOptions")]
    public MD_DigitalTransferOptions_PropertyType[] distributorTransferOptions
    {
      get { return distributorTransferOptionsField; }
      set { distributorTransferOptionsField = value; }
    }
  }
}
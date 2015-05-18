namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Distributor_Type : AbstractObject_Type
  {

    private CI_ResponsibleParty_PropertyType distributorContactField;

    private MD_StandardOrderProcess_PropertyType[] distributionOrderProcessField;

    private MD_Format_PropertyType[] distributorFormatField;

    private MD_DigitalTransferOptions_PropertyType[] distributorTransferOptionsField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_ResponsibleParty_PropertyType distributorContact
    {
      get { return distributorContactField; }
      set { distributorContactField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("distributionOrderProcess")]
    public MD_StandardOrderProcess_PropertyType[] distributionOrderProcess
    {
      get { return distributionOrderProcessField; }
      set { distributionOrderProcessField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("distributorFormat")]
    public MD_Format_PropertyType[] distributorFormat
    {
      get { return distributorFormatField; }
      set { distributorFormatField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("distributorTransferOptions")]
    public MD_DigitalTransferOptions_PropertyType[] distributorTransferOptions
    {
      get { return distributorTransferOptionsField; }
      set { distributorTransferOptionsField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Distribution_Type : AbstractObject_Type
  {

    private MD_Format_PropertyType[] distributionFormatField;

    private MD_Distributor_PropertyType[] distributorField;

    private MD_DigitalTransferOptions_PropertyType[] transferOptionsField;

    [System.Xml.Serialization.XmlElementAttribute("distributionFormat")]
    public MD_Format_PropertyType[] distributionFormat
    {
      get { return distributionFormatField; }
      set { distributionFormatField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("distributor")]
    public MD_Distributor_PropertyType[] distributor
    {
      get { return distributorField; }
      set { distributorField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("transferOptions")]
    public MD_DigitalTransferOptions_PropertyType[] transferOptions
    {
      get { return transferOptionsField; }
      set { transferOptionsField = value; }
    }
  }
}
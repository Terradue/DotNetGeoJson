namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_DigitalTransferOptions_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType unitsOfDistributionField;

    private Real_PropertyType transferSizeField;

    private CI_OnlineResource_PropertyType[] onLineField;

    private MD_Medium_PropertyType offLineField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType unitsOfDistribution
    {
      get { return unitsOfDistributionField; }
      set { unitsOfDistributionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType transferSize
    {
      get { return transferSizeField; }
      set { transferSizeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("onLine")]
    public CI_OnlineResource_PropertyType[] onLine
    {
      get { return onLineField; }
      set { onLineField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_Medium_PropertyType offLine
    {
      get { return offLineField; }
      set { offLineField = value; }
    }
  }
}
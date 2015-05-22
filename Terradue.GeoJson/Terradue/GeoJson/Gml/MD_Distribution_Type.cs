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
  public class MD_Distribution_Type : AbstractObject_Type
  {
    private MD_Format_PropertyType[] distributionFormatField;
    private MD_Distributor_PropertyType[] distributorField;
    private MD_DigitalTransferOptions_PropertyType[] transferOptionsField;

    [XmlElement("distributionFormat")]
    public MD_Format_PropertyType[] distributionFormat
    {
      get { return distributionFormatField; }
      set { distributionFormatField = value; }
    }

    [XmlElement("distributor")]
    public MD_Distributor_PropertyType[] distributor
    {
      get { return distributorField; }
      set { distributorField = value; }
    }

    [XmlElement("transferOptions")]
    public MD_DigitalTransferOptions_PropertyType[] transferOptions
    {
      get { return transferOptionsField; }
      set { transferOptionsField = value; }
    }
  }
}
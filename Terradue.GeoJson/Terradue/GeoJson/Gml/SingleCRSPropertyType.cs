using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("componentReferenceSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class SingleCRSPropertyType
  {
    private AbstractCRSType itemField;
    private string nilReasonField;
    private string remoteSchemaField;

    [XmlElement("EngineeringCRS", typeof (EngineeringCRSType))]
    [XmlElement("GeocentricCRS", typeof (GeocentricCRSType))]
    [XmlElement("GeodeticCRS", typeof (GeodeticCRSType))]
    [XmlElement("GeographicCRS", typeof (GeographicCRSType))]
    [XmlElement("ImageCRS", typeof (ImageCRSType))]
    [XmlElement("TemporalCRS", typeof (TemporalCRSType))]
    [XmlElement("VerticalCRS", typeof (VerticalCRSType))]
    public AbstractCRSType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlAttribute]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
    }
  }
}
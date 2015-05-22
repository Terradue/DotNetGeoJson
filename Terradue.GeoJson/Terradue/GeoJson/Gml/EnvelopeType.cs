using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (EnvelopeWithTimePeriodType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("Envelope", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class EnvelopeType
  {
    private ItemsChoiceType19[] itemsElementNameField;
    private object[] itemsField;
    private string srsDimensionField;
    private string srsNameField;

    [XmlElement("coordinates", typeof (CoordinatesType))]
    [XmlElement("lowerCorner", typeof (DirectPositionType))]
    [XmlElement("pos", typeof (DirectPositionType))]
    [XmlElement("upperCorner", typeof (DirectPositionType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType19[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [XmlAttribute(DataType = "anyURI")]
    public string srsName
    {
      get { return srsNameField; }
      set { srsNameField = value; }
    }

    [XmlAttribute(DataType = "positiveInteger")]
    public string srsDimension
    {
      get { return srsDimensionField; }
      set { srsDimensionField = value; }
    }
  }
}
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("TemporalCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TemporalCRSType : AbstractCRSType
  {
    private Item1ChoiceType5 item1ElementNameField;
    private TemporalDatumPropertyType item1Field;
    private ItemChoiceType8 itemElementNameField;
    private object itemField;

    [XmlElement("timeCS", typeof (TimeCSPropertyType))]
    [XmlElement("usesTemporalCS", typeof (TemporalCSPropertyType))]
    [XmlElement("usesTimeCS", typeof (TimeCSPropertyType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType8 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement("temporalDatum", typeof (TemporalDatumPropertyType))]
    [XmlElement("usesTemporalDatum", typeof (TemporalDatumPropertyType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public TemporalDatumPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType5 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}
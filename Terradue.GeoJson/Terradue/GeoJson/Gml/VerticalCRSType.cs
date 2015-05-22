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
  [XmlRoot("VerticalCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class VerticalCRSType : AbstractCRSType
  {
    private Item1ChoiceType2 item1ElementNameField;
    private VerticalDatumPropertyType item1Field;
    private ItemChoiceType5 itemElementNameField;
    private VerticalCSPropertyType itemField;

    [XmlElement("usesVerticalCS", typeof (VerticalCSPropertyType))]
    [XmlElement("verticalCS", typeof (VerticalCSPropertyType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public VerticalCSPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType5 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement("usesVerticalDatum", typeof (VerticalDatumPropertyType))]
    [XmlElement("verticalDatum", typeof (VerticalDatumPropertyType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public VerticalDatumPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType2 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}
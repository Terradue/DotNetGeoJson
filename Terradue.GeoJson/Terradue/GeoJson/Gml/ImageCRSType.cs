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
  [XmlRoot("ImageCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ImageCRSType : AbstractCRSType
  {
    private Item1ChoiceType4 item1ElementNameField;
    private ImageDatumPropertyType item1Field;
    private ItemChoiceType7 itemElementNameField;
    private object itemField;

    [XmlElement("affineCS", typeof (AffineCSPropertyType))]
    [XmlElement("cartesianCS", typeof (CartesianCSPropertyType))]
    [XmlElement("usesAffineCS", typeof (AffineCSPropertyType))]
    [XmlElement("usesCartesianCS", typeof (CartesianCSPropertyType))]
    [XmlElement("usesObliqueCartesianCS", typeof (ObliqueCartesianCSPropertyType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType7 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement("imageDatum", typeof (ImageDatumPropertyType))]
    [XmlElement("usesImageDatum", typeof (ImageDatumPropertyType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public ImageDatumPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType4 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}
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
  [XmlRoot("GeodeticCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class GeodeticCRSType : AbstractCRSType
  {
    private Item1ChoiceType1 item1ElementNameField;
    private GeodeticDatumPropertyType item1Field;
    private ItemChoiceType3 itemElementNameField;
    private object itemField;

    [XmlElement("cartesianCS", typeof (CartesianCSPropertyType))]
    [XmlElement("ellipsoidalCS", typeof (EllipsoidalCSPropertyType))]
    [XmlElement("sphericalCS", typeof (SphericalCSPropertyType))]
    [XmlElement("usesCartesianCS", typeof (CartesianCSPropertyType))]
    [XmlElement("usesEllipsoidalCS", typeof (EllipsoidalCSPropertyType))]
    [XmlElement("usesSphericalCS", typeof (SphericalCSPropertyType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType3 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement("geodeticDatum", typeof (GeodeticDatumPropertyType))]
    [XmlElement("usesGeodeticDatum", typeof (GeodeticDatumPropertyType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public GeodeticDatumPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType1 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}
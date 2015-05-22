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
  [XmlRoot("EngineeringCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class EngineeringCRSType : AbstractCRSType
  {
    private Item1ChoiceType3 item1ElementNameField;
    private EngineeringDatumPropertyType item1Field;
    private ItemChoiceType6 itemElementNameField;
    private object itemField;

    [XmlElement("affineCS", typeof (AffineCSPropertyType))]
    [XmlElement("cartesianCS", typeof (CartesianCSPropertyType))]
    [XmlElement("coordinateSystem", typeof (CoordinateSystemPropertyType))]
    [XmlElement("cylindricalCS", typeof (CylindricalCSPropertyType))]
    [XmlElement("linearCS", typeof (LinearCSPropertyType))]
    [XmlElement("polarCS", typeof (PolarCSPropertyType))]
    [XmlElement("sphericalCS", typeof (SphericalCSPropertyType))]
    [XmlElement("userDefinedCS", typeof (UserDefinedCSPropertyType))]
    [XmlElement("usesAffineCS", typeof (AffineCSPropertyType))]
    [XmlElement("usesCS", typeof (CoordinateSystemPropertyType))]
    [XmlElement("usesCartesianCS", typeof (CartesianCSPropertyType))]
    [XmlElement("usesSphericalCS", typeof (SphericalCSPropertyType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType6 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement("engineeringDatum", typeof (EngineeringDatumPropertyType))]
    [XmlElement("usesEngineeringDatum", typeof (EngineeringDatumPropertyType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public EngineeringDatumPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType3 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}
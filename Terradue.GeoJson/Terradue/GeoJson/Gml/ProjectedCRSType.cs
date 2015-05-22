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
  [XmlRoot("ProjectedCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ProjectedCRSType : AbstractGeneralDerivedCRSType
  {
    private object item1Field;
    private Item2ChoiceType1 item2ElementNameField;
    private CartesianCSPropertyType item2Field;

    [XmlElement("baseGeodeticCRS", typeof (GeodeticCRSPropertyType))]
    [XmlElement("baseGeographicCRS", typeof (GeographicCRSPropertyType))]
    public object Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement("cartesianCS", typeof (CartesianCSPropertyType))]
    [XmlElement("usesCartesianCS", typeof (CartesianCSPropertyType))]
    [XmlChoiceIdentifier("Item2ElementName")]
    public CartesianCSPropertyType Item2
    {
      get { return item2Field; }
      set { item2Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item2ChoiceType1 Item2ElementName
    {
      get { return item2ElementNameField; }
      set { item2ElementNameField = value; }
    }
  }
}
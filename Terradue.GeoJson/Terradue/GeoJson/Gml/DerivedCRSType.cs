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
  [XmlRoot("DerivedCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DerivedCRSType : AbstractGeneralDerivedCRSType
  {
    private SingleCRSPropertyType baseCRSField;
    private CodeWithAuthorityType derivedCRSTypeField;
    private Item1ChoiceType7 item1ElementNameField;
    private CoordinateSystemPropertyType item1Field;

    [XmlElement]
    public SingleCRSPropertyType baseCRS
    {
      get { return baseCRSField; }
      set { baseCRSField = value; }
    }

    [XmlElement]
    public CodeWithAuthorityType derivedCRSType
    {
      get { return derivedCRSTypeField; }
      set { derivedCRSTypeField = value; }
    }

    [XmlElement("coordinateSystem", typeof (CoordinateSystemPropertyType))]
    [XmlElement("usesCS", typeof (CoordinateSystemPropertyType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public CoordinateSystemPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType7 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}
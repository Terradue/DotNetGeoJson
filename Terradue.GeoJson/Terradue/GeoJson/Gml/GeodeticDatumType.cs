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
  [XmlRoot("GeodeticDatum", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class GeodeticDatumType : AbstractDatumType
  {
    private Item1ChoiceType item1ElementNameField;
    private PrimeMeridianPropertyType item1Field;
    private Item2ChoiceType item2ElementNameField;
    private EllipsoidPropertyType item2Field;

    [XmlElement("primeMeridian", typeof (PrimeMeridianPropertyType))]
    [XmlElement("usesPrimeMeridian", typeof (PrimeMeridianPropertyType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public PrimeMeridianPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }

    [XmlElement("ellipsoid", typeof (EllipsoidPropertyType))]
    [XmlElement("usesEllipsoid", typeof (EllipsoidPropertyType))]
    [XmlChoiceIdentifier("Item2ElementName")]
    public EllipsoidPropertyType Item2
    {
      get { return item2Field; }
      set { item2Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item2ChoiceType Item2ElementName
    {
      get { return item2ElementNameField; }
      set { item2ElementNameField = value; }
    }
  }
}
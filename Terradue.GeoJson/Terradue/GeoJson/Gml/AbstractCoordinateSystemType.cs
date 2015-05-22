using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (ObliqueCartesianCSType))]
  [XmlInclude(typeof (TemporalCSType))]
  [XmlInclude(typeof (AffineCSType))]
  [XmlInclude(typeof (CylindricalCSType))]
  [XmlInclude(typeof (PolarCSType))]
  [XmlInclude(typeof (SphericalCSType))]
  [XmlInclude(typeof (UserDefinedCSType))]
  [XmlInclude(typeof (LinearCSType))]
  [XmlInclude(typeof (TimeCSType))]
  [XmlInclude(typeof (VerticalCSType))]
  [XmlInclude(typeof (CartesianCSType))]
  [XmlInclude(typeof (EllipsoidalCSType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractCoordinateSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractCoordinateSystemType : IdentifiedObjectType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private ItemsChoiceType8[] itemsElementNameField;
    private CoordinateSystemAxisPropertyType[] itemsField;

    [XmlElement("axis", typeof (CoordinateSystemAxisPropertyType))]
    [XmlElement("usesAxis", typeof (CoordinateSystemAxisPropertyType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public CoordinateSystemAxisPropertyType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType8[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [XmlAttribute]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [XmlIgnore]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}
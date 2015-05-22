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
  [XmlRoot("valueComponents", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ValueArrayPropertyType
  {
    private ItemsChoiceType21[] itemsElementNameField;
    private object[] itemsField;
    private bool ownsField;

    public ValueArrayPropertyType()
    {
      ownsField = false;
    }

    [XmlElement("AbstractGeometry", typeof (AbstractGeometryType))]
    [XmlElement("AbstractTimeObject", typeof (AbstractTimeObjectType))]
    [XmlElement("AbstractValue", typeof (object))]
    [XmlElement("CategoryExtent", typeof (CategoryExtentType))]
    [XmlElement("CompositeValue", typeof (CompositeValueType))]
    [XmlElement("CountExtent", typeof (string))]
    [XmlElement("GeometricComplex", typeof (GeometricComplexType))]
    [XmlElement("Null", typeof (string))]
    [XmlElement("QuantityExtent", typeof (QuantityExtentType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType21[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}
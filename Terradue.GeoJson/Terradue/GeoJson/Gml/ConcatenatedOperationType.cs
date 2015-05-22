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
  [XmlRoot("ConcatenatedOperation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ConcatenatedOperationType : AbstractCoordinateOperationType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private ItemsChoiceType17[] itemsElementNameField;
    private CoordinateOperationPropertyType[] itemsField;

    [XmlElement("coordOperation", typeof (CoordinateOperationPropertyType))]
    [XmlElement("usesOperation", typeof (CoordinateOperationPropertyType))]
    [XmlElement("usesSingleOperation", typeof (CoordinateOperationPropertyType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public CoordinateOperationPropertyType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType17[] ItemsElementName
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
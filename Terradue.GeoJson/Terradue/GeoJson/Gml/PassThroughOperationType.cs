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
  [XmlRoot("PassThroughOperation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class PassThroughOperationType : AbstractCoordinateOperationType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private ItemChoiceType15 itemElementNameField;
    private CoordinateOperationPropertyType itemField;
    private string[] modifiedCoordinateField;

    [XmlElement("modifiedCoordinate", DataType = "positiveInteger")]
    public string[] modifiedCoordinate
    {
      get { return modifiedCoordinateField; }
      set { modifiedCoordinateField = value; }
    }

    [XmlElement("coordOperation", typeof (CoordinateOperationPropertyType))]
    [XmlElement("usesOperation", typeof (CoordinateOperationPropertyType))]
    [XmlElement("usesSingleOperation", typeof (CoordinateOperationPropertyType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public CoordinateOperationPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType15 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
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
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
  [XmlRoot("ParameterValue", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ParameterValueType : AbstractGeneralParameterValueType
  {
    private Item1ChoiceType6 item1ElementNameField;
    private OperationParameterPropertyType item1Field;
    private ItemChoiceType12 itemElementNameField;
    private object itemField;

    [XmlElement("booleanValue", typeof (bool))]
    [XmlElement("dmsAngleValue", typeof (DMSAngleType))]
    [XmlElement("integerValue", typeof (string), DataType = "positiveInteger")]
    [XmlElement("integerValueList", typeof (string), DataType = "integer")]
    [XmlElement("stringValue", typeof (string))]
    [XmlElement("value", typeof (MeasureType))]
    [XmlElement("valueFile", typeof (string), DataType = "anyURI")]
    [XmlElement("valueList", typeof (MeasureListType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType12 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement("operationParameter", typeof (OperationParameterPropertyType))]
    [XmlElement("valueOfParameter", typeof (OperationParameterPropertyType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public OperationParameterPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType6 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}
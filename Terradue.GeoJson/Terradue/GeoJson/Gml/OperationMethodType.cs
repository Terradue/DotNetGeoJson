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
  [XmlRoot("OperationMethod", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class OperationMethodType : IdentifiedObjectType
  {
    private ItemChoiceType10 itemElementNameField;
    private object itemField;
    private ItemsChoiceType12[] itemsElementNameField;
    private AbstractGeneralOperationParameterPropertyType[] itemsField;
    private string sourceDimensionsField;
    private string targetDimensionsField;

    [XmlElement("formula", typeof (CodeType))]
    [XmlElement("formulaCitation", typeof (formulaCitation))]
    [XmlElement("methodFormula", typeof (CodeType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType10 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement(DataType = "positiveInteger")]
    public string sourceDimensions
    {
      get { return sourceDimensionsField; }
      set { sourceDimensionsField = value; }
    }

    [XmlElement(DataType = "positiveInteger")]
    public string targetDimensions
    {
      get { return targetDimensionsField; }
      set { targetDimensionsField = value; }
    }

    [XmlElement("generalOperationParameter",
      typeof (AbstractGeneralOperationParameterPropertyType))]
    [XmlElement("includesParameter",
      typeof (AbstractGeneralOperationParameterPropertyType))]
    [XmlElement("parameter", typeof (AbstractGeneralOperationParameterPropertyType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public AbstractGeneralOperationParameterPropertyType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType12[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}
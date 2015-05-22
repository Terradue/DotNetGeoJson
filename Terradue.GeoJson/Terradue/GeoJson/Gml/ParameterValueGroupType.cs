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
  [XmlRoot("ParameterValueGroup", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ParameterValueGroupType : AbstractGeneralParameterValueType
  {
    private ItemChoiceType13 itemElementNameField;
    private OperationParameterGroupPropertyType itemField;
    private ItemsChoiceType14[] itemsElementNameField;
    private AbstractGeneralParameterValuePropertyType[] itemsField;

    [XmlElement("includesValue", typeof (AbstractGeneralParameterValuePropertyType))]
    [XmlElement("parameterValue", typeof (AbstractGeneralParameterValuePropertyType))]
    [XmlElement("usesValue", typeof (AbstractGeneralParameterValuePropertyType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public AbstractGeneralParameterValuePropertyType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType14[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [XmlElement("group", typeof (OperationParameterGroupPropertyType))]
    [XmlElement("valuesOfGroup", typeof (OperationParameterGroupPropertyType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public OperationParameterGroupPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType13 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }
  }
}
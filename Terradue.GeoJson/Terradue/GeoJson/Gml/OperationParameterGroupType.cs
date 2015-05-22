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
  [XmlRoot("OperationParameterGroup", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class OperationParameterGroupType : AbstractGeneralOperationParameterType
  {
    private ItemsChoiceType11[] itemsElementNameField;
    private AbstractGeneralOperationParameterPropertyType[] itemsField;
    private string maximumOccursField;

    [XmlElement(DataType = "positiveInteger")]
    public string maximumOccurs
    {
      get { return maximumOccursField; }
      set { maximumOccursField = value; }
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
    public ItemsChoiceType11[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}
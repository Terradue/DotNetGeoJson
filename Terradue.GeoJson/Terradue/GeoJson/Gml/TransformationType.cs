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
  [XmlRoot("Transformation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TransformationType : AbstractGeneralTransformationType
  {
    private ItemChoiceType14 itemElementNameField;
    private OperationMethodPropertyType itemField;
    private ItemsChoiceType16[] itemsElementNameField;
    private AbstractGeneralParameterValuePropertyType[] itemsField;

    [XmlElement("method", typeof (OperationMethodPropertyType))]
    [XmlElement("usesMethod", typeof (OperationMethodPropertyType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public OperationMethodPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType14 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

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
    public ItemsChoiceType16[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}
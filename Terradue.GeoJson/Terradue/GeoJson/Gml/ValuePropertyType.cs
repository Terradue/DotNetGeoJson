using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("valueProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ValuePropertyType
  {
    private AbstractTimeObjectType abstractTimeObjectField;
    private GeometricComplexType item1Field;
    private object itemField;
    private string nilReasonField;
    private string nullField;
    private bool ownsField;
    private string remoteSchemaField;

    public ValuePropertyType()
    {
      ownsField = false;
    }

    [XmlElement("CategoryExtent", typeof (CategoryExtentType))]
    [XmlElement("CompositeValue", typeof (CompositeValueType))]
    [XmlElement("CountExtent", typeof (string))]
    [XmlElement("QuantityExtent", typeof (QuantityExtentType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement("GeometricComplex")]
    public GeometricComplexType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    public AbstractTimeObjectType AbstractTimeObject
    {
      get { return abstractTimeObjectField; }
      set { abstractTimeObjectField = value; }
    }

    [XmlElement]
    public string Null
    {
      get { return nullField; }
      set { nullField = value; }
    }

    [XmlAttribute]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
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
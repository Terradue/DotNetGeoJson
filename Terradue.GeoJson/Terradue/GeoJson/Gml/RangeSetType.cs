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
  [XmlRoot("rangeSet", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class RangeSetType
  {
    private ItemsChoiceType22[] itemsElementNameField;
    private object[] itemsField;

    [XmlElement("AbstractScalarValueList", typeof (object))]
    [XmlElement("BooleanList", typeof (string))]
    [XmlElement("CategoryList", typeof (CodeOrNilReasonListType))]
    [XmlElement("CountList", typeof (string))]
    [XmlElement("DataBlock", typeof (DataBlockType))]
    [XmlElement("File", typeof (FileType))]
    [XmlElement("QuantityList", typeof (MeasureOrNilReasonListType))]
    [XmlElement("ValueArray", typeof (ValueArrayType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType22[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}
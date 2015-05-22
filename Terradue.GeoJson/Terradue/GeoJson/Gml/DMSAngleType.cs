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
  [XmlRoot("dmsAngleValue", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DMSAngleType
  {
    private DegreesType degreesField;
    private ItemsChoiceType13[] itemsElementNameField;
    private object[] itemsField;

    [XmlElement]
    public DegreesType degrees
    {
      get { return degreesField; }
      set { degreesField = value; }
    }

    [XmlElement("decimalMinutes", typeof (decimal))]
    [XmlElement("minutes", typeof (string), DataType = "nonNegativeInteger")]
    [XmlElement("seconds", typeof (decimal))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType13[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}
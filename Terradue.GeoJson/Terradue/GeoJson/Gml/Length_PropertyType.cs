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
  [XmlType(Namespace = "http://www.isotc211.org/2005/gco")]
  public class Length_PropertyType
  {
    private ItemChoiceType19 itemElementNameField;
    private LengthType itemField;
    private string nilReasonField;

    [XmlElement("Distance", typeof (LengthType))]
    [XmlElement("Length", typeof (LengthType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public LengthType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType19 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}
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
  [XmlRoot("dictionaryEntry", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DictionaryEntryType : AbstractMemberType
  {
    private ItemChoiceType17 itemElementNameField;
    private DefinitionType itemField;
    private string nilReasonField;
    private string remoteSchemaField;

    [XmlElement("CoordinateSystemAxis", typeof (CoordinateSystemAxisType))]
    [XmlElement("Definition", typeof (DefinitionType))]
    [XmlElement("DefinitionCollection", typeof (DictionaryType))]
    [XmlElement("DefinitionProxy", typeof (DefinitionProxyType))]
    [XmlElement("Dictionary", typeof (DictionaryType))]
    [XmlElement("Ellipsoid", typeof (EllipsoidType))]
    [XmlElement("OperationMethod", typeof (OperationMethodType))]
    [XmlElement("PrimeMeridian", typeof (PrimeMeridianType))]
    [XmlElement("TimeReferenceSystem", typeof (TimeReferenceSystemType))]
    [XmlElement("UnitDefinition", typeof (UnitDefinitionType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public DefinitionType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType17 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
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
  }
}
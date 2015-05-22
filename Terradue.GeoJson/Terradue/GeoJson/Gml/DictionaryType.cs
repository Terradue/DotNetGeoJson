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
  [XmlRoot("Dictionary", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DictionaryType : DefinitionType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private ItemsChoiceType18[] itemsElementNameField;
    private object[] itemsField;

    [XmlElement("definitionMember", typeof (DictionaryEntryType))]
    [XmlElement("dictionaryEntry", typeof (DictionaryEntryType))]
    [XmlElement("indirectEntry", typeof (IndirectEntryType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType18[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [XmlAttribute]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [XmlIgnore]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}
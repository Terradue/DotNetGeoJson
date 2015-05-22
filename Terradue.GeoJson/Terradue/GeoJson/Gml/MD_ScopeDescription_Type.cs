using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class MD_ScopeDescription_Type
  {
    private ItemsChoiceType10[] itemsElementNameField;
    private object[] itemsField;

    [XmlElement("attributeInstances", typeof (ObjectReference_PropertyType))]
    [XmlElement("attributes", typeof (ObjectReference_PropertyType))]
    [XmlElement("dataset", typeof (CharacterString_PropertyType))]
    [XmlElement("featureInstances", typeof (ObjectReference_PropertyType))]
    [XmlElement("features", typeof (ObjectReference_PropertyType))]
    [XmlElement("other", typeof (CharacterString_PropertyType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType10[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}
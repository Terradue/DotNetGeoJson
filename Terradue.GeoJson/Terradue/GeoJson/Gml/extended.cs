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
  [XmlType(Namespace = "http://www.w3.org/1999/xlink")]
  public class extended
  {
    private object[] itemsField;
    private string roleField;
    private string titleField;
    private typeType typeField;

    public extended()
    {
      typeField = typeType.extended;
    }

    [XmlElement("arc", typeof (arcType))]
    [XmlElement("locator", typeof (locatorType))]
    [XmlElement("resource", typeof (resourceType))]
    [XmlElement("title", typeof (titleEltType))]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified)]
    public typeType type
    {
      get { return typeField; }
      set { typeField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string role
    {
      get { return roleField; }
      set { roleField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified)]
    public string title
    {
      get { return titleField; }
      set { titleField = value; }
    }
  }
}
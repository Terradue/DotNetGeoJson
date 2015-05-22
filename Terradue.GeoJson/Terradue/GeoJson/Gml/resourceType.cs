using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.w3.org/1999/xlink")]
  public class resourceType
  {
    private XmlNode[] anyField;
    private string labelField;
    private string roleField;
    private string titleField;
    private typeType typeField;

    public resourceType()
    {
      typeField = typeType.resource;
    }

    [XmlText]
    [XmlAnyElement]
    public XmlNode[] Any
    {
      get { return anyField; }
      set { anyField = value; }
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

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      DataType = "NCName")]
    public string label
    {
      get { return labelField; }
      set { labelField = value; }
    }
  }
}
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
  public class titleEltType
  {
    private XmlNode[] anyField;
    private string langField;
    private typeType typeField;

    public titleEltType()
    {
      typeField = typeType.title;
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
      Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string lang
    {
      get { return langField; }
      set { langField = value; }
    }
  }
}
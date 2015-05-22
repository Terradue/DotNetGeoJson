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
  public class locatorType
  {
    private string hrefField;
    private string labelField;
    private string roleField;
    private string title1Field;
    private titleEltType[] titleField;
    private typeType typeField;

    public locatorType()
    {
      typeField = typeType.locator;
    }

    [XmlElement("title")]
    public titleEltType[] title
    {
      get { return titleField; }
      set { titleField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified)]
    public typeType type
    {
      get { return typeField; }
      set { typeField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string href
    {
      get { return hrefField; }
      set { hrefField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string role
    {
      get { return roleField; }
      set { roleField = value; }
    }

    [XmlAttribute("title", Form = XmlSchemaForm.Qualified)]
    public string title1
    {
      get { return title1Field; }
      set { title1Field = value; }
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
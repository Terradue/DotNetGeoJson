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
  public class RecordType_Type
  {
    private actuateType actuateField;
    private bool actuateFieldSpecified;
    private string arcroleField;
    private string hrefField;
    private string roleField;
    private showType showField;
    private bool showFieldSpecified;
    private string titleField;
    private typeType typeField;
    private bool typeFieldSpecified;
    private string valueField;

    public RecordType_Type()
    {
      typeField = typeType.simple;
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      Namespace = "http://www.w3.org/1999/xlink")]
    public typeType type
    {
      get { return typeField; }
      set { typeField = value; }
    }

    [XmlIgnore]
    public bool typeSpecified
    {
      get { return typeFieldSpecified; }
      set { typeFieldSpecified = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
    public string href
    {
      get { return hrefField; }
      set { hrefField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
    public string role
    {
      get { return roleField; }
      set { roleField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
    public string arcrole
    {
      get { return arcroleField; }
      set { arcroleField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      Namespace = "http://www.w3.org/1999/xlink")]
    public string title
    {
      get { return titleField; }
      set { titleField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      Namespace = "http://www.w3.org/1999/xlink")]
    public showType show
    {
      get { return showField; }
      set { showField = value; }
    }

    [XmlIgnore]
    public bool showSpecified
    {
      get { return showFieldSpecified; }
      set { showFieldSpecified = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      Namespace = "http://www.w3.org/1999/xlink")]
    public actuateType actuate
    {
      get { return actuateField; }
      set { actuateField = value; }
    }

    [XmlIgnore]
    public bool actuateSpecified
    {
      get { return actuateFieldSpecified; }
      set { actuateFieldSpecified = value; }
    }

    [XmlText]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
  public partial class simple
  {

    private System.Xml.XmlNode[] anyField;

    private typeType typeField;

    private bool typeFieldSpecified;

    private string hrefField;

    private string roleField;

    private string arcroleField;

    private string titleField;

    private showType showField;

    private bool showFieldSpecified;

    private actuateType actuateField;

    private bool actuateFieldSpecified;

    public simple()
    {
      typeField = typeType.simple;
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlNode[] Any
    {
      get { return anyField; }
      set { anyField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public typeType type
    {
      get { return typeField; }
      set { typeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool typeSpecified
    {
      get { return typeFieldSpecified; }
      set { typeFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string href
    {
      get { return hrefField; }
      set { hrefField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string role
    {
      get { return roleField; }
      set { roleField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string arcrole
    {
      get { return arcroleField; }
      set { arcroleField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string title
    {
      get { return titleField; }
      set { titleField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public showType show
    {
      get { return showField; }
      set { showField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool showSpecified
    {
      get { return showFieldSpecified; }
      set { showFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public actuateType actuate
    {
      get { return actuateField; }
      set { actuateField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool actuateSpecified
    {
      get { return actuateFieldSpecified; }
      set { actuateFieldSpecified = value; }
    }
  }
}
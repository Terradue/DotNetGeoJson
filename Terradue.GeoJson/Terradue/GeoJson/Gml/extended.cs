namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
  public partial class extended
  {

    private object[] itemsField;

    private typeType typeField;

    private string roleField;

    private string titleField;

    public extended()
    {
      typeField = typeType.extended;
    }

    [System.Xml.Serialization.XmlElementAttribute("arc", typeof (arcType))]
    [System.Xml.Serialization.XmlElementAttribute("locator", typeof (locatorType))]
    [System.Xml.Serialization.XmlElementAttribute("resource", typeof (resourceType))]
    [System.Xml.Serialization.XmlElementAttribute("title", typeof (titleEltType))]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public typeType type
    {
      get { return typeField; }
      set { typeField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string role
    {
      get { return roleField; }
      set { roleField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string title
    {
      get { return titleField; }
      set { titleField = value; }
    }
  }
}
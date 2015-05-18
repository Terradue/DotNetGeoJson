namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PriorityLocationPropertyType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("location", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class LocationPropertyType
  {

    private object itemField;

    private string nilReasonField;

    private string remoteSchemaField;

    [System.Xml.Serialization.XmlElementAttribute("AbstractGeometry", typeof (AbstractGeometryType))]
    [System.Xml.Serialization.XmlElementAttribute("GeometricComplex", typeof (GeometricComplexType))]
    [System.Xml.Serialization.XmlElementAttribute("LocationKeyWord", typeof (CodeType))]
    [System.Xml.Serialization.XmlElementAttribute("LocationString", typeof (StringOrRefType))]
    [System.Xml.Serialization.XmlElementAttribute("Null", typeof (string))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
    }
  }
}
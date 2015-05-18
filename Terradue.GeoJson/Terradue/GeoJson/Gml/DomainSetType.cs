namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("domainSet", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DomainSetType
  {

    private AbstractGMLType itemField;

    private bool ownsField;

    private string nilReasonField;

    private string remoteSchemaField;

    public DomainSetType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("AbstractGeometry", typeof (AbstractGeometryType))]
    [System.Xml.Serialization.XmlElementAttribute("AbstractTimeObject", typeof (AbstractTimeObjectType))]
    [System.Xml.Serialization.XmlElementAttribute("GeometricComplex", typeof (GeometricComplexType))]
    public AbstractGMLType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
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
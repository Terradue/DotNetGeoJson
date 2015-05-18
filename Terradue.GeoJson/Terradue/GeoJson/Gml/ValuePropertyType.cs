namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("valueProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ValuePropertyType
  {

    private object itemField;

    private GeometricComplexType item1Field;

    private AbstractTimeObjectType abstractTimeObjectField;

    private string nullField;

    private string nilReasonField;

    private string remoteSchemaField;

    private bool ownsField;

    public ValuePropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("CategoryExtent", typeof (CategoryExtentType))]
    [System.Xml.Serialization.XmlElementAttribute("CompositeValue", typeof (CompositeValueType))]
    [System.Xml.Serialization.XmlElementAttribute("CountExtent", typeof (string))]
    [System.Xml.Serialization.XmlElementAttribute("QuantityExtent", typeof (QuantityExtentType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("GeometricComplex")]
    public GeometricComplexType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public AbstractTimeObjectType AbstractTimeObject
    {
      get { return abstractTimeObjectField; }
      set { abstractTimeObjectField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public string Null
    {
      get { return nullField; }
      set { nullField = value; }
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

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}
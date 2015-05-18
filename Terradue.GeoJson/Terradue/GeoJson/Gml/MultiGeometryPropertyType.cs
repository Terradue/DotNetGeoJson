namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("multiGeometryProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class MultiGeometryPropertyType
  {

    private AbstractGeometricAggregateType itemField;

    private string nilReasonField;

    private string remoteSchemaField;

    private bool ownsField;

    public MultiGeometryPropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("MultiCurve", typeof (MultiCurveType))]
    [System.Xml.Serialization.XmlElementAttribute("MultiGeometry", typeof (MultiGeometryType))]
    [System.Xml.Serialization.XmlElementAttribute("MultiPoint", typeof (MultiPointType))]
    [System.Xml.Serialization.XmlElementAttribute("MultiSolid", typeof (MultiSolidType))]
    [System.Xml.Serialization.XmlElementAttribute("MultiSurface", typeof (MultiSurfaceType))]
    public AbstractGeometricAggregateType Item
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

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}
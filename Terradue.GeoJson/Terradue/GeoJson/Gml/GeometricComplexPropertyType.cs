namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public partial class GeometricComplexPropertyType
  {

    private AbstractGeometryType itemField;

    private bool ownsField;

    private string nilReasonField;

    private string remoteSchemaField;

    public GeometricComplexPropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("CompositeCurve", typeof (CompositeCurveType))]
    [System.Xml.Serialization.XmlElementAttribute("CompositeSolid", typeof (CompositeSolidType))]
    [System.Xml.Serialization.XmlElementAttribute("CompositeSurface", typeof (CompositeSurfaceType))]
    [System.Xml.Serialization.XmlElementAttribute("GeometricComplex", typeof (GeometricComplexType))]
    public AbstractGeometryType Item
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
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("multiCoverage", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class MultiSurfacePropertyType
  {

    private MultiSurfaceType multiSurfaceField;

    private string nilReasonField;

    private string remoteSchemaField;

    private bool ownsField;

    public MultiSurfacePropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MultiSurfaceType MultiSurface
    {
      get { return multiSurfaceField; }
      set { multiSurfaceField = value; }
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
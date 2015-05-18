namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("directedTopoSolid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DirectedTopoSolidPropertyType
  {

    private TopoSolidType topoSolidField;

    private SignType orientationField;

    private string nilReasonField;

    private string remoteSchemaField;

    private bool ownsField;

    public DirectedTopoSolidPropertyType()
    {
      orientationField = SignType.Item1;
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TopoSolidType TopoSolid
    {
      get { return topoSolidField; }
      set { topoSolidField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
    public SignType orientation
    {
      get { return orientationField; }
      set { orientationField = value; }
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
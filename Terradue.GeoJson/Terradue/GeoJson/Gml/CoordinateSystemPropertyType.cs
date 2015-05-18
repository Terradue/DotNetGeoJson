namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("coordinateSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class CoordinateSystemPropertyType
  {

    private AbstractCoordinateSystemType itemField;

    private string nilReasonField;

    private string remoteSchemaField;

    [System.Xml.Serialization.XmlElementAttribute("AffineCS", typeof (AffineCSType))]
    [System.Xml.Serialization.XmlElementAttribute("CartesianCS", typeof (CartesianCSType))]
    [System.Xml.Serialization.XmlElementAttribute("CylindricalCS", typeof (CylindricalCSType))]
    [System.Xml.Serialization.XmlElementAttribute("EllipsoidalCS", typeof (EllipsoidalCSType))]
    [System.Xml.Serialization.XmlElementAttribute("LinearCS", typeof (LinearCSType))]
    [System.Xml.Serialization.XmlElementAttribute("ObliqueCartesianCS", typeof (ObliqueCartesianCSType))]
    [System.Xml.Serialization.XmlElementAttribute("PolarCS", typeof (PolarCSType))]
    [System.Xml.Serialization.XmlElementAttribute("SphericalCS", typeof (SphericalCSType))]
    [System.Xml.Serialization.XmlElementAttribute("TemporalCS", typeof (TemporalCSType))]
    [System.Xml.Serialization.XmlElementAttribute("TimeCS", typeof (TimeCSType))]
    [System.Xml.Serialization.XmlElementAttribute("UserDefinedCS", typeof (UserDefinedCSType))]
    [System.Xml.Serialization.XmlElementAttribute("VerticalCS", typeof (VerticalCSType))]
    public AbstractCoordinateSystemType Item
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
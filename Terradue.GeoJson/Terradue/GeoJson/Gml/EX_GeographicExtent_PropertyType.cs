namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class EX_GeographicExtent_PropertyType
  {

    private AbstractEX_GeographicExtent_Type itemField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("EX_BoundingPolygon", typeof (EX_BoundingPolygon_Type))]
    [System.Xml.Serialization.XmlElementAttribute("EX_GeographicBoundingBox", typeof (EX_GeographicBoundingBox_Type))]
    [System.Xml.Serialization.XmlElementAttribute("EX_GeographicDescription", typeof (EX_GeographicDescription_Type))]
    public AbstractEX_GeographicExtent_Type Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uuidref
    {
      get { return uuidrefField; }
      set { uuidrefField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      Namespace = "http://www.isotc211.org/2005/gco")]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}
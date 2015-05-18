namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gts")]
  public partial class TM_Primitive_PropertyType
  {

    private AbstractTimePrimitiveType abstractTimePrimitiveField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
    public AbstractTimePrimitiveType AbstractTimePrimitive
    {
      get { return abstractTimePrimitiveField; }
      set { abstractTimePrimitiveField = value; }
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
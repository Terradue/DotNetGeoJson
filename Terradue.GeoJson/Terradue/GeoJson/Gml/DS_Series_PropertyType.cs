namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DS_Series_PropertyType
  {

    private DS_Series_Type itemField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("DS_Platform", typeof (DS_Platform_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DS_ProductionSeries", typeof (DS_ProductionSeries_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DS_Sensor", typeof (DS_Sensor_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DS_Series", typeof (DS_Series_Type))]
    public DS_Series_Type Item
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
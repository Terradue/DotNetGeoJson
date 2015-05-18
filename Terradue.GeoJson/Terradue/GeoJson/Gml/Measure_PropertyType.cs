namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class Measure_PropertyType
  {

    private MeasureType itemField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("Angle", typeof (AngleType))]
    [System.Xml.Serialization.XmlElementAttribute("Length", typeof (LengthType))]
    [System.Xml.Serialization.XmlElementAttribute("Measure", typeof (MeasureType))]
    [System.Xml.Serialization.XmlElementAttribute("Scale", typeof (ScaleType))]
    public MeasureType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}
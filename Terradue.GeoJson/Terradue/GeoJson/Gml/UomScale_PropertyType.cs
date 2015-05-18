namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class UomScale_PropertyType
  {

    private UnitDefinitionType itemField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("BaseUnit", typeof (BaseUnitType),
      Namespace = "http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlElementAttribute("ConventionalUnit", typeof (ConventionalUnitType),
      Namespace = "http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlElementAttribute("DerivedUnit", typeof (DerivedUnitType),
      Namespace = "http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlElementAttribute("UnitDefinition", typeof (UnitDefinitionType),
      Namespace = "http://www.opengis.net/gml/3.2")]
    public UnitDefinitionType Item
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

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_GridSpatialRepresentation_PropertyType
  {

    private MD_GridSpatialRepresentation_Type itemField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("MD_Georectified", typeof (MD_Georectified_Type))]
    [System.Xml.Serialization.XmlElementAttribute("MD_Georeferenceable", typeof (MD_Georeferenceable_Type))]
    [System.Xml.Serialization.XmlElementAttribute("MD_GridSpatialRepresentation",
      typeof (MD_GridSpatialRepresentation_Type))]
    public MD_GridSpatialRepresentation_Type Item
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
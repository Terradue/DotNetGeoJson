namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class CI_Date_Type : AbstractObject_Type
  {

    private Date_PropertyType dateField;

    private CI_DateTypeCode_PropertyType dateTypeField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Date_PropertyType date
    {
      get { return dateField; }
      set { dateField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_DateTypeCode_PropertyType dateType
    {
      get { return dateTypeField; }
      set { dateTypeField = value; }
    }
  }
}
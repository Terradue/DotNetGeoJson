namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_ConformanceResult_Type : AbstractDQ_Result_Type
  {

    private CI_Citation_PropertyType specificationField;

    private CharacterString_PropertyType explanationField;

    private Boolean_PropertyType passField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Citation_PropertyType specification
    {
      get { return specificationField; }
      set { specificationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType explanation
    {
      get { return explanationField; }
      set { explanationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType pass
    {
      get { return passField; }
      set { passField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class Multiplicity_Type : AbstractObject_Type
  {

    private MultiplicityRange_PropertyType[] rangeField;

    [System.Xml.Serialization.XmlElementAttribute("range")]
    public MultiplicityRange_PropertyType[] range
    {
      get { return rangeField; }
      set { rangeField = value; }
    }
  }
}
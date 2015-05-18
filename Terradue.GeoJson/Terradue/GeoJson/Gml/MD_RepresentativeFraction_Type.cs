namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_RepresentativeFraction_Type : AbstractObject_Type
  {

    private Integer_PropertyType denominatorField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Integer_PropertyType denominator
    {
      get { return denominatorField; }
      set { denominatorField = value; }
    }
  }
}
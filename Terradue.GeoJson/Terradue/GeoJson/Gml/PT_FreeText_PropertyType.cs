namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class PT_FreeText_PropertyType : CharacterString_PropertyType
  {

    private PT_FreeText_Type pT_FreeTextField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public PT_FreeText_Type PT_FreeText
    {
      get { return pT_FreeTextField; }
      set { pT_FreeTextField = value; }
    }
  }
}
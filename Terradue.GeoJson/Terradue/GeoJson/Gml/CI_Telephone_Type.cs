namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class CI_Telephone_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType[] voiceField;

    private CharacterString_PropertyType[] facsimileField;

    [System.Xml.Serialization.XmlElementAttribute("voice")]
    public CharacterString_PropertyType[] voice
    {
      get { return voiceField; }
      set { voiceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("facsimile")]
    public CharacterString_PropertyType[] facsimile
    {
      get { return facsimileField; }
      set { facsimileField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class EX_Extent_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType descriptionField;

    private EX_GeographicExtent_PropertyType[] geographicElementField;

    private EX_TemporalExtent_PropertyType[] temporalElementField;

    private EX_VerticalExtent_PropertyType[] verticalElementField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("geographicElement")]
    public EX_GeographicExtent_PropertyType[] geographicElement
    {
      get { return geographicElementField; }
      set { geographicElementField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("temporalElement")]
    public EX_TemporalExtent_PropertyType[] temporalElement
    {
      get { return temporalElementField; }
      set { temporalElementField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("verticalElement")]
    public EX_VerticalExtent_PropertyType[] verticalElement
    {
      get { return verticalElementField; }
      set { verticalElementField = value; }
    }
  }
}
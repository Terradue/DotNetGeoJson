namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class EX_VerticalExtent_Type : AbstractObject_Type
  {

    private Real_PropertyType minimumValueField;

    private Real_PropertyType maximumValueField;

    private SC_CRS_PropertyType verticalCRSField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType minimumValue
    {
      get { return minimumValueField; }
      set { minimumValueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType maximumValue
    {
      get { return maximumValueField; }
      set { maximumValueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public SC_CRS_PropertyType verticalCRS
    {
      get { return verticalCRSField; }
      set { verticalCRSField = value; }
    }
  }
}
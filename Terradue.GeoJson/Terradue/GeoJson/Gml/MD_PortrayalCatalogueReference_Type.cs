namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_PortrayalCatalogueReference_Type : AbstractObject_Type
  {

    private CI_Citation_PropertyType[] portrayalCatalogueCitationField;

    [System.Xml.Serialization.XmlElementAttribute("portrayalCatalogueCitation")]
    public CI_Citation_PropertyType[] portrayalCatalogueCitation
    {
      get { return portrayalCatalogueCitationField; }
      set { portrayalCatalogueCitationField = value; }
    }
  }
}
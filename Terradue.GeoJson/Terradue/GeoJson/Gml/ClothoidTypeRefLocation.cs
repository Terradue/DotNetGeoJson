namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml/3.2")]
  public partial class ClothoidTypeRefLocation
  {

    private AffinePlacementType affinePlacementField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public AffinePlacementType AffinePlacement
    {
      get { return affinePlacementField; }
      set { affinePlacementField = value; }
    }
  }
}
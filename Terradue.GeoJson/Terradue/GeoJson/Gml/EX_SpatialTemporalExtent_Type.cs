namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class EX_SpatialTemporalExtent_Type : EX_TemporalExtent_Type
  {

    private EX_GeographicExtent_PropertyType[] spatialExtentField;

    [System.Xml.Serialization.XmlElementAttribute("spatialExtent")]
    public EX_GeographicExtent_PropertyType[] spatialExtent
    {
      get { return spatialExtentField; }
      set { spatialExtentField = value; }
    }
  }
}
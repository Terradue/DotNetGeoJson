namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_VectorSpatialRepresentation_Type : AbstractMD_SpatialRepresentation_Type
  {

    private MD_TopologyLevelCode_PropertyType topologyLevelField;

    private MD_GeometricObjects_PropertyType[] geometricObjectsField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_TopologyLevelCode_PropertyType topologyLevel
    {
      get { return topologyLevelField; }
      set { topologyLevelField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("geometricObjects")]
    public MD_GeometricObjects_PropertyType[] geometricObjects
    {
      get { return geometricObjectsField; }
      set { geometricObjectsField = value; }
    }
  }
}
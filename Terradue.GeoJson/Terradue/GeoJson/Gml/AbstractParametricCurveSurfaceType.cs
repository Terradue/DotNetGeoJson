namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGriddedSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (SphereType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CylinderType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ConeType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractParametricCurveSurface",
    Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public abstract partial class AbstractParametricCurveSurfaceType : AbstractSurfacePatchType
  {

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}
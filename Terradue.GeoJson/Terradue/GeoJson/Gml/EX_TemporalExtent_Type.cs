namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EX_SpatialTemporalExtent_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class EX_TemporalExtent_Type : AbstractObject_Type
  {

    private TM_Primitive_PropertyType extentField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public TM_Primitive_PropertyType extent
    {
      get { return extentField; }
      set { extentField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EX_GeographicDescription_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EX_GeographicBoundingBox_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EX_BoundingPolygon_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract partial class AbstractEX_GeographicExtent_Type : AbstractObject_Type
  {

    private Boolean_PropertyType extentTypeCodeField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType extentTypeCode
    {
      get { return extentTypeCodeField; }
      set { extentTypeCodeField = value; }
    }
  }
}
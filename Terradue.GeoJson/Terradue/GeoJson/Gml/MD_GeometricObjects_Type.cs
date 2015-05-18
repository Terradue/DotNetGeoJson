namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_GeometricObjects_Type : AbstractObject_Type
  {

    private MD_GeometricObjectTypeCode_PropertyType geometricObjectTypeField;

    private Integer_PropertyType geometricObjectCountField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_GeometricObjectTypeCode_PropertyType geometricObjectType
    {
      get { return geometricObjectTypeField; }
      set { geometricObjectTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Integer_PropertyType geometricObjectCount
    {
      get { return geometricObjectCountField; }
      set { geometricObjectCountField = value; }
    }
  }
}
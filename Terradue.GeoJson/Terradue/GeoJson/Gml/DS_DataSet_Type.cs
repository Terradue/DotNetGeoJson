namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DS_DataSet_Type : AbstractObject_Type
  {

    private MD_Metadata_PropertyType[] hasField;

    private DS_Aggregate_PropertyType[] partOfField;

    [System.Xml.Serialization.XmlElementAttribute("has")]
    public MD_Metadata_PropertyType[] has
    {
      get { return hasField; }
      set { hasField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partOf")]
    public DS_Aggregate_PropertyType[] partOf
    {
      get { return partOfField; }
      set { partOfField = value; }
    }
  }
}
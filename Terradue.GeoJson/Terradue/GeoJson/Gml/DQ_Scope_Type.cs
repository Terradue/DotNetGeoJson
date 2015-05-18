namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_Scope_Type : AbstractObject_Type
  {

    private MD_ScopeCode_PropertyType levelField;

    private EX_Extent_PropertyType extentField;

    private MD_ScopeDescription_PropertyType[] levelDescriptionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_ScopeCode_PropertyType level
    {
      get { return levelField; }
      set { levelField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public EX_Extent_PropertyType extent
    {
      get { return extentField; }
      set { extentField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("levelDescription")]
    public MD_ScopeDescription_PropertyType[] levelDescription
    {
      get { return levelDescriptionField; }
      set { levelDescriptionField = value; }
    }
  }
}
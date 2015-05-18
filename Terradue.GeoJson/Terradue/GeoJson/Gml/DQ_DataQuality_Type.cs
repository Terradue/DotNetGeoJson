namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_DataQuality_Type : AbstractObject_Type
  {

    private DQ_Scope_PropertyType scopeField;

    private DQ_Element_PropertyType[] reportField;

    private LI_Lineage_PropertyType lineageField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public DQ_Scope_PropertyType scope
    {
      get { return scopeField; }
      set { scopeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("report")]
    public DQ_Element_PropertyType[] report
    {
      get { return reportField; }
      set { reportField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public LI_Lineage_PropertyType lineage
    {
      get { return lineageField; }
      set { lineageField = value; }
    }
  }
}
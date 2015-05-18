namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_LegalConstraints_Type : MD_Constraints_Type
  {

    private MD_RestrictionCode_PropertyType[] accessConstraintsField;

    private MD_RestrictionCode_PropertyType[] useConstraintsField;

    private CharacterString_PropertyType[] otherConstraintsField;

    [System.Xml.Serialization.XmlElementAttribute("accessConstraints")]
    public MD_RestrictionCode_PropertyType[] accessConstraints
    {
      get { return accessConstraintsField; }
      set { accessConstraintsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("useConstraints")]
    public MD_RestrictionCode_PropertyType[] useConstraints
    {
      get { return useConstraintsField; }
      set { useConstraintsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("otherConstraints")]
    public CharacterString_PropertyType[] otherConstraints
    {
      get { return otherConstraintsField; }
      set { otherConstraintsField = value; }
    }
  }
}
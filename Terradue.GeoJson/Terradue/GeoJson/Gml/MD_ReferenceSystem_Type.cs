namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_ReferenceSystem_Type : AbstractObject_Type
  {

    private RS_Identifier_PropertyType referenceSystemIdentifierField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public RS_Identifier_PropertyType referenceSystemIdentifier
    {
      get { return referenceSystemIdentifierField; }
      set { referenceSystemIdentifierField = value; }
    }
  }
}
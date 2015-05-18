namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract partial class AbstractRS_ReferenceSystem_Type : AbstractObject_Type
  {

    private RS_Identifier_PropertyType nameField;

    private EX_Extent_PropertyType[] domainOfValidityField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public RS_Identifier_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("domainOfValidity")]
    public EX_Extent_PropertyType[] domainOfValidity
    {
      get { return domainOfValidityField; }
      set { domainOfValidityField = value; }
    }
  }
}
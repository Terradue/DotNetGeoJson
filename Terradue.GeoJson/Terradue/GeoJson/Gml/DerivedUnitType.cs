namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("DerivedUnit", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DerivedUnitType : UnitDefinitionType
  {

    private DerivationUnitTermType[] derivationUnitTermField;

    [System.Xml.Serialization.XmlElementAttribute("derivationUnitTerm")]
    public DerivationUnitTermType[] derivationUnitTerm
    {
      get { return derivationUnitTermField; }
      set { derivationUnitTermField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ConventionalUnitType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DerivedUnitType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (BaseUnitType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("UnitDefinition", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class UnitDefinitionType : DefinitionType
  {

    private StringOrRefType quantityTypeField;

    private ReferenceType quantityTypeReferenceField;

    private CodeType catalogSymbolField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public StringOrRefType quantityType
    {
      get { return quantityTypeField; }
      set { quantityTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public ReferenceType quantityTypeReference
    {
      get { return quantityTypeReferenceField; }
      set { quantityTypeReferenceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CodeType catalogSymbol
    {
      get { return catalogSymbolField; }
      set { catalogSymbolField = value; }
    }
  }
}
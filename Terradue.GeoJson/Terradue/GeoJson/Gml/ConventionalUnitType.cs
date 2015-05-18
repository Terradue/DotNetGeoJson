namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("ConventionalUnit", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ConventionalUnitType : UnitDefinitionType
  {

    private ConversionToPreferredUnitType itemField;

    private ItemChoiceType itemElementNameField;

    private DerivationUnitTermType[] derivationUnitTermField;

    [System.Xml.Serialization.XmlElementAttribute("conversionToPreferredUnit", typeof (ConversionToPreferredUnitType))]
    [System.Xml.Serialization.XmlElementAttribute("roughConversionToPreferredUnit",
      typeof (ConversionToPreferredUnitType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public ConversionToPreferredUnitType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("derivationUnitTerm")]
    public DerivationUnitTermType[] derivationUnitTerm
    {
      get { return derivationUnitTermField; }
      set { derivationUnitTermField = value; }
    }
  }
}
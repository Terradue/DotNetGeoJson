using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("ConventionalUnit", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ConventionalUnitType : UnitDefinitionType
  {
    private DerivationUnitTermType[] derivationUnitTermField;
    private ItemChoiceType itemElementNameField;
    private ConversionToPreferredUnitType itemField;

    [XmlElement("conversionToPreferredUnit", typeof (ConversionToPreferredUnitType))]
    [XmlElement("roughConversionToPreferredUnit",
      typeof (ConversionToPreferredUnitType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public ConversionToPreferredUnitType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement("derivationUnitTerm")]
    public DerivationUnitTermType[] derivationUnitTerm
    {
      get { return derivationUnitTermField; }
      set { derivationUnitTermField = value; }
    }
  }
}
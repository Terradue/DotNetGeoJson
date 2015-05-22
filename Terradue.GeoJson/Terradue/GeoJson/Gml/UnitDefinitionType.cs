using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (ConventionalUnitType))]
  [XmlInclude(typeof (DerivedUnitType))]
  [XmlInclude(typeof (BaseUnitType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("UnitDefinition", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class UnitDefinitionType : DefinitionType
  {
    private CodeType catalogSymbolField;
    private StringOrRefType quantityTypeField;
    private ReferenceType quantityTypeReferenceField;

    [XmlElement]
    public StringOrRefType quantityType
    {
      get { return quantityTypeField; }
      set { quantityTypeField = value; }
    }

    [XmlElement]
    public ReferenceType quantityTypeReference
    {
      get { return quantityTypeReferenceField; }
      set { quantityTypeReferenceField = value; }
    }

    [XmlElement]
    public CodeType catalogSymbol
    {
      get { return catalogSymbolField; }
      set { catalogSymbolField = value; }
    }
  }
}
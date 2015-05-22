using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (DerivedCRSType))]
  [XmlInclude(typeof (ProjectedCRSType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractGeneralDerivedCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractGeneralDerivedCRSType : AbstractCRSType
  {
    private ItemChoiceType16 itemElementNameField;
    private GeneralConversionPropertyType itemField;

    [XmlElement("conversion", typeof (GeneralConversionPropertyType))]
    [XmlElement("definedByConversion", typeof (GeneralConversionPropertyType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public GeneralConversionPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType16 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }
  }
}
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
  [XmlRoot("CompoundCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class CompoundCRSType : AbstractCRSType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private ItemsChoiceType9[] itemsElementNameField;
    private SingleCRSPropertyType[] itemsField;

    [XmlElement("componentReferenceSystem", typeof (SingleCRSPropertyType))]
    [XmlElement("includesSingleCRS", typeof (SingleCRSPropertyType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public SingleCRSPropertyType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType9[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [XmlAttribute]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [XmlIgnore]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}
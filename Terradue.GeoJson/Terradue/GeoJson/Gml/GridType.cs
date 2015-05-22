using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (RectifiedGridType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("Grid", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class GridType : AbstractGeometryType
  {
    private string dimensionField;
    private ItemsChoiceType7[] itemsElementNameField;
    private string[] itemsField;
    private GridLimitsType limitsField;

    [XmlElement]
    public GridLimitsType limits
    {
      get { return limitsField; }
      set { limitsField = value; }
    }

    [XmlElement("axisLabels", typeof (string), DataType = "NCName")]
    [XmlElement("axisName", typeof (string))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public string[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType7[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [XmlAttribute(DataType = "positiveInteger")]
    public string dimension
    {
      get { return dimensionField; }
      set { dimensionField = value; }
    }
  }
}
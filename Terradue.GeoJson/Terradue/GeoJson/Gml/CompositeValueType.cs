using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (ValueArrayType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("CompositeValue", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class CompositeValueType : AbstractGMLType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private ValuePropertyType[] valueComponentField;
    private ValueArrayPropertyType valueComponentsField;

    [XmlElement("valueComponent")]
    public ValuePropertyType[] valueComponent
    {
      get { return valueComponentField; }
      set { valueComponentField = value; }
    }

    [XmlElement]
    public ValueArrayPropertyType valueComponents
    {
      get { return valueComponentsField; }
      set { valueComponentsField = value; }
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
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (DynamicFeatureCollectionType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("DynamicFeature", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DynamicFeatureType : AbstractFeatureType
  {
    private StringOrRefType dataSourceField;
    private ReferenceType dataSourceReferenceField;
    private Item1ChoiceType8 item1ElementNameField;
    private HistoryPropertyType item1Field;
    private TimePrimitivePropertyType validTimeField;

    [XmlElement]
    public TimePrimitivePropertyType validTime
    {
      get { return validTimeField; }
      set { validTimeField = value; }
    }

    [XmlElement("history", typeof (HistoryPropertyType))]
    [XmlElement("track", typeof (HistoryPropertyType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public HistoryPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType8 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }

    [XmlElement]
    public StringOrRefType dataSource
    {
      get { return dataSourceField; }
      set { dataSourceField = value; }
    }

    [XmlElement]
    public ReferenceType dataSourceReference
    {
      get { return dataSourceReferenceField; }
      set { dataSourceReferenceField = value; }
    }
  }
}
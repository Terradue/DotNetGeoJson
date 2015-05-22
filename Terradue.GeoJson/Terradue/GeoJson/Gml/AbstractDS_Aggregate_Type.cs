using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (DS_Initiative_Type))]
  [XmlInclude(typeof (DS_Series_Type))]
  [XmlInclude(typeof (DS_ProductionSeries_Type))]
  [XmlInclude(typeof (DS_Sensor_Type))]
  [XmlInclude(typeof (DS_Platform_Type))]
  [XmlInclude(typeof (DS_OtherAggregate_Type))]
  [XmlInclude(typeof (DS_StereoMate_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract class AbstractDS_Aggregate_Type : AbstractObject_Type
  {
    private DS_DataSet_PropertyType[] composedOfField;
    private MD_Metadata_PropertyType[] seriesMetadataField;
    private DS_Aggregate_PropertyType[] subsetField;
    private DS_Aggregate_PropertyType[] supersetField;

    [XmlElement("composedOf")]
    public DS_DataSet_PropertyType[] composedOf
    {
      get { return composedOfField; }
      set { composedOfField = value; }
    }

    [XmlElement("seriesMetadata")]
    public MD_Metadata_PropertyType[] seriesMetadata
    {
      get { return seriesMetadataField; }
      set { seriesMetadataField = value; }
    }

    [XmlElement("subset")]
    public DS_Aggregate_PropertyType[] subset
    {
      get { return subsetField; }
      set { subsetField = value; }
    }

    [XmlElement("superset")]
    public DS_Aggregate_PropertyType[] superset
    {
      get { return supersetField; }
      set { supersetField = value; }
    }
  }
}
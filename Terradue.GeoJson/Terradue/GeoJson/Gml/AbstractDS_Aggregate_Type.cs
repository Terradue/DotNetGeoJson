namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DS_Initiative_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DS_Series_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DS_ProductionSeries_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DS_Sensor_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DS_Platform_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DS_OtherAggregate_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DS_StereoMate_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract partial class AbstractDS_Aggregate_Type : AbstractObject_Type
  {

    private DS_DataSet_PropertyType[] composedOfField;

    private MD_Metadata_PropertyType[] seriesMetadataField;

    private DS_Aggregate_PropertyType[] subsetField;

    private DS_Aggregate_PropertyType[] supersetField;

    [System.Xml.Serialization.XmlElementAttribute("composedOf")]
    public DS_DataSet_PropertyType[] composedOf
    {
      get { return composedOfField; }
      set { composedOfField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("seriesMetadata")]
    public MD_Metadata_PropertyType[] seriesMetadata
    {
      get { return seriesMetadataField; }
      set { seriesMetadataField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("subset")]
    public DS_Aggregate_PropertyType[] subset
    {
      get { return subsetField; }
      set { subsetField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("superset")]
    public DS_Aggregate_PropertyType[] superset
    {
      get { return supersetField; }
      set { supersetField = value; }
    }
  }
}
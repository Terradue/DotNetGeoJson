using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("target", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)
  ]
  public class TargetPropertyType
  {
    private AbstractGMLType itemField;
    private string nilReasonField;
    private bool ownsField;
    private string remoteSchemaField;

    public TargetPropertyType()
    {
      ownsField = false;
    }

    [XmlElement("AbstractFeature", typeof (AbstractFeatureType))]
    [XmlElement("AbstractGeometry", typeof (AbstractGeometryType))]
    [XmlElement("DynamicFeature", typeof (DynamicFeatureType))]
    [XmlElement("FeatureCollection", typeof (FeatureCollectionType))]
    [XmlElement("GeometricComplex", typeof (GeometricComplexType))]
    [XmlElement("Observation", typeof (ObservationType))]
    public AbstractGMLType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }

    [XmlAttribute]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
    }
  }
}
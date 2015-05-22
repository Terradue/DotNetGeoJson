using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (MovingObjectStatusType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractTimeSlice", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractTimeSliceType : AbstractGMLType
  {
    private StringOrRefType dataSourceField;
    private TimePrimitivePropertyType validTimeField;

    [XmlElement]
    public TimePrimitivePropertyType validTime
    {
      get { return validTimeField; }
      set { validTimeField = value; }
    }

    [XmlElement]
    public StringOrRefType dataSource
    {
      get { return dataSourceField; }
      set { dataSourceField = value; }
    }
  }
}
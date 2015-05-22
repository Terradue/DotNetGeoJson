using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (AngleType))]
  [XmlInclude(typeof (SpeedType))]
  [XmlInclude(typeof (VolumeType))]
  [XmlInclude(typeof (AreaType))]
  [XmlInclude(typeof (GridLengthType))]
  [XmlInclude(typeof (TimeType))]
  [XmlInclude(typeof (ScaleType))]
  [XmlInclude(typeof (LengthType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("measure", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public class MeasureType
  {
    private string uomField;
    private double valueField;

    [XmlAttribute]
    public string uom
    {
      get { return uomField; }
      set { uomField = value; }
    }

    [XmlText]
    public double Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}
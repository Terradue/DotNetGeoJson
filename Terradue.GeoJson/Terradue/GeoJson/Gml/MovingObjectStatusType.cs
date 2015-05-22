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
  [XmlRoot("MovingObjectStatus", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class MovingObjectStatusType : AbstractTimeSliceType
  {
    private MeasureType accelerationField;
    private DirectionPropertyType bearingField;
    private MeasureType elevationField;
    private object itemField;
    private MeasureType speedField;
    private StringOrRefType statusField;
    private ReferenceType statusReferenceField;

    [XmlElement("location", typeof (LocationPropertyType))]
    [XmlElement("locationName", typeof (CodeType))]
    [XmlElement("locationReference", typeof (ReferenceType))]
    [XmlElement("pos", typeof (DirectPositionType))]
    [XmlElement("position", typeof (GeometryPropertyType))]
    [XmlElement("priorityLocation", typeof (PriorityLocationPropertyType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    public MeasureType speed
    {
      get { return speedField; }
      set { speedField = value; }
    }

    [XmlElement]
    public DirectionPropertyType bearing
    {
      get { return bearingField; }
      set { bearingField = value; }
    }

    [XmlElement]
    public MeasureType acceleration
    {
      get { return accelerationField; }
      set { accelerationField = value; }
    }

    [XmlElement]
    public MeasureType elevation
    {
      get { return elevationField; }
      set { elevationField = value; }
    }

    [XmlElement]
    public StringOrRefType status
    {
      get { return statusField; }
      set { statusField = value; }
    }

    [XmlElement]
    public ReferenceType statusReference
    {
      get { return statusReferenceField; }
      set { statusReferenceField = value; }
    }
  }
}
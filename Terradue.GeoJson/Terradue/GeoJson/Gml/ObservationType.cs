using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (DirectedObservationType))]
  [XmlInclude(typeof (DirectedObservationAtDistanceType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("Observation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ObservationType : AbstractFeatureType
  {
    private Item1ChoiceType10 item1ElementNameField;
    private TargetPropertyType item1Field;
    private ResultType resultOfField;
    private ProcedurePropertyType usingField;
    private TimePrimitivePropertyType validTimeField;

    [XmlElement]
    public TimePrimitivePropertyType validTime
    {
      get { return validTimeField; }
      set { validTimeField = value; }
    }

    [XmlElement]
    public ProcedurePropertyType @using
    {
      get { return usingField; }
      set { usingField = value; }
    }

    [XmlElement("subject", typeof (TargetPropertyType))]
    [XmlElement("target", typeof (TargetPropertyType))]
    [XmlChoiceIdentifier("Item1ElementName")]
    public TargetPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public Item1ChoiceType10 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }

    [XmlElement]
    public ResultType resultOf
    {
      get { return resultOfField; }
      set { resultOfField = value; }
    }
  }
}
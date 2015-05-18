using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRootAttribute("TimePeriod", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimePeriodType : AbstractTimeGeometricPrimitiveType
  {

    private object itemField;

    private object item1Field;

    private string durationField;

    private TimeIntervalLengthType timeIntervalField;

    [XmlElementAttribute("begin", typeof (TimeInstantPropertyType))]
    [XmlElementAttribute("beginPosition", typeof (TimePositionType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlIgnore]
    public TimePositionType beginPosition
    {
      get { return (TimePositionType) itemField; }
      set { itemField = value; }
    }

    [XmlElement("end", typeof (TimeInstantPropertyType))]
    [XmlElement("endPosition", typeof (TimePositionType))]
    public object Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlIgnore]
    public TimePositionType endPosition
    {
      get { return (TimePositionType) item1Field; }
      set { item1Field = value; }
    }

    [XmlElement(DataType = "duration")]
    public string duration
    {
      get { return durationField; }
      set { durationField = value; }
    }

    [XmlElement()]
    public TimeIntervalLengthType timeInterval
    {
      get { return timeIntervalField; }
      set { timeIntervalField = value; }
    }
  }
}
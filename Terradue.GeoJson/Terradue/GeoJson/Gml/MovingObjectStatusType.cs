namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("MovingObjectStatus", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class MovingObjectStatusType : AbstractTimeSliceType
  {

    private object itemField;

    private MeasureType speedField;

    private DirectionPropertyType bearingField;

    private MeasureType accelerationField;

    private MeasureType elevationField;

    private StringOrRefType statusField;

    private ReferenceType statusReferenceField;

    [System.Xml.Serialization.XmlElementAttribute("location", typeof (LocationPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("locationName", typeof (CodeType))]
    [System.Xml.Serialization.XmlElementAttribute("locationReference", typeof (ReferenceType))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof (DirectPositionType))]
    [System.Xml.Serialization.XmlElementAttribute("position", typeof (GeometryPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("priorityLocation", typeof (PriorityLocationPropertyType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MeasureType speed
    {
      get { return speedField; }
      set { speedField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public DirectionPropertyType bearing
    {
      get { return bearingField; }
      set { bearingField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MeasureType acceleration
    {
      get { return accelerationField; }
      set { accelerationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MeasureType elevation
    {
      get { return elevationField; }
      set { elevationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public StringOrRefType status
    {
      get { return statusField; }
      set { statusField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public ReferenceType statusReference
    {
      get { return statusReferenceField; }
      set { statusReferenceField = value; }
    }
  }
}
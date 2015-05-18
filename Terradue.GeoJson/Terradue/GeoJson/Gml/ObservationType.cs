namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DirectedObservationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DirectedObservationAtDistanceType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Observation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ObservationType : AbstractFeatureType
  {

    private TimePrimitivePropertyType validTimeField;

    private ProcedurePropertyType usingField;

    private TargetPropertyType item1Field;

    private Item1ChoiceType10 item1ElementNameField;

    private ResultType resultOfField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimePrimitivePropertyType validTime
    {
      get { return validTimeField; }
      set { validTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public ProcedurePropertyType @using
    {
      get { return usingField; }
      set { usingField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("subject", typeof (TargetPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("target", typeof (TargetPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public TargetPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType10 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public ResultType resultOf
    {
      get { return resultOfField; }
      set { resultOfField = value; }
    }
  }
}
namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DirectedObservationAtDistanceType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("DirectedObservation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DirectedObservationType : ObservationType
  {

    private DirectionPropertyType directionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public DirectionPropertyType direction
    {
      get { return directionField; }
      set { directionField = value; }
    }
  }
}
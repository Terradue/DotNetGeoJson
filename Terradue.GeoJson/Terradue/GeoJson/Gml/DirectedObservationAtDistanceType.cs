namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("DirectedObservationAtDistance",
    Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class DirectedObservationAtDistanceType : DirectedObservationType
  {

    private MeasureType distanceField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MeasureType distance
    {
      get { return distanceField; }
      set { distanceField = value; }
    }
  }
}
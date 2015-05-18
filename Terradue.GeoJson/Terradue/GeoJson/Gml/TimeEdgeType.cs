namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TimeEdge", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimeEdgeType : AbstractTimeTopologyPrimitiveType
  {

    private TimeNodePropertyType startField;

    private TimeNodePropertyType endField;

    private TimePeriodPropertyType extentField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimeNodePropertyType start
    {
      get { return startField; }
      set { startField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimeNodePropertyType end
    {
      get { return endField; }
      set { endField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimePeriodPropertyType extent
    {
      get { return extentField; }
      set { extentField = value; }
    }
  }
}
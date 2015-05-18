namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AngleType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (SpeedType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (VolumeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AreaType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GridLengthType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ScaleType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (LengthType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("measure", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public partial class MeasureType
  {

    private string uomField;

    private double valueField;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uom
    {
      get { return uomField; }
      set { uomField = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public double Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}
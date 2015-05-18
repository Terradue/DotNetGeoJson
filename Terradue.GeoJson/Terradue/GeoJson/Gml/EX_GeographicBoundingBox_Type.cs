namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class EX_GeographicBoundingBox_Type : AbstractEX_GeographicExtent_Type
  {

    private Decimal_PropertyType westBoundLongitudeField;

    private Decimal_PropertyType eastBoundLongitudeField;

    private Decimal_PropertyType southBoundLatitudeField;

    private Decimal_PropertyType northBoundLatitudeField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Decimal_PropertyType westBoundLongitude
    {
      get { return westBoundLongitudeField; }
      set { westBoundLongitudeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Decimal_PropertyType eastBoundLongitude
    {
      get { return eastBoundLongitudeField; }
      set { eastBoundLongitudeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Decimal_PropertyType southBoundLatitude
    {
      get { return southBoundLatitudeField; }
      set { southBoundLatitudeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Decimal_PropertyType northBoundLatitude
    {
      get { return northBoundLatitudeField; }
      set { northBoundLatitudeField = value; }
    }
  }
}
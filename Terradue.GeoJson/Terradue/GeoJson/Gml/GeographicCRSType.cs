namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("GeographicCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class GeographicCRSType : AbstractCRSType
  {

    private EllipsoidalCSPropertyType usesEllipsoidalCSField;

    private GeodeticDatumPropertyType usesGeodeticDatumField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public EllipsoidalCSPropertyType usesEllipsoidalCS
    {
      get { return usesEllipsoidalCSField; }
      set { usesEllipsoidalCSField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public GeodeticDatumPropertyType usesGeodeticDatum
    {
      get { return usesGeodeticDatumField; }
      set { usesGeodeticDatumField = value; }
    }
  }
}
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class EX_GeographicBoundingBox_Type : AbstractEX_GeographicExtent_Type
  {
    private Decimal_PropertyType eastBoundLongitudeField;
    private Decimal_PropertyType northBoundLatitudeField;
    private Decimal_PropertyType southBoundLatitudeField;
    private Decimal_PropertyType westBoundLongitudeField;

    [XmlElement]
    public Decimal_PropertyType westBoundLongitude
    {
      get { return westBoundLongitudeField; }
      set { westBoundLongitudeField = value; }
    }

    [XmlElement]
    public Decimal_PropertyType eastBoundLongitude
    {
      get { return eastBoundLongitudeField; }
      set { eastBoundLongitudeField = value; }
    }

    [XmlElement]
    public Decimal_PropertyType southBoundLatitude
    {
      get { return southBoundLatitudeField; }
      set { southBoundLatitudeField = value; }
    }

    [XmlElement]
    public Decimal_PropertyType northBoundLatitude
    {
      get { return northBoundLatitudeField; }
      set { northBoundLatitudeField = value; }
    }
  }
}
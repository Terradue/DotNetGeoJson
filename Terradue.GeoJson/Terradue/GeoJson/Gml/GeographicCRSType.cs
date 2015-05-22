using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("GeographicCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class GeographicCRSType : AbstractCRSType
  {
    private EllipsoidalCSPropertyType usesEllipsoidalCSField;
    private GeodeticDatumPropertyType usesGeodeticDatumField;

    [XmlElement]
    public EllipsoidalCSPropertyType usesEllipsoidalCS
    {
      get { return usesEllipsoidalCSField; }
      set { usesEllipsoidalCSField = value; }
    }

    [XmlElement]
    public GeodeticDatumPropertyType usesGeodeticDatum
    {
      get { return usesGeodeticDatumField; }
      set { usesGeodeticDatumField = value; }
    }
  }
}
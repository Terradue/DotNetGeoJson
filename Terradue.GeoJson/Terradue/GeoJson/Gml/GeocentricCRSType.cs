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
  [XmlRoot("GeocentricCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class GeocentricCRSType : AbstractCRSType
  {
    private object itemField;
    private GeodeticDatumPropertyType usesGeodeticDatumField;

    [XmlElement("usesCartesianCS", typeof (CartesianCSPropertyType))]
    [XmlElement("usesSphericalCS", typeof (SphericalCSPropertyType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    public GeodeticDatumPropertyType usesGeodeticDatum
    {
      get { return usesGeodeticDatumField; }
      set { usesGeodeticDatumField = value; }
    }
  }
}
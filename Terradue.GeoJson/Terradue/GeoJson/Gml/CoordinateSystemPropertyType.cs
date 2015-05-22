using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("coordinateSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class CoordinateSystemPropertyType
  {
    private AbstractCoordinateSystemType itemField;
    private string nilReasonField;
    private string remoteSchemaField;

    [XmlElement("AffineCS", typeof (AffineCSType))]
    [XmlElement("CartesianCS", typeof (CartesianCSType))]
    [XmlElement("CylindricalCS", typeof (CylindricalCSType))]
    [XmlElement("EllipsoidalCS", typeof (EllipsoidalCSType))]
    [XmlElement("LinearCS", typeof (LinearCSType))]
    [XmlElement("ObliqueCartesianCS", typeof (ObliqueCartesianCSType))]
    [XmlElement("PolarCS", typeof (PolarCSType))]
    [XmlElement("SphericalCS", typeof (SphericalCSType))]
    [XmlElement("TemporalCS", typeof (TemporalCSType))]
    [XmlElement("TimeCS", typeof (TimeCSType))]
    [XmlElement("UserDefinedCS", typeof (UserDefinedCSType))]
    [XmlElement("VerticalCS", typeof (VerticalCSType))]
    public AbstractCoordinateSystemType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlAttribute]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
    }
  }
}
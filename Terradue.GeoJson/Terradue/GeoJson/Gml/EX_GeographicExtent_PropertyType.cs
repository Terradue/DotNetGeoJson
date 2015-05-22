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
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class EX_GeographicExtent_PropertyType
  {
    private AbstractEX_GeographicExtent_Type itemField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement("EX_BoundingPolygon", typeof (EX_BoundingPolygon_Type))]
    [XmlElement("EX_GeographicBoundingBox", typeof (EX_GeographicBoundingBox_Type))]
    [XmlElement("EX_GeographicDescription", typeof (EX_GeographicDescription_Type))]
    public AbstractEX_GeographicExtent_Type Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlAttribute]
    public string uuidref
    {
      get { return uuidrefField; }
      set { uuidrefField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      Namespace = "http://www.isotc211.org/2005/gco")]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}
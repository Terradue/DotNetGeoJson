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
  public class DS_Series_PropertyType
  {
    private DS_Series_Type itemField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement("DS_Platform", typeof (DS_Platform_Type))]
    [XmlElement("DS_ProductionSeries", typeof (DS_ProductionSeries_Type))]
    [XmlElement("DS_Sensor", typeof (DS_Sensor_Type))]
    [XmlElement("DS_Series", typeof (DS_Series_Type))]
    public DS_Series_Type Item
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
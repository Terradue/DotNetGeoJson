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
  [XmlType(Namespace = "http://www.isotc211.org/2005/gco")]
  public class UomLength_PropertyType
  {
    private UnitDefinitionType itemField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement("BaseUnit", typeof (BaseUnitType),
      Namespace = "http://www.opengis.net/gml/3.2")]
    [XmlElement("ConventionalUnit", typeof (ConventionalUnitType),
      Namespace = "http://www.opengis.net/gml/3.2")]
    [XmlElement("DerivedUnit", typeof (DerivedUnitType),
      Namespace = "http://www.opengis.net/gml/3.2")]
    [XmlElement("UnitDefinition", typeof (UnitDefinitionType),
      Namespace = "http://www.opengis.net/gml/3.2")]
    public UnitDefinitionType Item
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

    [XmlAttribute(Form = XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}
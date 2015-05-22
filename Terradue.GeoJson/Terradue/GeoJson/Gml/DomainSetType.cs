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
  [XmlRoot("domainSet", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DomainSetType
  {
    private AbstractGMLType itemField;
    private string nilReasonField;
    private bool ownsField;
    private string remoteSchemaField;

    public DomainSetType()
    {
      ownsField = false;
    }

    [XmlElement("AbstractGeometry", typeof (AbstractGeometryType))]
    [XmlElement("AbstractTimeObject", typeof (AbstractTimeObjectType))]
    [XmlElement("GeometricComplex", typeof (GeometricComplexType))]
    public AbstractGMLType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
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
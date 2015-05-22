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
  public class DQ_DomainConsistency_PropertyType
  {
    private DQ_DomainConsistency_Type dQ_DomainConsistencyField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement]
    public DQ_DomainConsistency_Type DQ_DomainConsistency
    {
      get { return dQ_DomainConsistencyField; }
      set { dQ_DomainConsistencyField = value; }
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
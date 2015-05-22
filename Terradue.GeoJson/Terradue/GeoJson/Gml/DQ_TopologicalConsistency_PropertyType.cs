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
  public class DQ_TopologicalConsistency_PropertyType
  {
    private DQ_TopologicalConsistency_Type dQ_TopologicalConsistencyField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement]
    public DQ_TopologicalConsistency_Type DQ_TopologicalConsistency
    {
      get { return dQ_TopologicalConsistencyField; }
      set { dQ_TopologicalConsistencyField = value; }
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
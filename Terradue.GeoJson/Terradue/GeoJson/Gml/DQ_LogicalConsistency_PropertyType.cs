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
  public class DQ_LogicalConsistency_PropertyType
  {
    private AbstractDQ_LogicalConsistency_Type itemField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement("DQ_ConceptualConsistency", typeof (DQ_ConceptualConsistency_Type))]
    [XmlElement("DQ_DomainConsistency", typeof (DQ_DomainConsistency_Type))]
    [XmlElement("DQ_FormatConsistency", typeof (DQ_FormatConsistency_Type))]
    [XmlElement("DQ_TopologicalConsistency", typeof (DQ_TopologicalConsistency_Type))]
    public AbstractDQ_LogicalConsistency_Type Item
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
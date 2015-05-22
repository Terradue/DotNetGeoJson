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
  public class DQ_ThematicAccuracy_PropertyType
  {
    private AbstractDQ_ThematicAccuracy_Type itemField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement("DQ_NonQuantitativeAttributeAccuracy",
      typeof (DQ_NonQuantitativeAttributeAccuracy_Type))]
    [XmlElement("DQ_QuantitativeAttributeAccuracy",
      typeof (DQ_QuantitativeAttributeAccuracy_Type))]
    [XmlElement("DQ_ThematicClassificationCorrectness",
      typeof (DQ_ThematicClassificationCorrectness_Type))]
    public AbstractDQ_ThematicAccuracy_Type Item
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
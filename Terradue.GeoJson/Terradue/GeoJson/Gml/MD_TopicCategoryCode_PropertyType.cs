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
  public class MD_TopicCategoryCode_PropertyType
  {
    private MD_TopicCategoryCode_Type mD_TopicCategoryCodeField;
    private string nilReasonField;

    [XmlElement]
    public MD_TopicCategoryCode_Type MD_TopicCategoryCode
    {
      get { return mD_TopicCategoryCodeField; }
      set { mD_TopicCategoryCodeField = value; }
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
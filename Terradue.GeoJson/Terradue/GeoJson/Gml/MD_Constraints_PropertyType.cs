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
  public class MD_Constraints_PropertyType
  {
    private MD_Constraints_Type itemField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement("MD_Constraints", typeof (MD_Constraints_Type))]
    [XmlElement("MD_LegalConstraints", typeof (MD_LegalConstraints_Type))]
    [XmlElement("MD_SecurityConstraints", typeof (MD_SecurityConstraints_Type))]
    public MD_Constraints_Type Item
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
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
  public class MD_SpatialRepresentation_PropertyType
  {
    private AbstractMD_SpatialRepresentation_Type itemField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement("MD_GridSpatialRepresentation",
      typeof (MD_GridSpatialRepresentation_Type))]
    [XmlElement("MD_VectorSpatialRepresentation",
      typeof (MD_VectorSpatialRepresentation_Type))]
    public AbstractMD_SpatialRepresentation_Type Item
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
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
  public class MD_PortrayalCatalogueReference_PropertyType
  {
    private MD_PortrayalCatalogueReference_Type mD_PortrayalCatalogueReferenceField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement]
    public MD_PortrayalCatalogueReference_Type MD_PortrayalCatalogueReference
    {
      get { return mD_PortrayalCatalogueReferenceField; }
      set { mD_PortrayalCatalogueReferenceField = value; }
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
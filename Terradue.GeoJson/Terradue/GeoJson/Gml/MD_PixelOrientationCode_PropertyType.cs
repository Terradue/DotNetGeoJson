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
  public class MD_PixelOrientationCode_PropertyType
  {
    private MD_PixelOrientationCode_Type mD_PixelOrientationCodeField;
    private string nilReasonField;

    [XmlElement]
    public MD_PixelOrientationCode_Type MD_PixelOrientationCode
    {
      get { return mD_PixelOrientationCodeField; }
      set { mD_PixelOrientationCodeField = value; }
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
namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_PixelOrientationCode_PropertyType
  {

    private MD_PixelOrientationCode_Type mD_PixelOrientationCodeField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_PixelOrientationCode_Type MD_PixelOrientationCode
    {
      get { return mD_PixelOrientationCodeField; }
      set { mD_PixelOrientationCodeField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      Namespace = "http://www.isotc211.org/2005/gco")]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}
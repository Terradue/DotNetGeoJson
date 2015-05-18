using System;
using System.Linq;

namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("valueList", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class MeasureListType
  {

    private string uomField;

    private double[] textField;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uom
    {
      get { return uomField; }
      set { uomField = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Text
    {
      get
      {
        if (textField == null)
          return null;
        return String.Join(" ", Array.ConvertAll(textField, Convert.ToString));
      }
      set
      {
        var values = value.Split(' ');
        textField = Array.ConvertAll(values.Where(s => !string.IsNullOrEmpty(s)).ToArray(), Double.Parse);
      }
    }
  }
}
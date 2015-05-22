using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("valueList", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class MeasureListType
  {
    private double[] textField;
    private string uomField;

    [XmlAttribute]
    public string uom
    {
      get { return uomField; }
      set { uomField = value; }
    }

    [XmlText]
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
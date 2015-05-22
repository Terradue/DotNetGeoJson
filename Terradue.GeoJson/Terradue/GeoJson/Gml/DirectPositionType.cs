using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (VectorType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("pos", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class DirectPositionType
  {
    private string srsDimensionField;
    private string srsNameField;
    private double[] textField;

    [XmlAttribute(DataType = "anyURI")]
    public string srsName
    {
      get { return srsNameField; }
      set { srsNameField = value; }
    }

    [XmlAttribute(DataType = "positiveInteger")]
    public string srsDimension
    {
      get { return srsDimensionField; }
      set { srsDimensionField = value; }
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
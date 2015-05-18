using System;
using System.Linq;

namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("posList", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public partial class DirectPositionListType
  {

    private string srsNameField;

    private string srsDimensionField;

    private string countField;

    private double[] textField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string srsName
    {
      get { return srsNameField; }
      set { srsNameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
    public string srsDimension
    {
      get { return srsDimensionField; }
      set { srsDimensionField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
    public string count
    {
      get { return countField; }
      set { countField = value; }
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
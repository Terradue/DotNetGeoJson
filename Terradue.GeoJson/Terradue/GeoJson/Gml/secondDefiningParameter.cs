using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class secondDefiningParameter
  {
    private SecondDefiningParameter secondDefiningParameterField;

    [XmlElement]
    public SecondDefiningParameter SecondDefiningParameter
    {
      get { return secondDefiningParameterField; }
      set { secondDefiningParameterField = value; }
    }
  }
}
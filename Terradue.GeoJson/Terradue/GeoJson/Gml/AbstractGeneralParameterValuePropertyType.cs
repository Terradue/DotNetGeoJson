using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("parameterValue", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class AbstractGeneralParameterValuePropertyType
  {
    private AbstractGeneralParameterValueType itemField;

    [XmlElement("ParameterValue", typeof (ParameterValueType))]
    [XmlElement("ParameterValueGroup", typeof (ParameterValueGroupType))]
    public AbstractGeneralParameterValueType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}
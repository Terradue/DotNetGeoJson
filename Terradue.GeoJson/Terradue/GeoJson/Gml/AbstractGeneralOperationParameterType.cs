using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (OperationParameterGroupType))]
  [XmlInclude(typeof (OperationParameterType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractGeneralOperationParameter",
    Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public abstract class AbstractGeneralOperationParameterType : IdentifiedObjectType
  {
    private string minimumOccursField;

    [XmlElement(DataType = "nonNegativeInteger")]
    public string minimumOccurs
    {
      get { return minimumOccursField; }
      set { minimumOccursField = value; }
    }
  }
}
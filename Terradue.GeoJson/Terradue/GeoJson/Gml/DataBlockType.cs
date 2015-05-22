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
  [XmlRoot("DataBlock", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DataBlockType
  {
    private object itemField;
    private AssociationRoleType rangeParametersField;

    [XmlElement]
    public AssociationRoleType rangeParameters
    {
      get { return rangeParametersField; }
      set { rangeParametersField = value; }
    }

    [XmlElement("doubleOrNilReasonTupleList", typeof (string))]
    [XmlElement("tupleList", typeof (CoordinatesType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}
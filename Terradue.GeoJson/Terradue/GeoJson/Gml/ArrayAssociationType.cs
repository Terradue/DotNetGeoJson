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
  [XmlRoot("members", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public class ArrayAssociationType
  {
    private object[] itemsField;
    private bool ownsField;

    public ArrayAssociationType()
    {
      ownsField = false;
    }

    [XmlElement("AffinePlacement", typeof (AffinePlacementType))]
    [XmlElement("CoverageMappingRule", typeof (MappingRuleType))]
    [XmlElement("DataBlock", typeof (DataBlockType))]
    [XmlElement("Envelope", typeof (EnvelopeType))]
    [XmlElement("File", typeof (FileType))]
    [XmlElement("GridFunction", typeof (GridFunctionType))]
    [XmlElement("Shell", typeof (ShellType))]
    [XmlElement("coverageFunction", typeof (CoverageFunctionType))]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}
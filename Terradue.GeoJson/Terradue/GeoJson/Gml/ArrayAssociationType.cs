namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("members", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public partial class ArrayAssociationType
  {

    private object[] itemsField;

    private bool ownsField;

    public ArrayAssociationType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("AffinePlacement", typeof (AffinePlacementType))]
    [System.Xml.Serialization.XmlElementAttribute("CoverageMappingRule", typeof (MappingRuleType))]
    [System.Xml.Serialization.XmlElementAttribute("DataBlock", typeof (DataBlockType))]
    [System.Xml.Serialization.XmlElementAttribute("Envelope", typeof (EnvelopeType))]
    [System.Xml.Serialization.XmlElementAttribute("File", typeof (FileType))]
    [System.Xml.Serialization.XmlElementAttribute("GridFunction", typeof (GridFunctionType))]
    [System.Xml.Serialization.XmlElementAttribute("Shell", typeof (ShellType))]
    [System.Xml.Serialization.XmlElementAttribute("coverageFunction", typeof (CoverageFunctionType))]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}
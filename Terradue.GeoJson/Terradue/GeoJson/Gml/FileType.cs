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
  [XmlRoot("File", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class FileType
  {
    private string compressionField;
    private CodeType fileStructureField;
    private ItemChoiceType18 itemElementNameField;
    private string itemField;
    private string mimeTypeField;
    private AssociationRoleType rangeParametersField;

    [XmlElement]
    public AssociationRoleType rangeParameters
    {
      get { return rangeParametersField; }
      set { rangeParametersField = value; }
    }

    [XmlElement("fileName", typeof (string), DataType = "anyURI")]
    [XmlElement("fileReference", typeof (string), DataType = "anyURI")]
    [XmlChoiceIdentifier("ItemElementName")]
    public string Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType18 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement]
    public CodeType fileStructure
    {
      get { return fileStructureField; }
      set { fileStructureField = value; }
    }

    [XmlElement(DataType = "anyURI")]
    public string mimeType
    {
      get { return mimeTypeField; }
      set { mimeTypeField = value; }
    }

    [XmlElement(DataType = "anyURI")]
    public string compression
    {
      get { return compressionField; }
      set { compressionField = value; }
    }
  }
}
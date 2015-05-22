using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class MD_Format_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType amendmentNumberField;
    private CharacterString_PropertyType fileDecompressionTechniqueField;
    private MD_Distributor_PropertyType[] formatDistributorField;
    private CharacterString_PropertyType nameField;
    private CharacterString_PropertyType specificationField;
    private CharacterString_PropertyType versionField;

    [XmlElement]
    public CharacterString_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType version
    {
      get { return versionField; }
      set { versionField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType amendmentNumber
    {
      get { return amendmentNumberField; }
      set { amendmentNumberField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType specification
    {
      get { return specificationField; }
      set { specificationField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType fileDecompressionTechnique
    {
      get { return fileDecompressionTechniqueField; }
      set { fileDecompressionTechniqueField = value; }
    }

    [XmlElement("formatDistributor")]
    public MD_Distributor_PropertyType[] formatDistributor
    {
      get { return formatDistributorField; }
      set { formatDistributorField = value; }
    }
  }
}
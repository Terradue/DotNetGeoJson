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
  [XmlRoot("solidMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class SolidArrayPropertyType
  {
    private AbstractSolidType[] itemsField;
    private bool ownsField;

    public SolidArrayPropertyType()
    {
      ownsField = false;
    }

    [XmlElement("CompositeSolid", typeof (CompositeSolidType))]
    [XmlElement("Solid", typeof (SolidType))]
    public AbstractSolidType[] Items
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
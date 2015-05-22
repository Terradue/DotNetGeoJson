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
  public class ClothoidTypeRefLocation
  {
    private AffinePlacementType affinePlacementField;

    [XmlElement]
    public AffinePlacementType AffinePlacement
    {
      get { return affinePlacementField; }
      set { affinePlacementField = value; }
    }
  }
}
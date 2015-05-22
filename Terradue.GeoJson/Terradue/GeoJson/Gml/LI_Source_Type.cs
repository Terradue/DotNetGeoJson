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
  public class LI_Source_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType descriptionField;
    private MD_RepresentativeFraction_PropertyType scaleDenominatorField;
    private CI_Citation_PropertyType sourceCitationField;
    private EX_Extent_PropertyType[] sourceExtentField;
    private MD_ReferenceSystem_PropertyType sourceReferenceSystemField;
    private LI_ProcessStep_PropertyType[] sourceStepField;

    [XmlElement]
    public CharacterString_PropertyType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [XmlElement]
    public MD_RepresentativeFraction_PropertyType scaleDenominator
    {
      get { return scaleDenominatorField; }
      set { scaleDenominatorField = value; }
    }

    [XmlElement]
    public MD_ReferenceSystem_PropertyType sourceReferenceSystem
    {
      get { return sourceReferenceSystemField; }
      set { sourceReferenceSystemField = value; }
    }

    [XmlElement]
    public CI_Citation_PropertyType sourceCitation
    {
      get { return sourceCitationField; }
      set { sourceCitationField = value; }
    }

    [XmlElement("sourceExtent")]
    public EX_Extent_PropertyType[] sourceExtent
    {
      get { return sourceExtentField; }
      set { sourceExtentField = value; }
    }

    [XmlElement("sourceStep")]
    public LI_ProcessStep_PropertyType[] sourceStep
    {
      get { return sourceStepField; }
      set { sourceStepField = value; }
    }
  }
}
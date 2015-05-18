namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class LI_Source_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType descriptionField;

    private MD_RepresentativeFraction_PropertyType scaleDenominatorField;

    private MD_ReferenceSystem_PropertyType sourceReferenceSystemField;

    private CI_Citation_PropertyType sourceCitationField;

    private EX_Extent_PropertyType[] sourceExtentField;

    private LI_ProcessStep_PropertyType[] sourceStepField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_RepresentativeFraction_PropertyType scaleDenominator
    {
      get { return scaleDenominatorField; }
      set { scaleDenominatorField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_ReferenceSystem_PropertyType sourceReferenceSystem
    {
      get { return sourceReferenceSystemField; }
      set { sourceReferenceSystemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Citation_PropertyType sourceCitation
    {
      get { return sourceCitationField; }
      set { sourceCitationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("sourceExtent")]
    public EX_Extent_PropertyType[] sourceExtent
    {
      get { return sourceExtentField; }
      set { sourceExtentField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("sourceStep")]
    public LI_ProcessStep_PropertyType[] sourceStep
    {
      get { return sourceStepField; }
      set { sourceStepField = value; }
    }
  }
}
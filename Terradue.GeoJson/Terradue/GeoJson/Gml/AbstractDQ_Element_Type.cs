namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractDQ_Completeness_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_CompletenessCommission_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_CompletenessOmission_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractDQ_LogicalConsistency_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_ConceptualConsistency_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_DomainConsistency_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_FormatConsistency_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_TopologicalConsistency_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractDQ_PositionalAccuracy_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_AbsoluteExternalPositionalAccuracy_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_GriddedDataPositionalAccuracy_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_RelativeInternalPositionalAccuracy_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractDQ_ThematicAccuracy_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_ThematicClassificationCorrectness_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_NonQuantitativeAttributeAccuracy_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_QuantitativeAttributeAccuracy_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractDQ_TemporalAccuracy_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_AccuracyOfATimeMeasurement_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_TemporalConsistency_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DQ_TemporalValidity_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract partial class AbstractDQ_Element_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType[] nameOfMeasureField;

    private MD_Identifier_PropertyType measureIdentificationField;

    private CharacterString_PropertyType measureDescriptionField;

    private DQ_EvaluationMethodTypeCode_PropertyType evaluationMethodTypeField;

    private CharacterString_PropertyType evaluationMethodDescriptionField;

    private CI_Citation_PropertyType evaluationProcedureField;

    private DateTime_PropertyType[] dateTimeField;

    private DQ_Result_PropertyType[] resultField;

    [System.Xml.Serialization.XmlElementAttribute("nameOfMeasure")]
    public CharacterString_PropertyType[] nameOfMeasure
    {
      get { return nameOfMeasureField; }
      set { nameOfMeasureField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_Identifier_PropertyType measureIdentification
    {
      get { return measureIdentificationField; }
      set { measureIdentificationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType measureDescription
    {
      get { return measureDescriptionField; }
      set { measureDescriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public DQ_EvaluationMethodTypeCode_PropertyType evaluationMethodType
    {
      get { return evaluationMethodTypeField; }
      set { evaluationMethodTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType evaluationMethodDescription
    {
      get { return evaluationMethodDescriptionField; }
      set { evaluationMethodDescriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Citation_PropertyType evaluationProcedure
    {
      get { return evaluationProcedureField; }
      set { evaluationProcedureField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("dateTime")]
    public DateTime_PropertyType[] dateTime
    {
      get { return dateTimeField; }
      set { dateTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("result")]
    public DQ_Result_PropertyType[] result
    {
      get { return resultField; }
      set { resultField = value; }
    }
  }
}
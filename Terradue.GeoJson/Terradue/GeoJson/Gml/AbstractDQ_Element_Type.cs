using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (AbstractDQ_Completeness_Type))]
  [XmlInclude(typeof (DQ_CompletenessCommission_Type))]
  [XmlInclude(typeof (DQ_CompletenessOmission_Type))]
  [XmlInclude(typeof (AbstractDQ_LogicalConsistency_Type))]
  [XmlInclude(typeof (DQ_ConceptualConsistency_Type))]
  [XmlInclude(typeof (DQ_DomainConsistency_Type))]
  [XmlInclude(typeof (DQ_FormatConsistency_Type))]
  [XmlInclude(typeof (DQ_TopologicalConsistency_Type))]
  [XmlInclude(typeof (AbstractDQ_PositionalAccuracy_Type))]
  [XmlInclude(typeof (DQ_AbsoluteExternalPositionalAccuracy_Type))]
  [XmlInclude(typeof (DQ_GriddedDataPositionalAccuracy_Type))]
  [XmlInclude(typeof (DQ_RelativeInternalPositionalAccuracy_Type))]
  [XmlInclude(typeof (AbstractDQ_ThematicAccuracy_Type))]
  [XmlInclude(typeof (DQ_ThematicClassificationCorrectness_Type))]
  [XmlInclude(typeof (DQ_NonQuantitativeAttributeAccuracy_Type))]
  [XmlInclude(typeof (DQ_QuantitativeAttributeAccuracy_Type))]
  [XmlInclude(typeof (AbstractDQ_TemporalAccuracy_Type))]
  [XmlInclude(typeof (DQ_AccuracyOfATimeMeasurement_Type))]
  [XmlInclude(typeof (DQ_TemporalConsistency_Type))]
  [XmlInclude(typeof (DQ_TemporalValidity_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract class AbstractDQ_Element_Type : AbstractObject_Type
  {
    private DateTime_PropertyType[] dateTimeField;
    private CharacterString_PropertyType evaluationMethodDescriptionField;
    private DQ_EvaluationMethodTypeCode_PropertyType evaluationMethodTypeField;
    private CI_Citation_PropertyType evaluationProcedureField;
    private CharacterString_PropertyType measureDescriptionField;
    private MD_Identifier_PropertyType measureIdentificationField;
    private CharacterString_PropertyType[] nameOfMeasureField;
    private DQ_Result_PropertyType[] resultField;

    [XmlElement("nameOfMeasure")]
    public CharacterString_PropertyType[] nameOfMeasure
    {
      get { return nameOfMeasureField; }
      set { nameOfMeasureField = value; }
    }

    [XmlElement]
    public MD_Identifier_PropertyType measureIdentification
    {
      get { return measureIdentificationField; }
      set { measureIdentificationField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType measureDescription
    {
      get { return measureDescriptionField; }
      set { measureDescriptionField = value; }
    }

    [XmlElement]
    public DQ_EvaluationMethodTypeCode_PropertyType evaluationMethodType
    {
      get { return evaluationMethodTypeField; }
      set { evaluationMethodTypeField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType evaluationMethodDescription
    {
      get { return evaluationMethodDescriptionField; }
      set { evaluationMethodDescriptionField = value; }
    }

    [XmlElement]
    public CI_Citation_PropertyType evaluationProcedure
    {
      get { return evaluationProcedureField; }
      set { evaluationProcedureField = value; }
    }

    [XmlElement("dateTime")]
    public DateTime_PropertyType[] dateTime
    {
      get { return dateTimeField; }
      set { dateTimeField = value; }
    }

    [XmlElement("result")]
    public DQ_Result_PropertyType[] result
    {
      get { return resultField; }
      set { resultField = value; }
    }
  }
}
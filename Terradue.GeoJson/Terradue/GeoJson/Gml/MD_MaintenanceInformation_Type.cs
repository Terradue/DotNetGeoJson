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
  public class MD_MaintenanceInformation_Type : AbstractObject_Type
  {
    private CI_ResponsibleParty_PropertyType[] contactField;
    private Date_PropertyType dateOfNextUpdateField;
    private MD_MaintenanceFrequencyCode_PropertyType maintenanceAndUpdateFrequencyField;
    private CharacterString_PropertyType[] maintenanceNoteField;
    private MD_ScopeDescription_PropertyType[] updateScopeDescriptionField;
    private MD_ScopeCode_PropertyType[] updateScopeField;
    private TM_PeriodDuration_PropertyType userDefinedMaintenanceFrequencyField;

    [XmlElement]
    public MD_MaintenanceFrequencyCode_PropertyType maintenanceAndUpdateFrequency
    {
      get { return maintenanceAndUpdateFrequencyField; }
      set { maintenanceAndUpdateFrequencyField = value; }
    }

    [XmlElement]
    public Date_PropertyType dateOfNextUpdate
    {
      get { return dateOfNextUpdateField; }
      set { dateOfNextUpdateField = value; }
    }

    [XmlElement]
    public TM_PeriodDuration_PropertyType userDefinedMaintenanceFrequency
    {
      get { return userDefinedMaintenanceFrequencyField; }
      set { userDefinedMaintenanceFrequencyField = value; }
    }

    [XmlElement("updateScope")]
    public MD_ScopeCode_PropertyType[] updateScope
    {
      get { return updateScopeField; }
      set { updateScopeField = value; }
    }

    [XmlElement("updateScopeDescription")]
    public MD_ScopeDescription_PropertyType[] updateScopeDescription
    {
      get { return updateScopeDescriptionField; }
      set { updateScopeDescriptionField = value; }
    }

    [XmlElement("maintenanceNote")]
    public CharacterString_PropertyType[] maintenanceNote
    {
      get { return maintenanceNoteField; }
      set { maintenanceNoteField = value; }
    }

    [XmlElement("contact")]
    public CI_ResponsibleParty_PropertyType[] contact
    {
      get { return contactField; }
      set { contactField = value; }
    }
  }
}
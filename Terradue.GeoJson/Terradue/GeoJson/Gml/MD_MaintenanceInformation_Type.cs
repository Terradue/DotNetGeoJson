namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_MaintenanceInformation_Type : AbstractObject_Type
  {

    private MD_MaintenanceFrequencyCode_PropertyType maintenanceAndUpdateFrequencyField;

    private Date_PropertyType dateOfNextUpdateField;

    private TM_PeriodDuration_PropertyType userDefinedMaintenanceFrequencyField;

    private MD_ScopeCode_PropertyType[] updateScopeField;

    private MD_ScopeDescription_PropertyType[] updateScopeDescriptionField;

    private CharacterString_PropertyType[] maintenanceNoteField;

    private CI_ResponsibleParty_PropertyType[] contactField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_MaintenanceFrequencyCode_PropertyType maintenanceAndUpdateFrequency
    {
      get { return maintenanceAndUpdateFrequencyField; }
      set { maintenanceAndUpdateFrequencyField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Date_PropertyType dateOfNextUpdate
    {
      get { return dateOfNextUpdateField; }
      set { dateOfNextUpdateField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TM_PeriodDuration_PropertyType userDefinedMaintenanceFrequency
    {
      get { return userDefinedMaintenanceFrequencyField; }
      set { userDefinedMaintenanceFrequencyField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("updateScope")]
    public MD_ScopeCode_PropertyType[] updateScope
    {
      get { return updateScopeField; }
      set { updateScopeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("updateScopeDescription")]
    public MD_ScopeDescription_PropertyType[] updateScopeDescription
    {
      get { return updateScopeDescriptionField; }
      set { updateScopeDescriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("maintenanceNote")]
    public CharacterString_PropertyType[] maintenanceNote
    {
      get { return maintenanceNoteField; }
      set { maintenanceNoteField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("contact")]
    public CI_ResponsibleParty_PropertyType[] contact
    {
      get { return contactField; }
      set { contactField = value; }
    }
  }
}